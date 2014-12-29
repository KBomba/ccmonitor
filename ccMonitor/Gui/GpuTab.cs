using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ccMonitor.Gui
{
    public partial class GpuTab : UserControl
    {
        public GpuLogger Gpu { get; set; }

        private bool _pauseUpdate;

        public List<UserFriendlyBenchmark> UserFriendlyBenchmarks { get; set; }
        public class UserFriendlyBenchmark
        {
            // All strings, because that's user friendly :D
            public string TimeStarted { get; set; }
            public string TimeLastUpdate { get; set; }
            public string Algorithm { get; set; }
            public string AverageHashRate { get; set; }
            public string StandardDeviation { get; set; }
            public string HashCount { get; set; }
            public string AverageTemperature { get; set; }
            public string MinerNameVersion { get; set; }
            public string Stratum { get; set; }
        }
        
        public GpuTab(GpuLogger gpu)
        {
            Gpu = gpu;
            InitializeComponent();
            InitGpuDetails();
            InitCharts();

            rightClickStrip.Items["copySelectedItem"].Image = GuiHelper.GetImageFromBase64DataUri(GuiHelper.CopySingleImage);
            rightClickStrip.Items["copyAllItem"].Image = GuiHelper.GetImageFromBase64DataUri(GuiHelper.CopyAllImage);
            rightClickStrip.Items["startNewItem"].Image = GuiHelper.GetImageFromBase64DataUri(GuiHelper.ReloadButtonImage);
        }

        private void InitCharts()
        {
            HashChart hashChart = new HashChart(1) {Dock = DockStyle.Fill};
            tabHashCharts.Controls.Add(hashChart);

            SensorChart sensorChart = new SensorChart(1) {Dock = DockStyle.Fill};
            tabSensorCharts.Controls.Add(sensorChart);
        }

        private void InitGpuDetails()
        {
            BenchmarkDetails gpuDetails = new BenchmarkDetails(Gpu.Info, 6){Dock = DockStyle.Fill};
            tabGpuDetails.Controls.Add(gpuDetails);
        }

        public void UpdateGui()
        {
            if (!_pauseUpdate)
            {
                if (Gpu.CurrentBenchmark != null && Gpu.BenchLogs != null && Gpu.BenchLogs.Count > 0)
                {
                    UpdateInternalControls();

                    UserFriendlyBenchmarks = new List<UserFriendlyBenchmark>(Gpu.BenchLogs.Count);
                    foreach (GpuLogger.Benchmark benchmark in Gpu.BenchLogs)
                    {
                        string timeStarted = GuiHelper.UnixTimeStampToDateTime(benchmark.TimeStamp).ToString("g");
                        string timeLastUpdate = benchmark.SensorLog.Count > 2
                            ? GuiHelper.UnixTimeStampToDateTime(benchmark.SensorLog[benchmark.SensorLog.Count - 1].TimeStamp).ToString("g")
                            : timeStarted;
                        UserFriendlyBenchmark userFriendlyBenchmark = new UserFriendlyBenchmark
                        {
                            TimeStarted = timeStarted,
                            TimeLastUpdate = timeLastUpdate,
                            Algorithm = benchmark.Algorithm,
                            AverageHashRate = GuiHelper.GetRightMagnitude(benchmark.Statistic.AverageHashRate, "H"),
                            StandardDeviation = GuiHelper.GetRightMagnitude(benchmark.Statistic.StandardDeviation, "H"),
                            HashCount = GuiHelper.GetRightMagnitude(benchmark.Statistic.TotalHashCount),
                            AverageTemperature = benchmark.Statistic.AverageTemperature.ToString("##.##") + " °C",
                            MinerNameVersion = benchmark.MinerSetup.ToString(),
                            Stratum = benchmark.MinerSetup.MiningUrl
                        };

                        UserFriendlyBenchmarks.Insert(0, userFriendlyBenchmark);
                    }

                    int rowIndex = dgvBenchmarks.SelectedRows.Count > 0 ? dgvBenchmarks.SelectedRows[0].Index : 0;
                    dgvBenchmarks.DataSource = new SortableBindingList<UserFriendlyBenchmark>(UserFriendlyBenchmarks);
                    if (dgvBenchmarks.Rows.Count > 0) dgvBenchmarks.CurrentCell = dgvBenchmarks.Rows[rowIndex].Cells[0];
                }
            }
            
        }

        private void UpdateInternalControls()
        {
            foreach (object control in tabGpuDetails.Controls)
            {
                BenchmarkDetails gpuDetails = control as BenchmarkDetails;
                if (gpuDetails != null) gpuDetails.UpdateStats(Gpu.CurrentBenchmark);
            }

            foreach (object control in tabHashCharts.Controls)
            {
                HashChart hashChart = control as HashChart;
                if (hashChart != null)
                {
                    hashChart.UpdateCharts(Gpu.CurrentBenchmark.HashLogs, Gpu.Info.AvailableTimeStamps);
                }
            }

            foreach (object control in tabSensorCharts.Controls)
            {
                SensorChart sensorChartChart = control as SensorChart;
                if (sensorChartChart != null)
                {
                    sensorChartChart.UpdateCharts(Gpu.CurrentBenchmark.SensorLog, 
                        Gpu.Info.AvailableTimeStamps, Gpu.CurrentBenchmark.MinerSetup.OperatingSystem);
                }
            }
        }

        private void dgvBenchmarks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex<0) return;

            Thread thread = new Thread(ShowBenchmarkOverview);
            thread.Start(rowIndex);
        }

        private void ShowBenchmarkOverview(object obj)
        {
            int rowIndex = obj is int ? (int) obj : 0;
            using (BenchmarkOverview benchmarkOverview = new BenchmarkOverview(Gpu.BenchLogs[Gpu.BenchLogs.Count - rowIndex - 1], Gpu.Info))
            {
                benchmarkOverview.Text = Gpu.Info + " - Benchmark overview";
                benchmarkOverview.Size = new Size(this.Size.Width, this.Size.Height);
                benchmarkOverview.ShowDialog();
            }
            
        }

        private void dgvBenchmarks_MouseDown(object sender, MouseEventArgs e)
        {
            _pauseUpdate = e.Button == MouseButtons.Right;
        }

        private void copySelectedItem_Click(object sender, System.EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var row in dgvBenchmarks.SelectedRows)
            {
                DataGridViewRow selectedRow = row as DataGridViewRow;
                if (selectedRow != null)
                {
                    sb.AppendLine(JsonConvert.SerializeObject(UserFriendlyBenchmarks [selectedRow.Index], Formatting.Indented));
                }
            }

            Clipboard.SetText(sb.ToString());
            _pauseUpdate = false;
        }

        private void copyAllItem_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(JsonConvert.SerializeObject(UserFriendlyBenchmarks, Formatting.Indented));
            _pauseUpdate = false;
        }

        private void startNewItem_Click(object sender, System.EventArgs e)
        {
            Gpu.RestartCurrentBenchmark();
            _pauseUpdate = false;
            UpdateGui();
        }
    }
}
