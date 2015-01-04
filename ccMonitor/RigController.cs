using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using ccMonitor.Api;

namespace ccMonitor
{
    public class RigController
    {
        public BindingList<Rig> RigLogs { get; set; }
        public class Rig
        {
            public string Name { get; set; }
            public string IpAddress { get; set; }
            public int Port { get; set; }

            public bool Available { get; set; }
            public List<Tuple<long, bool, bool>> AvailableTimeStamps { get; set; }

            public string UserFriendlyName { get; set; }

            public List<GpuLogger> GpuLogs { get; set; }

            public RigStat CurrentStatistic { get; set; }
            public class RigStat
            {
                public string Algorithm { get; set; }
                public decimal TotalHashCount { get; set; }
                public decimal TotalHashRate { get; set; }
                public decimal AverageHashRate { get; set; }
                public decimal TotalStandardDeviation { get; set; }
                public decimal AverageStandardDeviation { get; set; }
                public decimal AverageVariationCoefficient { get; set; }
                //public decimal[] AveragePercentiles { get; set; }
                public Dictionary<string, decimal> AveragePercentiles { get; set; }
                public decimal LowestHashRate { get; set; }
                public decimal HighestHashRate { get; set; }
                public decimal Accepts { get; set; }
                public decimal Rejects { get; set; }
                public decimal AverageTemperature { get; set; }
                public decimal ShareAnswerPing { get; set; }
            }

            public Rig()
            {
                GpuLogs = new List<GpuLogger>();
                CurrentStatistic = new RigStat();
            }

            public void ChangeAvailability(bool available, bool monitorClosing = false)
            {
                long unixTimeStamp = UnixTimeStamp();
                if (AvailableTimeStamps == null)
                {
                    AvailableTimeStamps = new List<Tuple<long, bool, bool>>
                        {
                            new Tuple<long, bool, bool>(unixTimeStamp, available, monitorClosing )
                        };
                }
                else
                {
                    Tuple<long, bool, bool> prevAvailableTimeStamp =
                        AvailableTimeStamps[AvailableTimeStamps.Count - 1];
                    if (prevAvailableTimeStamp.Item1 != unixTimeStamp && prevAvailableTimeStamp.Item2 != available)
                    {
                        AvailableTimeStamps.Add(new Tuple<long, bool, bool>(unixTimeStamp, available, monitorClosing));
                    }
                }

                Available = available;
            }
        }
        

        public RigController(BindingList<Rig> rigLogs)
        {
            RigLogs = rigLogs;

            Update();
        }

        // No logs available? What a pity, must be a fresh start
        public RigController()
        {
            InitDefaultRig();

            Update();
        }

        private void InitDefaultRig()
        {
            Rig localRig = new Rig
            {
                Name = "Local rig",
                IpAddress = "127.0.0.1",
                Port = 4068, 
                GpuLogs = new List<GpuLogger>(),
            };

            RigLogs = new BindingList<Rig> {localRig};
        }

