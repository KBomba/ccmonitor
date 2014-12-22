using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccMonitor.Gui
{
    public partial class GpuDetails : UserControl
    {
        public GpuLogger.Benchmark Benchmark { get; set; }

        public GpuDetails(GpuLogger.GpuInfo gpuInfo)
        {
            InitializeComponent();

            splitHashesAndSensors.Panel1.Controls.Add(new HashLogView {Dock = DockStyle.Fill});
            splitHashesAndSensors.Panel2.Controls.Add(new SensorLogView { Dock = DockStyle.Fill});
        }

        public void UpdateStats(GpuLogger.Benchmark currentBenchmark)
        {
            Benchmark = currentBenchmark;

            foreach (object control in splitHashesAndSensors.Panel1.Controls)
            {
                HashLogView hashLogView = control as HashLogView;
                if (hashLogView != null) hashLogView.UpdateLogs(Benchmark.HashLogs);
            }

            foreach (object control in splitHashesAndSensors.Panel2.Controls)
            {
                SensorLogView sensorLogView = control as SensorLogView;
                if (sensorLogView != null) sensorLogView.UpdateLogs(Benchmark.SensorLog);
            }
        }
    }
}
