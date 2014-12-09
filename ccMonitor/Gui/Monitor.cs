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
            _computer.Open();
            _computer.GPUEnabled = true;
        }
    }
}
