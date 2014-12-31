using System;
using System.Collections.Generic;
using System.Data;
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
            public int NvmlId { get; set; }
            public int Bus { get; set; }
            public int MinerMap { get; set; }

            public uint ComputeCapability { get; set; }

            private bool _available;
            public List<Tuple<long,bool>> AvailableTimeStamps { get; set; } 
            // long: unix timestamp, bool: availability
            public bool Available
            {
                get { return _available; }
                set
                {
                    long unixTimeStamp = UnixTimeStamp();
                    if (AvailableTimeStamps == null)
                    {
                        AvailableTimeStamps = new List<Tuple<long, bool>>()
                        {
                            new Tuple<long, bool>(unixTimeStamp, value)
                        };
                    }
                    else
                    {
                        Tuple<long, bool> prevAvailableTimeStamp = AvailableTimeStamps[AvailableTimeStamps.Count - 1];
                        if (prevAvailableTimeStamp.Item1 != unixTimeStamp && prevAvailableTimeStamp.Item2 != value)
                        {
                            AvailableTimeStamps.Add(new Tuple<long, bool>(unixTimeStamp, value));
                        }
                    }
                    _available = value;
                }
            }

            public override string ToString()
            {
                return "GPU #" + MinerMap;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((GpuInfo) obj);
            }

            private bool Equals(GpuInfo other)
            {
                return string.Equals(Name, other.Name) && NvapiId == other.NvapiId && NvmlId == other.NvmlId &&
                    Bus == other.Bus && MinerMap == other.MinerMap && ComputeCapability == other.ComputeCapability;
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    int hashCode = (Name != null ? Name.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ NvapiId;
                    hashCode = (hashCode * 397) ^ NvmlId;
                    hashCode = (hashCode * 397) ^ Bus;
                    hashCode = (hashCode * 397) ^ MinerMap;
                    hashCode = (hashCode * 397) ^ (int)ComputeCapability;
                    return hashCode;
                }
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
            public class HashEntry
            {
                public long TimeStamp { get; set; }
                public double HashRate { get; set; } // In KH/s
                public uint HashCount { get; set; } // Amount of hash tries before the entry happened
                public uint Found { get; set; } // Sometimes they can find more than one solution at once
                public double Difficulty { get; set; }
                public uint Height { get; set; }
                
                public override bool Equals(object obj)
                {
                    if (ReferenceEquals(null, obj)) return false;
                    if (ReferenceEquals(this, obj)) return true;
                    if (obj.GetType() != this.GetType()) return false;
                    return Equals((HashEntry) obj);
                }

                private bool Equals(HashEntry other)
                {
                    return TimeStamp == other.TimeStamp && HashRate.Equals(other.HashRate)
                        && HashCount == other.HashCount && Found == other.Found
                        && Difficulty.Equals(other.Difficulty) && Height == other.Height;
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
                        hashCode = (hashCode * 397) ^ (int)Height;
                        return hashCode;
                    }
                }
            }
            
            public Setup MinerSetup { get; set; }
            public class Setup
            {
                public string MinerName { get; set; }
                public string MinerVersion { get; set; }
                public string ApiVersion { get; set; }

                public string MiningUrl { get; set; }
                public double Intensity { get; set; }

                public string PerformanceState { get; set; }
                public string BiosVersion { get; set; }
                public string DriverVersion { get; set; }
                public string OperatingSystem { get; set; }

                public override bool Equals(object obj)
                {
                    if (ReferenceEquals(null, obj)) return false;
                    if (ReferenceEquals(this, obj)) return true;
                    if (obj.GetType() != this.GetType()) return false;
                    return Equals((Setup)obj);
                }

                private bool Equals(Setup other)
                {
                    return String.Equals(MinerName, (string)other.MinerName) && String.Equals(MinerVersion, (string)other.MinerVersion)
                           && String.Equals(ApiVersion, (string)other.ApiVersion) && String.Equals(MiningUrl, (string)other.MiningUrl)
                           && Intensity.Equals(other.Intensity) && String.Equals(PerformanceState, (string)other.PerformanceState)
                           && String.Equals(BiosVersion, (string)other.BiosVersion) && String.Equals(DriverVersion, (string)other.DriverVersion)
                           && String.Equals(OperatingSystem, (string)other.OperatingSystem);
                }

                public override int GetHashCode()
                {
                    unchecked
                    {
                        int hashCode = (MinerName != null ? MinerName.GetHashCode() : 0);
                        hashCode = (hashCode * 397) ^ (MinerVersion != null ? MinerVersion.GetHashCode() : 0);
                        hashCode = (hashCode * 397) ^ (ApiVersion != null ? ApiVersion.GetHashCode() : 0);
                        hashCode = (hashCode * 397) ^ (MiningUrl != null ? MiningUrl.GetHashCode() : 0);
                        hashCode = (hashCode * 397) ^ Intensity.GetHashCode();
                        hashCode = (hashCode * 397) ^ (PerformanceState != null ? PerformanceState.GetHashCode() : 0);
                        hashCode = (hashCode * 397) ^ (BiosVersion != null ? BiosVersion.GetHashCode() : 0);
                        hashCode = (hashCode * 397) ^ (DriverVersion != null ? DriverVersion.GetHashCode() : 0);
                        hashCode = (hashCode * 397) ^ (OperatingSystem != null ? OperatingSystem.GetHashCode() : 0);
                        return hashCode;
                    }
                }

                public override string ToString()
                {
                    return MinerName + " " + MinerVersion + " (APIv" + ApiVersion + ")";
                }
            }
            
            public GpuStat Statistic { get; set; }
            public class GpuStat
            {
                public double TotalHashCount { get; set; }
                public double AverageHashRate { get; set; }
                public double StandardDeviation { get; set; }
                public double SpreadPercentage { get; set; }
                public Dictionary<string, double> Percentiles { get; set; }
                public double LowestHashRate { get; set; }
                public double HighestHashRate { get; set; }
                public int Founds { get; set; } // Taken from FOUND in hashentries
                public double AverageTemperature { get; set; }
                public double AverageShareAnswerPing { get; set; }

                public List<RollingAverage> RollingAverages { get; set; }
                public class RollingAverage
                {
                    public long TimeStamp { get; set; }
                    public double AverageHashRate { get; set; }
                    public double SpreadTopHashRate { get; set; }
                    public double SpreadBottomHashRate { get; set; }
                }
            }
            
            public List<SensorValue> SensorLog { get; set; }
            public class SensorValue
            {
                public long TimeStamp { get; set; }

                public double Temperature { get; set; }
                public double FanPercentage { get; set; }
                public double FanRpm { get; set; }
                public double CoreClockFrequency { get; set; }
                public double MemoryClockFrequency { get; set; }

                public int ShareAnswerPing { get; set; } // Ping from rig to stratum
                public int MiningUrlPing { get; set; } // Ping from this PC to stratum
                public int NetworkRigPing { get; set; } // Ping from this PC to rig
            }
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

            Benchmark.Setup liveSetup = GetLiveSetup(rightHwInfo, totalHwInfo[totalHwInfo.Length - 1], summary, poolInfo);
            
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

        private static Benchmark.Setup GetLiveSetup(Dictionary<string, string> hwInfo, Dictionary<string, string> setupInfo,
            Dictionary<string, string>[] summary, Dictionary<string, string>[] poolInfo)
        {
            Benchmark.Setup minerSetup = new Benchmark.Setup
            {
                MinerName = PruvotApi.GetDictValue(summary[0], "NAME"),
                MinerVersion = PruvotApi.GetDictValue(summary[0], "VER"),
                ApiVersion = PruvotApi.GetDictValue(summary[0], "API"),
                MiningUrl = poolInfo.Length > 0 ? PruvotApi.GetDictValue(poolInfo[0], "URL"): string.Empty,
                //Intensity = PruvotApi.GetDictValue<double>(hwInfo, "I"),
                PerformanceState = PruvotApi.GetDictValue(hwInfo, "PST"),
                BiosVersion = PruvotApi.GetDictValue(hwInfo, "BIOS"),
                DriverVersion = PruvotApi.GetDictValue(setupInfo, "NVDRIVER"),
                OperatingSystem = PruvotApi.GetDictValue(setupInfo, "OS"),
            };

            return minerSetup;
        }

        private void UpdateSensors(Dictionary<string, string> hwInfo, int[] pingTimes)
        {
            Benchmark.SensorValue sensorValue = new Benchmark.SensorValue
            {
                TimeStamp = UnixTimeStamp(),
                Temperature = PruvotApi.GetDictValue<double>(hwInfo, "TEMP"),
                FanPercentage = PruvotApi.GetDictValue<double>(hwInfo, "FAN"),
                FanRpm = PruvotApi.GetDictValue<double>(hwInfo, "RPM"),
                CoreClockFrequency = PruvotApi.GetDictValue<double>(hwInfo, "FREQ"),
                MemoryClockFrequency = PruvotApi.GetDictValue<double>(hwInfo, "MEMFREQ"),
                ShareAnswerPing = pingTimes[0],
                MiningUrlPing = pingTimes[1],
                NetworkRigPing = pingTimes[2]
            };

            CurrentBenchmark.SensorLog.Add(sensorValue);
        }

        private void UpdateHashLog(Dictionary<string, string>[] history)
        {
            foreach (Dictionary<string, string> hash in history)
            {
                Benchmark.HashEntry hashEntry = new Benchmark.HashEntry
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
                    CurrentBenchmark.Statistic.Founds += (int) hashEntry.Found;
                }
            }
        }

        private void UpdateStats()
        {
            UpdateSensorStats();
            UpdateTotalHashRateStats();
            UpdateRollingAverages();
        }

        private void UpdateRollingAverages()
        {
            List<Benchmark.HashEntry> hashList = CurrentBenchmark.HashLogs
                    .Where(entry => entry.TimeStamp > UnixTimeStamp() - 3600)
                    .OrderBy(entry => entry.TimeStamp)
                    .ToList();
            int hashLogSize = hashList.Count;
            double sumOfWeightedRates = 0;
            double totalWeight = 0;
            double[] rates = new double[hashLogSize];
            double[] weights = new double[hashLogSize];
            Benchmark.GpuStat.RollingAverage roller = new Benchmark.GpuStat.RollingAverage()
            {
                TimeStamp = UnixTimeStamp()
            };

            for (int i = 0; i < hashLogSize; i++)
            {
                rates[i] = hashList[i].HashRate;
                weights[i] = hashList[i].HashCount;

                sumOfWeightedRates += (rates[i] * weights[i]);
                totalWeight += weights[i];
            }

            if (totalWeight != 0)
            {
                roller.AverageHashRate = sumOfWeightedRates/totalWeight;

                double weightCounter = 0;
                Array.Sort(rates, weights);
                for (int i = 0; i < hashLogSize; i++)
                {
                    weights[i] = weights[i] / CurrentBenchmark.Statistic.TotalHashCount;
                    weightCounter += weights[i];
                    if (weightCounter >= 0.045500263896358 && roller.SpreadBottomHashRate == 0)
                    {
                        roller.SpreadBottomHashRate = rates[i];
                    }

                    if (weightCounter > 0.954499736103642 && !CurrentBenchmark.Statistic.Percentiles.ContainsKey("+2σ"))
                    {
                        roller.SpreadTopHashRate = i > 0 ? rates[i - 1] : rates[i];
                    }
                }

                if (CurrentBenchmark.Statistic.RollingAverages == null)
                {
                    CurrentBenchmark.Statistic.RollingAverages = new List<Benchmark.GpuStat.RollingAverage>();
                }

                CurrentBenchmark.Statistic.RollingAverages.Add(roller);
                
            }
        }

        private void UpdateSensorStats()
        {
            int count;
            double totalTemp = 0, totalPing = 0;

            for (count = 0; count < CurrentBenchmark.SensorLog.Count; count++)
            {
                Benchmark.SensorValue sensorValue = CurrentBenchmark.SensorLog[count];
                totalTemp += sensorValue.Temperature;
                totalPing += sensorValue.ShareAnswerPing;
            }

            CurrentBenchmark.Statistic.AverageTemperature = totalTemp / count;
            CurrentBenchmark.Statistic.AverageShareAnswerPing = Math.Round(totalPing/ count, MidpointRounding.AwayFromZero);
        }

        private void UpdateTotalHashRateStats()
        {
            List<Benchmark.HashEntry> hashList = CurrentBenchmark.HashLogs.ToList();
            int hashLogSize = hashList.Count;
            double sumOfWeightedRates = 0;
            double[] rates = new double[hashLogSize];
            double[] weights = new double[hashLogSize];
            CurrentBenchmark.Statistic.TotalHashCount = 0;

            for (int i = 0; i < hashLogSize; i++)
            {
                rates[i] = hashList[i].HashRate;
                weights[i] = hashList[i].HashCount;

                sumOfWeightedRates += (rates[i]*weights[i]);
                CurrentBenchmark.Statistic.TotalHashCount += hashList[i].HashCount;
            }

            // Let's avoid dividing by zero
            if (CurrentBenchmark.Statistic.TotalHashCount != 0)
            {
                CurrentBenchmark.Statistic.AverageHashRate = sumOfWeightedRates / CurrentBenchmark.Statistic.TotalHashCount;
                Dictionary<string, double> percentiles = new Dictionary<string, double>();
                double weightCounter = 0, sumOfSquaresOfDifferences = 0;
                Array.Sort(rates, weights);

                for (int i = 0; i < hashLogSize; i++)
                {
                    sumOfSquaresOfDifferences += (((rates[i] - CurrentBenchmark.Statistic.AverageHashRate)
                                                   *(rates[i] - CurrentBenchmark.Statistic.AverageHashRate))*weights[i]);

                    weights[i] = weights[i] / CurrentBenchmark.Statistic.TotalHashCount;
                    weightCounter += weights[i];
                    

                    if (weightCounter >= 0.00269979606326 && !percentiles.ContainsKey("-3σ"))
                    {
                        percentiles.Add("-3σ", rates[i]);
                    }

                    if (weightCounter >= 0.012419330651552 && !percentiles.ContainsKey("-2.5σ"))
                    {
                        percentiles.Add("-2.5σ", rates[i]);
                    }

                    if (weightCounter >= 0.045500263896358 && !percentiles.ContainsKey("-2σ"))
                    {
                        percentiles.Add("-2σ", rates[i]);
                    }

                    if (weightCounter >= 0.133614402537716 && !percentiles.ContainsKey("-1.5σ"))
                    {
                        percentiles.Add("-1.5σ", rates[i]);
                    }

                    if (weightCounter >= 0.25 && !percentiles.ContainsKey("Q1"))
                    {
                        percentiles.Add("Q1", rates[i]);
                    }

                    if (weightCounter >= 0.317310507862914 && !percentiles.ContainsKey("-1σ"))
                    {
                        percentiles.Add("-1σ", rates[i]);
                    }

                    if (weightCounter >= 0.5 && !percentiles.ContainsKey("0σ"))
                    {
                        percentiles.Add("0σ", rates[i]);
                    }

                    if (weightCounter >= 0.682689492137086 && !percentiles.ContainsKey("+1σ"))
                    {
                        percentiles.Add("+1σ", rates[i]);
                    }

                    if (weightCounter >= 0.75 && !percentiles.ContainsKey("Q3"))
                    {
                        percentiles.Add("Q3", rates[i]);
                    }

                    if (weightCounter >= 0.866385597462284 && !percentiles.ContainsKey("+1.5σ"))
                    {
                        percentiles.Add("+1.5σ", rates[i]);
                    }

                    if (weightCounter >= 0.954499736103642 && !percentiles.ContainsKey("+2σ"))
                    {
                        percentiles.Add("+2σ", rates[i]);
                    }
                    
                    if (weightCounter >= 0.987580669348448 && !percentiles.ContainsKey("+2.5σ"))
                    {
                        percentiles.Add("+2.5σ", rates[i]);
                    }

                    if (weightCounter >= 0.997300203936740 && !percentiles.ContainsKey("+3σ"))
                    {
                        percentiles.Add("+3σ", rates[i]);
                    }
                }

                CurrentBenchmark.Statistic.Percentiles = percentiles;
                CurrentBenchmark.Statistic.StandardDeviation =
                    Math.Sqrt(sumOfSquaresOfDifferences/CurrentBenchmark.Statistic.TotalHashCount);
                CurrentBenchmark.Statistic.SpreadPercentage =
                    CurrentBenchmark.Statistic.StandardDeviation/CurrentBenchmark.Statistic.AverageHashRate;
                CurrentBenchmark.Statistic.LowestHashRate = rates[0];
                CurrentBenchmark.Statistic.HighestHashRate = rates[rates.Length - 1];
            }
        }

        private void CreateNewBenchMark(string liveAlgo, Benchmark.Setup liveSetup)
        {
            Benchmark benchmark = new Benchmark
            {
                TimeStamp = UnixTimeStamp(),
                Algorithm = liveAlgo,
                MinerSetup = liveSetup,
                Active = true,
                HashLogs = new HashSet<Benchmark.HashEntry>(),
                SensorLog = new List<Benchmark.SensorValue>(),
                Statistic = new Benchmark.GpuStat()
            };

            // Makes all the old benchmarks with the same algo inactive
            foreach (Benchmark benchLog in BenchLogs)
            {
                if (benchLog.Algorithm != liveAlgo) continue;
                benchLog.Active = false;
            }

            BenchLogs.Add(benchmark);
        }

        public void RestartCurrentBenchmark()
        {
            CreateNewBenchMark(CurrentBenchmark.Algorithm, CurrentBenchmark.MinerSetup);
        }
        
        private static long UnixTimeStamp()
        {
            return (long) (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }
    }
}
