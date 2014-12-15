using System;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Forms;
using ccMonitor.Api;

namespace ccMonitor.Gui
{
    public partial class RigTab : UserControl
    {
        public RigController.RigInfo Rig { get; set; }
        public RigTab(RigController.RigInfo rig)
        {
            Rig = rig;
            InitializeComponent();
        }

        public void UpdateGui()
        {
            // Update all the textboxes and labels and charts here


            // Now add & update all gpus, no removal
            foreach (GpuLogger gpu in Rig.GpuLogs)
            {
                bool found = false;
                foreach (TabPage tabPage in tbcRig.TabPages)
                {
                    if (tabPage.Text != "Rig Overview" && tabPage.Text != "Debug Console"
                        && tabPage.Text == gpu.Info.ToString())
                    {
                        found = true;
                        foreach (GpuTab gpuTab in tabPage.Controls)
                        {
                            gpuTab.UpdateGui();
                        }
                        break;
                    }
                }

                if (!found)
                {
                    TabPage tabPage = new TabPage(gpu.Info.ToString());
                    GpuTab gpuTab = new GpuTab(gpu) { Dock = DockStyle.Fill };
                    gpuTab.UpdateGui();
                    tabPage.Controls.Add(gpuTab);
                    tbcRig.TabPages.Add(tabPage);
                }
            }


            
        }
    }
}
