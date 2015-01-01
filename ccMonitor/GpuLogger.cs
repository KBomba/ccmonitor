using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
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

            public bool Available { get; set; }
            public List<Tuple<long,bool,bool>> AvailableTimeStamps { get; set; } 
            // long: unix timestamp, bool: availability

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
            public long TimeHistoStart { get; set; }
            public long TimeHistoLast { get; set; }
            public long TimeInHisto { get; set; }

            public string Algorithm { get; set; }
            public bool Active { get; set; }

            public HashSet<HashEntry> HashLogs { get; set; }
            public class HashEntry
            {
                public long TimeStamp { get; set; }
                public decimal HashRate { get; set; } // In KH/s
                public uint HashCount { get; set; } // Amount of hash tries before the entry happened
                public uint Found { get; set; } // Sometimes they can find more than one solution at once
                public decimal Difficulty { get; set; }
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
                public decimal Intensity { get; set; }

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
                public decimal TotalHashCount { get; set; }

                public decimal ArithmeticAverageHashRate { get; set; }
                public decimal GeometricAverageHashrate { get; set; }
                public decimal HarmonicAverageHashRate { get; set; }
                public decimal RootMeanSquare { get; set; }

                public decimal Skewness { get; set; }
                public decimal Kurtosis { get; set; }
                public decimal Variance { get; set; }
                public decimal StandardDeviation { get; set; }
                public decimal[][] AbsoluteDeviations { get; set; }
                // All MAD: Mean/Median/Max Absolute Deviation about mean/median
                // 1:: median about 1: median, 2: mean
                // 2:: mean/average about 1: median, 2: mean
                // 3:: max about 1: median, 2: mean
                public decimal MadStdFactor { get; set; }
                public decimal DispersionCoefficient { get; set; }
                public decimal VariationCoefficient { get; set; }
                public decimal QuartileCoefficient { get; set; }
                public decimal InterquartileRange { get; set; }
                public decimal InterRange { get; set; }
                public decimal LowestHashRate { get; set; }
                public decimal HighestHashRate { get; set; }
                public Dictionary<string, decimal> Percentiles { get; set; }
                public Tuple<List<decimal>, uint>[] GroupedRates { get; set; }
                // I like complex collections ^^"
                // An array of soon-to-be 100 groups for each hashrate according to their position
                // The list will hold the exact rate values 
                // The extra uint will hold the total hashcount for that range

                public int Founds { get; set; } // Taken from FOUND in hashentries
                public decimal AverageTemperature { get; set; }
                public decimal AverageShareAnswerPing { get; set; }
                
                public List<RollingAverage> RollingAverages { get; set; }
                public class RollingAverage
                {
                    public long TimeStamp { get; set; }
                    public decimal AverageHashRate { get; set; }
                    public decimal SpreadTopHashRate { get; set; }
                    public decimal SpreadBottomHashRate { get; set; }
                }
            }
            
            public List<SensorValue> SensorLog { get; set; }
            public class SensorValue
            {
                public long TimeStamp { get; set; }

                public decimal Temperature { get; set; }
                public decimal FanPercentage { get; set; }
                public decimal FanRpm { get; set; }
                public decimal CoreClockFrequency { get; set; }
                public decimal MemoryClockFrequency { get; set; }

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
                //Intensity = PruvotApi.GetDictValue<decimal>(hwInfo, "I"),
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
                Temperature = PruvotApi.GetDictValue<decimal>(hwInfo, "TEMP"),
                FanPercentage = PruvotApi.GetDictValue<decimal>(hwInfo, "FAN"),
                FanRpm = PruvotApi.GetDictValue<decimal>(hwInfo, "RPM"),
                CoreClockFrequency = PruvotApi.GetDictValue<decimal>(hwInfo, "FREQ"),
                MemoryClockFrequency = PruvotApi.GetDictValue<decimal>(hwInfo, "MEMFREQ"),
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
                    HashRate = PruvotApi.GetDictValue<decimal>(hash, "KHS"),
                    HashCount = PruvotApi.GetDictValue<uint>(hash, "COUNT"),
                    Found = PruvotApi.GetDictValue<uint>(hash, "FOUND"),
                    Height = PruvotApi.GetDictValue<uint>(hash, "H"),
                    Difficulty = PruvotApi.GetDictValue<decimal>(hash, "DIFF")
                };

                if (CurrentBenchmark.HashLogs.Add(hashEntry))
                {
                    CurrentBenchmark.Statistic.Founds += (int) hashEntry.Found;

                    if (hashEntry.TimeStamp < CurrentBenchmark.TimeHistoStart)
                    {
                        CurrentBenchmark.TimeHistoStart = hashEntry.TimeStamp;
                    }
                    else if (hashEntry.TimeStamp > CurrentBenchmark.TimeHistoLast)
                    {
                        CurrentBenchmark.TimeHistoLast = hashEntry.TimeStamp;
                    }

                    Tuple<long, bool, bool> availabilityTimestamp = Info.AvailableTimeStamps.LastOrDefault();
                    if (availabilityTimestamp != null && hashEntry.TimeStamp < availabilityTimestamp.Item1 
                        && availabilityTimestamp.Item2 && availabilityTimestamp.Item3)
                    {
                        Info.AvailableTimeStamps[Info.AvailableTimeStamps.Count - 1] =
                            new Tuple<long, bool, bool>(hashEntry.TimeStamp, true, true);
                    }
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
            decimal sumOfWeightedRates = 0;
            decimal totalWeight = 0;
            decimal[] rates = new decimal[hashLogSize];
            decimal[] weights = new decimal[hashLogSize];
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

                decimal weightCounter = 0;
                Array.Sort(rates, weights);
                for (int i = 0; i < hashLogSize; i++)
                {
                    weights[i] = weights[i] / CurrentBenchmark.Statistic.TotalHashCount;
                    weightCounter += weights[i];
                    if (weightCounter >= 0.045500263896358M && roller.SpreadBottomHashRate == 0)
                    {
                        roller.SpreadBottomHashRate = rates[i];
                    }

                    if (weightCounter >= 0.954499736103642M && roller.SpreadTopHashRate == 0)
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
            decimal totalTemp = 0, totalPing = 0;

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
            // And so the counting begins
            List<Benchmark.HashEntry> hashList = CurrentBenchmark.HashLogs.ToList();
            int hashLogSize = hashList.Count;
            decimal sumOfWeightedRates = 0;
            decimal sumOfInverseWeightedRates = 0;
            double productOfWeightedLogRates = 0;
            ulong totalWeight = 0;
            decimal[] rates = new decimal[hashLogSize];
            uint[] weights = new uint[hashLogSize];
            
            for (int i = 0; i < hashLogSize; i++)
            {
                rates[i] = hashList[i].HashRate;
                weights[i] = hashList[i].HashCount;

                sumOfWeightedRates += (rates[i]*weights[i]);
                sumOfInverseWeightedRates += (weights[i]/rates[i]);
                productOfWeightedLogRates += (Math.Log((double)rates[i]) * weights[i]);
                totalWeight += hashList[i].HashCount;
            }

            // Let's avoid dividing by zero
            if (totalWeight != 0)
            {
                Tuple<List<decimal>, uint>[] groupedRates = new Tuple<List<decimal>, uint>[100];
                Dictionary<string, decimal> percentiles = new Dictionary<string, decimal>();
                decimal weightCounter = 0;
                double sumOfPow2OfDifferences = 0, sumOfPow3OfDifferences = 0, sumOfPow4OfDifferences = 0;

                Array.Sort(rates, weights); // Sorts the rates from low to high, weights get sorted along

                decimal lowestRate = rates[0];
                decimal highestRate = rates[rates.Length - 1];
                decimal interRange = highestRate - lowestRate;
                decimal step = interRange / 100;
                decimal offset = Math.Truncate(lowestRate/step);

                decimal arithmeticAverageHashRate = sumOfWeightedRates / totalWeight;
                decimal geometricAverageHashRate = (decimal)Math.Exp(productOfWeightedLogRates / (double)totalWeight);
                decimal harmonicAverageHashRate = totalWeight / sumOfInverseWeightedRates;

                for (int i = 0; i < hashLogSize; i++)
                {
                    double difference = (double) (rates[i] - arithmeticAverageHashRate);
                    sumOfPow2OfDifferences += (difference * difference * weights[i]);
                    sumOfPow3OfDifferences += (difference * difference * difference * weights[i]);
                    sumOfPow4OfDifferences += (difference * difference * difference * difference * weights[i]);
                    // Unsure if weights[i] needs to be inside difference, tests will show

                    weightCounter += (weights[i] / (decimal)totalWeight);

                    int group = (int) (Math.Truncate(rates[i]/step) - offset);
                    if (group >= 100) group = 99; // Sometimes, thx to rounding, it gets higher
                    if (groupedRates[group] == null)
                    {
                        List<decimal> ratesList = new List<decimal> {rates[i]};
                        groupedRates[group] = new Tuple<List<decimal>, uint>(ratesList, weights[i]);
                    }
                    else
                    {
                        List<decimal> ratesList = groupedRates[group].Item1;
                        ratesList.Add(rates[i]);
                        uint weight = groupedRates[group].Item2 + weights[i];
                        groupedRates[group] = new Tuple<List<decimal>, uint>(ratesList, weight);
                    }
                    
                    if (weightCounter >= 0.00269979606326M && !percentiles.ContainsKey("-3σ"))
                    {
                        percentiles.Add("-3σ", rates[i]);
                    }

                    if (weightCounter >= 0.012419330651552M && !percentiles.ContainsKey("-2.5σ"))
                    {
                        percentiles.Add("-2.5σ", rates[i]);
                    }

                    if (weightCounter >= 0.045500263896358M && !percentiles.ContainsKey("-2σ"))
                    {
                        percentiles.Add("-2σ", rates[i]);
                    }

                    if (weightCounter >= 0.133614402537716M && !percentiles.ContainsKey("-1.5σ"))
                    {
                        percentiles.Add("-1.5σ", rates[i]);
                    }

                    if (weightCounter >= 0.25M && !percentiles.ContainsKey("Q1"))
                    {
                        percentiles.Add("Q1", rates[i]);
                    }

                    if (weightCounter >= 0.317310507862914M && !percentiles.ContainsKey("-1σ"))
                    {
                        percentiles.Add("-1σ", rates[i]);
                    }

                    if (weightCounter >= 0.5M && !percentiles.ContainsKey("0σ"))
                    {
                        percentiles.Add("0σ", rates[i]);
                    }

                    if (weightCounter >= 0.682689492137086M && !percentiles.ContainsKey("+1σ"))
                    {
                        percentiles.Add("+1σ", rates[i]);
                    }

                    if (weightCounter >= 0.75M && !percentiles.ContainsKey("Q3"))
                    {
                        percentiles.Add("Q3", rates[i]);
                    }

                    if (weightCounter >= 0.866385597462284M && !percentiles.ContainsKey("+1.5σ"))
                    {
                        percentiles.Add("+1.5σ", rates[i]);
                    }

                    if (weightCounter >= 0.954499736103642M && !percentiles.ContainsKey("+2σ"))
                    {
                        percentiles.Add("+2σ", rates[i]);
                    }
                    
                    if (weightCounter >= 0.987580669348448M && !percentiles.ContainsKey("+2.5σ"))
                    {
                        percentiles.Add("+2.5σ", rates[i]);
                    }

                    if (weightCounter >= 0.997300203936740M && !percentiles.ContainsKey("+3σ"))
                    {
                        percentiles.Add("+3σ", rates[i]);
                    }
                }

                decimal skewness = (decimal) (sumOfPow3OfDifferences/(Math.Pow(sumOfPow2OfDifferences, 1.5)));
                decimal kurtosis =
                    (decimal) ((sumOfPow4OfDifferences/(sumOfPow2OfDifferences*sumOfPow2OfDifferences)) - 3);

                decimal[] madMedian = new decimal[hashLogSize];
                decimal[] madAverage = new decimal[hashLogSize];
                decimal sumOfWeightedMedian = 0, sumOfWeightedAverage = 0;
                // Come on, let's loop again! https://www.youtube.com/watch?v=BqvUkmnDVkM 
                for (int index = 0; index < hashLogSize; index++)
                {
                    madMedian[index] = Math.Abs((rates[index] - percentiles["0σ"]));
                    madAverage[index] = Math.Abs((rates[index] - arithmeticAverageHashRate));

                    sumOfWeightedMedian += (madMedian[index] * weights[index]);
                    sumOfWeightedAverage += (madAverage[index] * weights[index]);
                }

                decimal madMedianMedian = GetMedian(madMedian);
                decimal madAverageMedian = GetMedian(madAverage);
                decimal madMedianAverage = sumOfWeightedMedian/totalWeight;
                decimal madAverageAverage = sumOfWeightedAverage/totalWeight;
                decimal madMedianMax = madMedian[hashLogSize - 1];
                decimal madAverageMax = madAverage[hashLogSize - 1];
                decimal[][] absoluteDeviations = new decimal[2][];
                absoluteDeviations[0] = new[] {madMedianMedian, madMedianAverage, madMedianMax};
                absoluteDeviations[1] = new[] {madAverageMedian, madAverageAverage, madAverageMax};
                
                decimal variance = (decimal) (sumOfPow2OfDifferences/totalWeight);
                decimal standardDeviation = (decimal) Math.Sqrt((double)variance);
                decimal dispersionCoefficient = variance/percentiles["0σ"];
                decimal variationCoefficient = (standardDeviation / arithmeticAverageHashRate) * 100;
                decimal interquartileRange = percentiles["Q3"] - percentiles["Q1"];
                decimal interquartileSum = percentiles["Q3"] + percentiles["Q1"];
                decimal quartileCoefficient = interquartileRange / interquartileSum;
                decimal rootMeanSquare = (decimal)Math.Sqrt(
                    (double)((arithmeticAverageHashRate * arithmeticAverageHashRate) + (standardDeviation * standardDeviation)));

                CurrentBenchmark.Statistic.TotalHashCount = totalWeight;
                CurrentBenchmark.Statistic.Skewness = skewness;
                CurrentBenchmark.Statistic.Kurtosis = kurtosis;
                CurrentBenchmark.Statistic.ArithmeticAverageHashRate = arithmeticAverageHashRate;
                CurrentBenchmark.Statistic.GeometricAverageHashrate = geometricAverageHashRate;
                CurrentBenchmark.Statistic.HarmonicAverageHashRate = harmonicAverageHashRate;
                CurrentBenchmark.Statistic.RootMeanSquare = rootMeanSquare;
                CurrentBenchmark.Statistic.Variance = variance;
                CurrentBenchmark.Statistic.StandardDeviation = standardDeviation;
                CurrentBenchmark.Statistic.AbsoluteDeviations = absoluteDeviations;
                CurrentBenchmark.Statistic.MadStdFactor = standardDeviation/madMedianMedian;
                CurrentBenchmark.Statistic.DispersionCoefficient = dispersionCoefficient;
                CurrentBenchmark.Statistic.VariationCoefficient = variationCoefficient;
                CurrentBenchmark.Statistic.QuartileCoefficient = quartileCoefficient;
                CurrentBenchmark.Statistic.InterquartileRange = interquartileRange;
                CurrentBenchmark.Statistic.InterRange = interRange;
                CurrentBenchmark.Statistic.LowestHashRate = lowestRate;
                CurrentBenchmark.Statistic.HighestHashRate = highestRate;
                CurrentBenchmark.Statistic.Percentiles = percentiles;
                CurrentBenchmark.Statistic.GroupedRates = groupedRates;
            }
        }

        private static decimal GetMedian(decimal[] array)
        {
            int length = array.Length;
            if (length == 0) return new decimal();
            if (length == 1) return array[0];
            if (length == 2) return (array[0] + array[1])/2M;

            Array.Sort(array);
            int half = length/2;
            if (length%2 == 0)
            {
                decimal a = array[half - 1];
                decimal b = array[half];
                return (a + b)/2M;
            }

            return array[half];
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

        public void ChangeAvailability(bool available, bool monitorClosing = false)
        {
            long unixTimeStamp = UnixTimeStamp();
            if (Info.AvailableTimeStamps == null)
            {
                Info.AvailableTimeStamps = new List<Tuple<long, bool, bool>>
                        {
                            new Tuple<long, bool, bool>(unixTimeStamp, available, monitorClosing )
                        };
            }
            else
            {
                Tuple<long, bool, bool> prevAvailableTimeStamp =
                    Info.AvailableTimeStamps[Info.AvailableTimeStamps.Count - 1];
                if (prevAvailableTimeStamp.Item1 != unixTimeStamp && prevAvailableTimeStamp.Item2 != available)
                {
                    if (available)
                    {
                        Info.AvailableTimeStamps.Add(new Tuple<long, bool, bool>(unixTimeStamp, true,
                                                     Info.AvailableTimeStamps.Last().Item3));
                    }
                    else
                    {
                        Info.AvailableTimeStamps.Add(new Tuple<long, bool, bool>(unixTimeStamp, false, monitorClosing));
                    }
                }
            }

            Info.Available = available;
        }
        
        private static long UnixTimeStamp()
        {
            return (long) (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }
    }
}
