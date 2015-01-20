using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ccMonitor.Gui
{
    public partial class BenchmarkDetails : UserControl
    {
        private GpuLogger.GpuInfo GpuInfo { get; set; }

        private readonly int _rowsInLogViews;

        public BenchmarkDetails(GpuLogger.GpuInfo gpuInfo ,int rowsInLogViews = 5)
        {
            
            GpuInfo = gpuInfo;
            _rowsInLogViews = rowsInLogViews;
            InitializeComponent();
            InitHashesAndSensors();
            
        }

        private void InitHashesAndSensors()
        {
            splitHashesAndSensors.Panel1.Controls.Add(new HashLogView(_rowsInLogViews) {Dock = DockStyle.Fill});
            splitHashesAndSensors.Panel2.Controls.Add(new SensorLogView(_rowsInLogViews) {Dock = DockStyle.Fill});
        }

        public void UpdateStats(GpuLogger.Benchmark benchmark)
        {
            if (benchmark == null) return;
            UpdateSpread(benchmark);
            UpdateLogs(benchmark);
            UpdateTextBoxes(benchmark);
        }

        private void UpdateTextBoxes(GpuLogger.Benchmark benchmark)
        {
            if (!txtGpuName.Focused) txtGpuName.Text = GpuInfo.Name;
            if (!txtMinerId.Focused) txtMinerId.Text = GpuInfo.MinerMap.ToString(CultureInfo.InvariantCulture);
            if (!txtBusId.Focused) txtBusId.Text = GpuInfo.Bus.ToString(CultureInfo.InvariantCulture);
            if (!txtNvapiId.Focused) txtNvapiId.Text = GpuInfo.NvapiId.ToString(CultureInfo.InvariantCulture);
            if (!txtNvmlId.Focused) txtNvmlId.Text = GpuInfo.NvmlId.ToString(CultureInfo.InvariantCulture);
            if (!txtComputeCapability.Focused) txtComputeCapability.Text = 
                                            GpuInfo.ComputeCapability.ToString(CultureInfo.InvariantCulture);

            if (benchmark.CurrentStatistic != null)
            {
                if (!txtFounds.Focused) txtFounds.Text = benchmark.CurrentStatistic.Founds.ToString(CultureInfo.InvariantCulture);
                if (!txtHashCount.Focused) txtHashCount.Text = GuiHelper.GetRightMagnitude(benchmark.CurrentStatistic.TotalHashCount);
                if (!txtAverageTemperature.Focused)
                    txtAverageTemperature.Text = String.Format("{0:0.##}{1}", benchmark.CurrentStatistic.AverageTemperature, "°C");
                if (!txtAveragePing.Focused)
                    txtAveragePing.Text = String.Format("{0:0.##} {1}", benchmark.CurrentStatistic.AverageShareAnswerPing, "ms");
            }

            if (!txtAlgorithm.Focused) txtAlgorithm.Text = benchmark.Algorithm;
            if (!txtMinerName.Focused) txtMinerName.Text = benchmark.MinerSetup.ToString();
            if (!txtUrl.Focused) txtUrl.Text = benchmark.MinerSetup.MiningUrl;
            if (!txtIntensity.Focused) txtIntensity.Text = String.Format("{0:0.####}", benchmark.MinerSetup.Intensity);
            if (!txtPerformanceState.Focused) txtPerformanceState.Text = benchmark.MinerSetup.PerformanceState;
            if (!txtBiosVersion.Focused) txtBiosVersion.Text = benchmark.MinerSetup.BiosVersion;
            if (!txtDriverVersion.Focused) txtDriverVersion.Text = benchmark.MinerSetup.DriverVersion;
            if (!txtOperatingSystem.Focused) txtOperatingSystem.Text = benchmark.MinerSetup.OperatingSystem;
        }

        private void UpdateLogs(GpuLogger.Benchmark benchmark)
        {
            foreach (object control in splitHashesAndSensors.Panel1.Controls)
            {
                HashLogView hashLogView = control as HashLogView;
                if (hashLogView != null) hashLogView.UpdateLogs(benchmark.HashLogs);
            }

            foreach (object control in splitHashesAndSensors.Panel2.Controls)
            {
                SensorLogView sensorLogView = control as SensorLogView;
                if (sensorLogView != null) sensorLogView.UpdateLogs(benchmark.SensorLog);
            }
        }

        private void UpdateSpread(GpuLogger.Benchmark benchmark)
        {
            if (benchmark.CurrentStatistic == null) return;
            GpuLogger.Benchmark.GpuStat statistic = benchmark.CurrentStatistic;
            GpuLogger.Benchmark.OrderedHashLog orderedHashLog = benchmark.OrderedHashLogs ?? new GpuLogger.Benchmark.OrderedHashLog();

            dgvSpread.Rows.Clear();
            dgvSpread.Rows.Add("Average hashrate", GuiHelper.GetRightMagnitude(statistic.HarmonicAverageHashRate, "H"));
            dgvSpread.Rows.Add("Standard deviation", GuiHelper.GetRightMagnitude(statistic.StandardDeviation, "H"));
            if (statistic.AbsoluteDeviations != null)
                dgvSpread.Rows.Add("MAD", GuiHelper.GetRightMagnitude(statistic.AbsoluteDeviations[0][0], "H"));
            dgvSpread.Rows.Add("Interquartile range", GuiHelper.GetRightMagnitude(statistic.InterquartileRange, "H"));
            dgvSpread.Rows.Add("Highest hashrate", GuiHelper.GetRightMagnitude(statistic.HighestHashRate, "H"));
            if (statistic.Percentiles != null)
            {
                dgvSpread.Rows.Add("Real +2σ", GuiHelper.GetRightMagnitude(statistic.Percentiles["+2σ"], "H"));
                dgvSpread.Rows.Add("Real +1σ", GuiHelper.GetRightMagnitude(statistic.Percentiles["+1σ"], "H"));
                dgvSpread.Rows.Add("Real 0σ (median)", GuiHelper.GetRightMagnitude(statistic.Percentiles["0σ"], "H"));
                dgvSpread.Rows.Add("Real -1σ", GuiHelper.GetRightMagnitude(statistic.Percentiles["-1σ"], "H"));
                dgvSpread.Rows.Add("Real -2σ", GuiHelper.GetRightMagnitude(statistic.Percentiles["-2σ"], "H"));
                
                chartSpread.Series["BoxPlotSeries"].Points.Clear();
                chartSpread.Series["BoxPlotSeries"].Points.Add(GetBoxPlotValues(statistic, orderedHashLog));
            }
            dgvSpread.Rows.Add("Lowest hashrate", GuiHelper.GetRightMagnitude(statistic.LowestHashRate, "H"));
        }

        private double[] GetBoxPlotValues(GpuLogger.Benchmark.GpuStat statistic, GpuLogger.Benchmark.OrderedHashLog orderedHashLog)
        {
            if (statistic.Percentiles != null)
            {
                List<double> boxPlotValues = new List<double>
                {
                    (double)(statistic.OuterWhiskers[0]),
                    (double)(statistic.OuterWhiskers[1]),
                    (double)(statistic.Percentiles["Q1"]),
                    (double)(statistic.Percentiles["Q3"]),
                    (double)(statistic.Percentiles["0σ"]),
                    (double)(statistic.HarmonicAverageHashRate)
                };

                foreach (decimal outlier in orderedHashLog.Outliers)
                {
                    boxPlotValues.Add((double) outlier);
                }

                return boxPlotValues.ToArray();
            }

            return new double[6];
        }
    }
}
