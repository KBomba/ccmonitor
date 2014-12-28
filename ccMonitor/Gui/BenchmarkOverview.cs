using System.Windows.Forms;

namespace ccMonitor.Gui
{
    public partial class BenchmarkOverview : Form
    {
        public BenchmarkOverview(GpuLogger.Benchmark benchmark, GpuLogger.GpuInfo gpuInfo)
        {
            InitializeComponent();

            // Over 9000 means max value
            BenchmarkDetails benchmarkDetails = new BenchmarkDetails(gpuInfo, 9001) { Dock = DockStyle.Fill };
            benchmarkDetails.UpdateStats(benchmark);
            tabDetails.Controls.Add(benchmarkDetails);

            HashChart hashChart = new HashChart(9001) {Dock = DockStyle.Fill};
            hashChart.UpdateCharts(benchmark.HashLogs);
            tabHashCharts.Controls.Add(hashChart);

            SensorChart sensorChart = new SensorChart(9001) {Dock = DockStyle.Fill};
            sensorChart.UpdateCharts(benchmark.SensorLog, gpuInfo.AvailableTimeStamps, benchmark.MinerSetup.OperatingSystem);
            tabSensorCharts.Controls.Add(sensorChart);

        }
    }
}