        public void Update()
        {
            for (int index = 0; index < RigLogs.Count; index++)
            {
                Rig rig = RigLogs[index];

                // Makes sure the rigname the user sees is always correct
                StringBuilder sb = new StringBuilder();
                sb.Append("Rig #").Append(index + 1).Append(", ").Append(rig.Name)
                    .Append(": ").Append(rig.IpAddress).Append(":").Append(rig.Port);
                rig.UserFriendlyName = sb.ToString();
                
                //Gets all API information here first and passes it on
                Dictionary<string, string>[][] allApiResults = new Dictionary<string, string>[4][];
                allApiResults[0] = PruvotApi.GetSummary(rig.IpAddress, rig.Port);
                allApiResults[1] = PruvotApi.GetPoolInfo(rig.IpAddress, rig.Port);
                allApiResults[2] = PruvotApi.GetHwInfo(rig.IpAddress, rig.Port);

                if (allApiResults[0] != null && allApiResults[1] != null && allApiResults[2] != null)
                {
                    // Ping times measuring needs only to be done once too
                    int[] pingTimes = GetPingTimes(allApiResults[1], rig);

                    // If it's a new rig or hardware has been added/removed, it should add/remove it in the logs too
                    CheckLiveGpus(allApiResults, rig);

                    // Prepping for total rig statistics
                    decimal totalHashCount = 0,
                        totalHashRate = 0,
                        totalAverageHashRate = 0,
                        totalStandardDeviation = 0,
                        totalAverageStandardDeviation = 0,
                        totalVariationCoefficient = 0,
                        lowestHashRate = decimal.MaxValue,
                        highestHashRate = 0,
                        totalAverageTemperature = 0;
                    Dictionary<string, decimal> totalPercentiles = new Dictionary<string, decimal>();

                    foreach (GpuLogger gpu in rig.GpuLogs)
                    {
                        allApiResults[3] = gpu.Info.MinerMap != -1
                            ? PruvotApi.GetHistory(rig.IpAddress, rig.Port, gpu.Info.MinerMap)
                            : new Dictionary<string, string>[0];
                        
                        gpu.ChangeAvailability(allApiResults[3] != null);
                        if (gpu.Info.Available)
                        {
                            gpu.Update(allApiResults, pingTimes);

                            // While we're at it, calculate the total stats for the rig
                            totalHashCount += gpu.CurrentBenchmark.CurrentStatistic.TotalHashCount;
                            totalHashRate += gpu.CurrentBenchmark.CurrentStatistic.HarmonicAverageHashRate;
                            totalAverageHashRate += gpu.CurrentBenchmark.CurrentStatistic.HarmonicAverageHashRate*
                                                    gpu.CurrentBenchmark.CurrentStatistic.TotalHashCount;
                            lowestHashRate = lowestHashRate < gpu.CurrentBenchmark.CurrentStatistic.LowestHashRate
                                             ? lowestHashRate
                                             : gpu.CurrentBenchmark.CurrentStatistic.LowestHashRate;
                            highestHashRate = highestHashRate > gpu.CurrentBenchmark.CurrentStatistic.HighestHashRate
                                              ? highestHashRate
                                              : gpu.CurrentBenchmark.CurrentStatistic.HighestHashRate;
                            totalStandardDeviation += gpu.CurrentBenchmark.CurrentStatistic.StandardDeviation;
                            totalAverageStandardDeviation += gpu.CurrentBenchmark.CurrentStatistic.StandardDeviation *
                                                      gpu.CurrentBenchmark.CurrentStatistic.TotalHashCount;
                            totalVariationCoefficient += gpu.CurrentBenchmark.CurrentStatistic.VariationCoefficient*
                                                     gpu.CurrentBenchmark.CurrentStatistic.TotalHashCount;
                            totalAverageTemperature += gpu.CurrentBenchmark.CurrentStatistic.AverageTemperature;

                            if (gpu.CurrentBenchmark.CurrentStatistic.Percentiles != null)
                            {
                                foreach (string percentileName in gpu.CurrentBenchmark.CurrentStatistic.Percentiles.Keys)
                                {
                                    if (totalPercentiles.ContainsKey(percentileName))
                                    {
                                        totalPercentiles[percentileName] +=
                                            gpu.CurrentBenchmark.CurrentStatistic.Percentiles[percentileName]*
                                            gpu.CurrentBenchmark.CurrentStatistic.TotalHashCount;
                                    }
                                    else
                                    {
                                        totalPercentiles.Add(percentileName,
                                            gpu.CurrentBenchmark.CurrentStatistic.Percentiles[percentileName]*
                                            gpu.CurrentBenchmark.CurrentStatistic.TotalHashCount);
                                    }
                                }
                            }

                            if (totalHashRate > 0) rig.Available = true;
                        }
                    }

                    if (rig.GpuLogs.Count > 0 && totalHashCount > 0)
                    {
                        rig.CurrentStatistic = new Rig.RigStat
                        {
                            Algorithm = rig.GpuLogs[rig.GpuLogs.Count - 1].CurrentBenchmark.Algorithm,
                            TotalHashCount = totalHashCount,
                            TotalHashRate = totalHashRate,
                            AverageHashRate = totalAverageHashRate / totalHashCount,
                            TotalStandardDeviation = totalStandardDeviation,
                            AverageStandardDeviation = totalAverageStandardDeviation / totalHashCount,
                            AverageVariationCoefficient = totalVariationCoefficient / totalHashCount,
                            LowestHashRate = lowestHashRate,
                            HighestHashRate = highestHashRate,
                            Accepts = PruvotApi.GetDictValue<int>(allApiResults[0][0], "ACC"),
                            Rejects = PruvotApi.GetDictValue<int>(allApiResults[0][0], "REJ"),
                            AverageTemperature = totalAverageTemperature/rig.GpuLogs.Count,
                            ShareAnswerPing = pingTimes[0],
                            AveragePercentiles = new Dictionary<string, decimal>()
                        };

                        foreach (string percentileName in totalPercentiles.Keys)
                        {
                            if (rig.CurrentStatistic.AveragePercentiles.ContainsKey(percentileName))
                            {
                                rig.CurrentStatistic.AveragePercentiles[percentileName] = 
                                    totalPercentiles[percentileName] / totalHashCount;
                            }
                            else
                            {
                                rig.CurrentStatistic.AveragePercentiles.Add(percentileName,
                                    totalPercentiles[percentileName]/totalHashCount);
                            }
                        }
                    }
                }
                else
                {
                    DisableRig(rig);
                }
            }
        }

