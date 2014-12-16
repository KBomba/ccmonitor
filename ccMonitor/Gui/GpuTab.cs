using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            public string LowestHashRate { get; set; }
            public string HighestHashrate { get; set; }
            public string HashCount { get; set; }
            public string AverageTemperature { get; set; }
            public string MinerNameVersion { get; set; }
        }


        public GpuTab(GpuLogger gpu)
        {
            Gpu = gpu;

            InitializeComponent();

            dgvBenchmarks.DataSource = UserFriendlyBenchmarks;
        }

        public void UpdateGui()
        {
            UserFriendlyBenchmarks = new List<UserFriendlyBenchmark>(Gpu.BenchLogs.Count);
            foreach (GpuLogger.Benchmark benchmark in Gpu.BenchLogs)
            {
                UserFriendlyBenchmark userFriendlyBenchmark = new UserFriendlyBenchmark
                {
                    TimeStarted = GuiHelper.UnixTimeStampToDateTime(benchmark.TimeStamp).ToString("g"),
                    TimeLastUpdate = 
                        GuiHelper.UnixTimeStampToDateTime(benchmark.SensorLog[benchmark.SensorLog.Count - 1]
                            .TimeStamp).ToString("g"),
                    Algorithm = benchmark.Algorithm,
                    AverageHashRate = GuiHelper.GetRightMagnitude(benchmark.Statistic.AverageHashRate, 'H'),
                    StandardDeviation = GuiHelper.GetRightMagnitude(benchmark.Statistic.AverageHashRate, 'H'),
                    LowestHashRate = GuiHelper.GetRightMagnitude(benchmark.Statistic.LowestHashRate, 'H'),
                    HighestHashrate = GuiHelper.GetRightMagnitude(benchmark.Statistic.HighestHashRate, 'H'),
                    HashCount = GuiHelper.GetRightMagnitude(benchmark.Statistic.TotalHashCount),
                    AverageTemperature = benchmark.Statistic.AverageTemperature.ToString("##.##") + " °C",
                    MinerNameVersion = benchmark.MinerSetup.MinerName + " " + benchmark.MinerSetup.MinerVersion,
                };

                UserFriendlyBenchmarks.Insert(0, userFriendlyBenchmark);
            }

            int rowIndex = dgvBenchmarks.SelectedRows.Count > 0 ? dgvBenchmarks.SelectedRows[0].Index : 0;
            dgvBenchmarks.DataSource = UserFriendlyBenchmarks;
            if(dgvBenchmarks.Rows.Count > 0) dgvBenchmarks.CurrentCell = dgvBenchmarks.Rows[rowIndex].Cells[0];
        }
    }

    
}
