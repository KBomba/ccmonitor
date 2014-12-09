using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ccMonitor
{
    public partial class Monitor : Form
    {
        private RigController _controller;

        private System.Threading.Timer _updateTimer; // Different thread
        private System.Windows.Forms.Timer _guiTimer; // Same thread

        public Monitor()
        {
            InitializeComponent();

            _controller = new RigController();
        }


        private void tabRawLogs_Click(object sender, EventArgs e)
        {
            txtRawLogs.Text = JsonConvert.SerializeObject(_controller, Formatting.Indented);
        }
    }
}
