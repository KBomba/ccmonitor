using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ccMonitor.Api.OpenHardwareMonitor.Hardware;
using Newtonsoft.Json;

namespace ccMonitor
{
    public partial class Monitor : Form
    {
        private RigController _controller;
        private Computer _computer;

        private System.Threading.Timer _updateTimer; // Different thread
        private System.Windows.Forms.Timer _guiTimer; // Same thread

        public Monitor()
        {
            InitializeComponent();

            InitOpenHardwareMonitor();
        }

        private void InitOpenHardwareMonitor()
        {
            _computer = new Computer();
            _computer.GPUEnabled = true;
            _computer.Close();
            _computer.Open();
            
        }

        private void tabRawLogs_Click(object sender, EventArgs e)
        {
            txtRawLogs.Text = JsonConvert.SerializeObject(_controller, Formatting.Indented);
        }
    }
}
