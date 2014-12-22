using System;
using System.Collections.Generic;
using System.Linq;
using ccMonitor.Api;

namespace ccMonitor
{
    public class GpuLogger
    {
        // Contains all the info we want to know about a certain GPU
        public GpuInfo Info { get; set; }
        public class GpuInfo
        {
            public string Name { get; set; }
            public int NvapiId { get; set; }
            public int Bus { get; set; }
            public int MinerMap { get; set; }
            public bool Available { get; set; }

            public override string ToString()
            {
                return "GPU #" + MinerMap;
            }
        }

        public Benchmark CurrentBenchmark { get; set; } // Quick ref to latest benchmark
        public List<Benchmark> BenchLogs { get; set; }
        public class Benchmark
        {
            public long TimeStamp { get; set; }
            public string Algorithm { get; set; }
            public bool Active { get; set; }

            public HashSet<HashEntry> HashLogs { get; set; }
            
            public Setup MinerSetup { get; set; }

            public Stat Statistic { get; set; }

            public List<SensorValues> SensorLog { get; set; }
        }

        public class HashEntry
        {
            public long TimeStamp { get; set; }
            public double HashRate { get; set; } // In KH/s
            public uint HashCount { get; set; } // Amount of hash tries before the entry happened
            // HashCount is useful to give a weight to the average. Low HashCount entries aren't accurate.
            public uint Found { get; set; } // Sometimes they can find more than one solution at once
            public uint Height { get; set; }
            public double Difficulty { get; set; }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((HashEntry) obj);
            }

