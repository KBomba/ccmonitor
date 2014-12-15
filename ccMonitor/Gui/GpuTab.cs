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
    public partial class GpuTab : UserControl
    {
        public GpuLogger Gpu { get; set; }

        public GpuTab(GpuLogger gpu)
        {
            Gpu = gpu;
            InitializeComponent();
        }

        public void UpdateGui()
        {
            
        }
    }
}
