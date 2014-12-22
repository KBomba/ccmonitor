using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccMonitor.Gui
{
    public partial class BenchmarkOverview : Form
    {
        public GpuLogger.Benchmark Benchmark { get; set; }
        public BenchmarkOverview(GpuLogger.Benchmark benchmark)
        {
            Benchmark = benchmark;

            InitializeComponent();
            InitDataGridViews();
        }

        private void InitDataGridViews()
        {
            dgvHashLogs.AutoGenerateColumns = false;
            dgvHashLogs.DataSource = Benchmark.HashLogs.ToList();

            dgvSensorLogs.AutoGenerateColumns = false;
            dgvSensorLogs.DataSource = Benchmark.SensorLog;
        }
    }
}