            protected bool Equals(HashEntry other)
            {
                return TimeStamp == other.TimeStamp && HashRate.Equals(other.HashRate) && 
                    HashCount == other.HashCount && Found == other.Found && Difficulty.Equals(other.Difficulty);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    int hashCode = TimeStamp.GetHashCode();
                    hashCode = (hashCode * 397) ^ HashRate.GetHashCode();
                    hashCode = (hashCode * 397) ^ (int)HashCount;
                    hashCode = (hashCode * 397) ^ (int)Found;
                    hashCode = (hashCode * 397) ^ Difficulty.GetHashCode();
                    return hashCode;
                }
            }
        }

        public class Setup
        {
            protected bool Equals(Setup other)
            {
                return string.Equals(MinerName, other.MinerName) && string.Equals(MinerVersion, other.MinerVersion) && 
                    string.Equals(ApiVersion, other.ApiVersion) && string.Equals(MiningUrl, other.MiningUrl) && 
                    string.Equals(PerformanceState, other.PerformanceState) && string.Equals(BiosVersion, other.BiosVersion) && 
                    string.Equals(DriverVersion, other.DriverVersion) && string.Equals(OperatingSystem, other.OperatingSystem);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    int hashCode = (MinerName != null ? MinerName.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (MinerVersion != null ? MinerVersion.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (ApiVersion != null ? ApiVersion.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (MiningUrl != null ? MiningUrl.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (PerformanceState != null ? PerformanceState.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (BiosVersion != null ? BiosVersion.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (DriverVersion != null ? DriverVersion.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (OperatingSystem != null ? OperatingSystem.GetHashCode() : 0);
                    return hashCode;
                }
            }

            public string MinerName { get; set; }
            public string MinerVersion { get; set; }
            public string ApiVersion { get; set; }
            public string MiningUrl { get; set; }

            public string PerformanceState { get; set; }
            public string BiosVersion { get; set; }
            public string DriverVersion { get; set; }
            public string OperatingSystem { get; set; }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((Setup) obj);
            }
        }

        public class Stat
        {
            public double TotalHashCount { get; set; }
            public double AverageHashRate { get; set; }
            public double MeanHashRate { get; set; }
            public double StandardDeviation { get; set; }
            public double SpreadPercentage { get; set; }
            public double[] GaussianPercentiles { get; set; }
            public double LowestHashRate { get; set; }
            public double HighestHashRate { get; set; }
            public int Accepts { get; set; } // Taken from FOUND in hashentries
            public double AverageTemperature { get; set; }
            public double AverageShareAnswerPing { get; set; }
        }

        public class SensorValues
        {
            public long TimeStamp { get; set; }

            public double Temperature{ get; set; }
            public double FanPercentage { get; set; }
            public double CoreClockFrequency { get; set; }
            public double MemoryClockFrequency { get; set; }

            public int ShareAnswerPing { get; set; } // Ping from rig to stratum
            public int MiningUrlPing { get; set; } // Ping from this PC to stratum
            public int NetworkRigPing { get; set; } // Ping from this PC to rig
        }

        public GpuLogger()
        {
        }

        public void Update(Dictionary<string, string>[][] allApiResults, int[] pingTimes)
        {
            Dictionary<string, string>[] history = allApiResults[3];
            Dictionary<string, string>[] summary = allApiResults[0];
            Dictionary<string, string>[] poolInfo = allApiResults[1];
            Dictionary<string, string>[] totalHwInfo = allApiResults[2]; 
            Dictionary<string, string> rightHwInfo = new Dictionary<string, string>();
            foreach (Dictionary<string, string> hwInfo in totalHwInfo)
            {
                if (Info.Bus == PruvotApi.GetDictValue<int>(hwInfo, "BUS"))
                {
                    rightHwInfo = hwInfo;
                    break;
                }
            }

            string liveAlgo = PruvotApi.GetDictValue<string>(summary[0], "ALGO");
            Benchmark currentBenchmark = null; 
            // CurrentBenchmark is the one with the right live algo and is active
            // If there's a new algo, currentBenchmark will stay null
            foreach (Benchmark benchmark in BenchLogs)
            {
                if (benchmark.Active && benchmark.Algorithm == liveAlgo)
                {
                    currentBenchmark = benchmark;
                    break;
                }
            }

            Setup liveSetup = GetLiveSetup(rightHwInfo, totalHwInfo[totalHwInfo.Length - 1], summary, poolInfo);
            
            // If currentBenchmark remained null because of an unknown algo,new install or change of setup,
            // It will create a new benchmark and update again
            if (currentBenchmark != null && liveSetup.Equals(currentBenchmark.MinerSetup))
            {
                CurrentBenchmark = currentBenchmark;
                CurrentBenchmark.MinerSetup.ApiVersion = liveSetup.ApiVersion;

                UpdateSensors(rightHwInfo, pingTimes);
                // Updates the hardware sensors + "network sensors"

                UpdateHashLog(history);

                UpdateStats();
                // Calculates the statistics from previous information
            }
            else
            {
                CreateNewBenchMark(liveAlgo, liveSetup);
                Update(allApiResults, pingTimes);
            }
        }

        private static Setup GetLiveSetup(Dictionary<string, string> hwInfo, Dictionary<string, string> setupInfo,
            Dictionary<string, string>[] summary, Dictionary<string, string>[] poolInfo)
        {
            Setup minerSetup = new Setup
            {
                MinerName = PruvotApi.GetDictValue(summary[0], "NAME"),
                MinerVersion = PruvotApi.GetDictValue(summary[0], "VER"),
                ApiVersion = PruvotApi.GetDictValue(summary[0], "API"),
                MiningUrl = poolInfo.Length > 0 ? PruvotApi.GetDictValue(poolInfo[0], "URL"): string.Empty,
                PerformanceState = PruvotApi.GetDictValue(hwInfo, "PST"),
                BiosVersion = PruvotApi.GetDictValue(hwInfo, "BIOS"),
                DriverVersion = PruvotApi.GetDictValue(setupInfo, "NVDRIVER"),
                OperatingSystem = PruvotApi.GetDictValue(setupInfo, "OS"),
            };

            return minerSetup;
        }

        private void UpdateSensors(Dictionary<string, string> hwInfo, int[] pingTimes)
        {
            SensorValues sensorValues = new SensorValues
            {
                TimeStamp = UnixTimeStamp(),
                Temperature = PruvotApi.GetDictValue<double>(hwInfo, "TEMP"),
                FanPercentage = PruvotApi.GetDictValue<double>(hwInfo, "FAN"),
                CoreClockFrequency = PruvotApi.GetDictValue<double>(hwInfo, "FREQ"),
                MemoryClockFrequency = PruvotApi.GetDictValue<double>(hwInfo, "MEMFREQ"),
                ShareAnswerPing = pingTimes[0],
                MiningUrlPing = pingTimes[1],
                NetworkRigPing = pingTimes[2]
            };

            CurrentBenchmark.SensorLog.Add(sensorValues);
        }

        private void UpdateHashLog(Dictionary<string, string>[] history)
        {
            foreach (Dictionary<string, string> hash in history)
            {
                HashEntry hashEntry = new HashEntry
                {
                    TimeStamp = PruvotApi.GetDictValue<uint>(hash, "TS"),
                    HashRate = PruvotApi.GetDictValue<double>(hash, "KHS"),
                    HashCount = PruvotApi.GetDictValue<uint>(hash, "COUNT"),
                    Found = PruvotApi.GetDictValue<uint>(hash, "FOUND"),
                    Height = PruvotApi.GetDictValue<uint>(hash, "H"),
                    Difficulty = PruvotApi.GetDictValue<double>(hash, "DIFF")
                };

                if (CurrentBenchmark.HashLogs.Add(hashEntry))
                {
                    CurrentBenchmark.Statistic.Accepts += (int) hashEntry.Found;
                }
            }
        }

        private void UpdateStats()
        {
            UpdateSensorStats();
            UpdateHashRateStats();
        }

        private void UpdateSensorStats()
        {
            int count;
            double totalTemp = 0, totalPing = 0;

            for (count = 0; count < CurrentBenchmark.SensorLog.Count; count++)
            {
                SensorValues sensorValue = CurrentBenchmark.SensorLog[count];
                totalTemp += sensorValue.Temperature;
                totalPing += sensorValue.ShareAnswerPing;
            }

            CurrentBenchmark.Statistic.AverageTemperature = totalTemp / count;
            CurrentBenchmark.Statistic.AverageShareAnswerPing = Math.Round(totalPing/ count, MidpointRounding.AwayFromZero);
        }

        private void UpdateHashRateStats()
        {
            int hashLogSize = CurrentBenchmark.HashLogs.Count;
            List<HashEntry> hashList = CurrentBenchmark.HashLogs.ToList();
            double sumOfWeightedRates = 0, sumOfWeights = 0;
            double[] rates = new double[hashLogSize];
            double[] weights = new double[hashLogSize];

            for (int i = 0; i < hashLogSize; i++)
            {
                rates[i] = hashList[i].HashRate;
                weights[i] = hashList[i].HashCount;

                sumOfWeightedRates += (rates[i]*weights[i]);
                sumOfWeights += weights[i];
            }

            // Let's avoid dividing by zero
            if (sumOfWeights != 0)
            {
                CurrentBenchmark.Statistic.TotalHashCount = sumOfWeights;
                CurrentBenchmark.Statistic.AverageHashRate = sumOfWeightedRates/sumOfWeights;
                CurrentBenchmark.Statistic.GaussianPercentiles = new double[6];
                double weightCounter = 0, sumOfSquaresOfDifferences = 0;
                Array.Sort(rates, weights);

                for (int i = 0; i < hashLogSize; i++)
                {
                    sumOfSquaresOfDifferences += ((rates[i] - CurrentBenchmark.Statistic.AverageHashRate)
                                                  *(rates[i] - CurrentBenchmark.Statistic.AverageHashRate));

                    weights[i] = weights[i]/sumOfWeights;
                    weightCounter += weights[i];

                    // -2σ
                    if (CurrentBenchmark.Statistic.GaussianPercentiles[0] == 0 && weightCounter >= 0.045500263896358)
                    {
                        CurrentBenchmark.Statistic.GaussianPercentiles[0] = rates[i];
                    }

                    // -1.5σ
                    if (CurrentBenchmark.Statistic.GaussianPercentiles[1] == 0 && weightCounter >= 0.133614402537716)
                    {
                        CurrentBenchmark.Statistic.GaussianPercentiles[1] = rates[i];
                    }

                    // -1σ
                    if (CurrentBenchmark.Statistic.GaussianPercentiles[2] == 0 && weightCounter >= 0.317310507862914)
                    {
                        CurrentBenchmark.Statistic.GaussianPercentiles[2] = rates[i];
                    }

                    // 0σ
                    if (CurrentBenchmark.Statistic.MeanHashRate == 0 && weightCounter >= 0.5)
                    {
                        CurrentBenchmark.Statistic.MeanHashRate = rates[i];
                    }

                    // +1σ
                    if (CurrentBenchmark.Statistic.GaussianPercentiles[3] == 0 && weightCounter > 0.682689492137086)
                    {
                        CurrentBenchmark.Statistic.GaussianPercentiles[3] = i - 1 >= 0 ? rates[i - 1] : rates[i];
                    }

                    // +1.5σ
                    if (CurrentBenchmark.Statistic.GaussianPercentiles[4] == 0 && weightCounter > 0.866385597462284)
                    {
                        CurrentBenchmark.Statistic.GaussianPercentiles[4] = i - 1 >= 0 ? rates[i - 1] : rates[i];
                    }

                    // +2σ
                    if (CurrentBenchmark.Statistic.GaussianPercentiles[5] == 0 && weightCounter > 0.954499736103642)
                    {
                        CurrentBenchmark.Statistic.GaussianPercentiles[5] = i - 1 >= 0 ? rates[i - 1] : rates[i];
                    }
                }

                CurrentBenchmark.Statistic.StandardDeviation = Math.Sqrt(sumOfSquaresOfDifferences/(hashLogSize));
                CurrentBenchmark.Statistic.SpreadPercentage = CurrentBenchmark.Statistic.StandardDeviation/
                                                              CurrentBenchmark.Statistic.AverageHashRate;
                CurrentBenchmark.Statistic.LowestHashRate = rates[0];
                CurrentBenchmark.Statistic.HighestHashRate = rates[rates.Length - 1];
            }
        }

        private void CreateNewBenchMark(string liveAlgo, Setup liveSetup)
        {
            Benchmark benchmark = new Benchmark
            {
                TimeStamp = UnixTimeStamp(),
                Algorithm = liveAlgo,
                MinerSetup = liveSetup,
                Active = true,
                HashLogs = new HashSet<HashEntry>(),
                SensorLog = new List<SensorValues>(),
                Statistic = new Stat()
            };

            // Makes all the old benchmarks with the same algo inactive
            foreach (Benchmark benchLog in BenchLogs)
            {
                if (benchLog.Algorithm != liveAlgo) continue;
                benchLog.Active = false;
            }

            BenchLogs.Add(benchmark);
        }
        
        private static long UnixTimeStamp()
        {
            return (long) (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }
    }
}