        private static void DisableRig(Rig rig, bool monitorClosing = false)
        {
            rig.ChangeAvailability(false, monitorClosing);
            foreach (GpuLogger gpu in rig.GpuLogs)
            {
                gpu.ChangeAvailability(false, monitorClosing);
            }
        }

        public void DisableAllRigs(bool monitorClosing)
        {
            foreach (Rig rig in RigLogs)
            {
                DisableRig(rig, monitorClosing);
            }
        }

        private static void CheckLiveGpus(Dictionary<string, string>[][] allApiResults, Rig rig)
        {
            int apiGpuCount = PruvotApi.GetDictValue<int>(allApiResults[0][0], "GPUS");
            if (rig.GpuLogs.Count < apiGpuCount)
            {
                foreach (Dictionary<string, string> hwInfo in allApiResults[2])
                {
                    GpuLogger newGpu = new GpuLogger
                    {
                        Info = new GpuLogger.GpuInfo
                        {
                            Name = PruvotApi.GetDictValue(hwInfo, "CARD"),
                            Bus = PruvotApi.GetDictValue<int>(hwInfo, "BUS"),
                            MinerMap = PruvotApi.GetDictValue<int>(hwInfo, "GPU"),
                            NvapiId = PruvotApi.GetDictValue<int>(hwInfo, "NVAPI"),
                            NvmlId = PruvotApi.GetDictValue<int>(hwInfo, "NVML"),
                            ComputeCapability = PruvotApi.GetDictValue<uint>(hwInfo, "SM"),
                        },
                        BenchLogs = new List<GpuLogger.Benchmark>()
                    };
                    newGpu.ChangeAvailability(true);
                    

                    if (newGpu.Info.Bus >= 0)
                    {
                        bool found = false;

                        foreach (GpuLogger gpu in rig.GpuLogs)
                        {
                            if (gpu.Info.Equals(newGpu.Info) && gpu.Info.Available)
                            {
                                found = true;
                            }
                        }

                        if (!found)
                        {
                            foreach (GpuLogger gpu in rig.GpuLogs)
                            {
                                // Let's loop again, but now only check for "old" GPUs on that specific bus
                                // Don't delete them, just make them unavailable
                                if (gpu.Info.Bus == newGpu.Info.Bus)
                                {
                                    gpu.ChangeAvailability(false);
                                }
                            }
                            rig.GpuLogs.Add(newGpu);
                        }
                    }
                }
            }

            if (rig.GpuLogs.Count > apiGpuCount)
            {
                foreach (GpuLogger gpu in rig.GpuLogs)
                {
                    bool found = false;
                    foreach (Dictionary<string, string> hwInfo in allApiResults[2])
                    {
                        int apiBus = PruvotApi.GetDictValue<int>(hwInfo, "BUS");
                        if (gpu.Info.Bus == apiBus)
                        {
                            found = true;
                        }
                    }

                    gpu.ChangeAvailability(found);
                }
            }
        }

        private static int[] GetPingTimes(Dictionary<string, string>[] poolInfo, Rig rig)
        {
            if (poolInfo == null || poolInfo.Length == 0) return new[] {333, 333, 333};

            string[] stratum = PruvotApi.GetDictValue<string>(poolInfo[0], "URL").Split('/');
            string[] stratumUrlPort = stratum[stratum.Length - 1].Split(':');

            int[] pingTimes = new int[3];
            Ping pinger = new Ping();
            PingReply miningUrlPing = stratumUrlPort[0] != "-1" ? pinger.Send(stratumUrlPort[0], 333) : null;
            PingReply networkRigPing = pinger.Send(rig.IpAddress, 333);

            // Will try to just ping the URL without subdomain if it failed, 
            // May give bad results but it's just a small stat for fun ^^
            // Ping by Pruvotapi is more accurate
            // PS: Let's hope it's not a .co.uk :D
            if (miningUrlPing != null && miningUrlPing.Status != IPStatus.Success)
            {
                string[] stratumDomains = stratumUrlPort[0].Split('.');
                string lastParts = stratumDomains[stratumDomains.Length - 2] + '.' +
                                   stratumDomains[stratumDomains.Length - 1];
                miningUrlPing = pinger.Send(lastParts, 333);
            }

            pingTimes[0] = PruvotApi.GetDictValue<int>(poolInfo[0], "PING");
            pingTimes[1] = (int) (miningUrlPing != null && miningUrlPing.Status == IPStatus.Success
                            ? miningUrlPing.RoundtripTime : 333);
            pingTimes[2] = (int) (networkRigPing != null && networkRigPing.Status == IPStatus.Success
                            ? networkRigPing.RoundtripTime : 333);

            return pingTimes;
        }

        private static long UnixTimeStamp()
        {
            return (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }
    }
}
