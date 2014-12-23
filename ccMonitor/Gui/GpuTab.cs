using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ccMonitor.Gui
{
    public partial class GpuTab : UserControl
    {
        public GpuLogger Gpu { get; set; }

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
        }

        private void InitGpuDetails()
        {
            BenchmarkDetails gpuDetails = new BenchmarkDetails(Gpu.Info, 6){Dock = DockStyle.Fill};
            tabGpuDetails.Controls.Add(gpuDetails);
        }

        public void UpdateGui()
        {
            foreach (object control in tabGpuDetails.Controls)
            {
                BenchmarkDetails gpuDetails = control as BenchmarkDetails;
                if (gpuDetails != null) gpuDetails.UpdateStats(Gpu.CurrentBenchmark);
            }

            UserFriendlyBenchmarks = new List<UserFriendlyBenchmark>(Gpu.BenchLogs.Count);
            foreach (GpuLogger.Benchmark benchmark in Gpu.BenchLogs)
            {
                UserFriendlyBenchmark userFriendlyBenchmark = new UserFriendlyBenchmark
                {
                    TimeStarted = GuiHelper.UnixTimeStampToDateTime(benchmark.TimeStamp).ToString("g"),
                    TimeLastUpdate = GuiHelper.UnixTimeStampToDateTime(benchmark.SensorLog
                                        [benchmark.SensorLog.Count - 1].TimeStamp).ToString("g"),
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
            dgvBenchmarks.DataSource = UserFriendlyBenchmarks;
            if(dgvBenchmarks.Rows.Count > 0) dgvBenchmarks.CurrentCell = dgvBenchmarks.Rows[rowIndex].Cells[0];
        }

        private void dgvBenchmarks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex<0) return;

            // Over 9000 means max value
            BenchmarkDetails benchmarkDetails = new BenchmarkDetails(Gpu.Info, 9001) { Dock = DockStyle.Fill };
            benchmarkDetails.UpdateStats(Gpu.BenchLogs[Gpu.BenchLogs.Count - rowIndex - 1]);
            Form form = new Form
            {
                Text = Gpu.Info + " - Detailed benchmark overview",
                Size = new Size(this.Size.Width, this.Size.Height)
            };
            form.Controls.Add(benchmarkDetails);
            form.Show();
        }
    }

    
}
