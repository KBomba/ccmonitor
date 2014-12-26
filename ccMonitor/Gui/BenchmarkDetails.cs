using System;
using System.Globalization;
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
            UpdateSpread(benchmark.Statistic);
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

            if (!txtAccepts.Focused) txtAccepts.Text = benchmark.Statistic.Accepts.ToString(CultureInfo.InvariantCulture);
            if (!txtHashCount.Focused) txtHashCount.Text = GuiHelper.GetRightMagnitude(benchmark.Statistic.TotalHashCount);
            if (!txtAverageTemperature.Focused) txtAverageTemperature.Text = 
                                            String.Format("{0:0.##}{1}", benchmark.Statistic.AverageTemperature, "°C");
            if (!txtAveragePing.Focused) txtAveragePing.Text = 
                                            String.Format("{0:0.##} {1}", benchmark.Statistic.AverageShareAnswerPing, "ms");

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

        private void UpdateSpread(GpuLogger.Benchmark.Stat statistic)
        {
            dgvSpread.Rows.Clear();
            dgvSpread.Rows.Add("Average hashrate", GuiHelper.GetRightMagnitude(statistic.AverageHashRate, "H"));
            dgvSpread.Rows.Add("Standard deviation", GuiHelper.GetRightMagnitude(statistic.StandardDeviation, "H"));
            dgvSpread.Rows.Add("Highest hashrate", GuiHelper.GetRightMagnitude(statistic.HighestHashRate, "H"));
            if (statistic.GaussianPercentiles != null)
            {
                dgvSpread.Rows.Add("Real 2σ", GuiHelper.GetRightMagnitude(statistic.GaussianPercentiles[5], "H"));
                dgvSpread.Rows.Add("Real 1.5σ", GuiHelper.GetRightMagnitude(statistic.GaussianPercentiles[4], "H"));
                dgvSpread.Rows.Add("Real 1σ", GuiHelper.GetRightMagnitude(statistic.GaussianPercentiles[3], "H"));
                dgvSpread.Rows.Add("Real 0σ (mean)", GuiHelper.GetRightMagnitude(statistic.MeanHashRate, "H"));
                dgvSpread.Rows.Add("Real -1σ", GuiHelper.GetRightMagnitude(statistic.GaussianPercentiles[2], "H"));
                dgvSpread.Rows.Add("Real -1.5σ", GuiHelper.GetRightMagnitude(statistic.GaussianPercentiles[1], "H"));
                dgvSpread.Rows.Add("Real -2σ", GuiHelper.GetRightMagnitude(statistic.GaussianPercentiles[0], "H"));
            }
            dgvSpread.Rows.Add("Lowest hashrate", GuiHelper.GetRightMagnitude(statistic.LowestHashRate, "H"));

            chartSpread.Series["BoxPlotSeries"].Points.Clear();
            chartSpread.Series["BoxPlotSeries"].Points.Add(GetBoxPlotValues(statistic));
        }

        private double[] GetBoxPlotValues(GpuLogger.Benchmark.Stat statistic)
        {
            if (statistic.GaussianPercentiles != null)
            {
                return new[]
                {
                    statistic.GaussianPercentiles[0],
                    statistic.GaussianPercentiles[5],
                    statistic.GaussianPercentiles[2],
                    statistic.GaussianPercentiles[3],
                    statistic.MeanHashRate,
                    statistic.AverageHashRate
                };
            }

            return new double[6];
        }
    }
}
