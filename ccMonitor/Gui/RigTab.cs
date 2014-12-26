using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ccMonitor.Api;
using Newtonsoft.Json;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

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

        private bool _hadRequestResult;

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
                    GpuTab gpuGpuTab = new GpuTab(gpu) { Dock = DockStyle.Fill };
                    gpuGpuTab.UpdateGui();
                    tabPage.Controls.Add(gpuGpuTab);
                    tbcRig.TabPages.Add(tabPage);
                }
            }


        }

        private void txtDebugConsole_KeyDown(object sender, KeyEventArgs e)
        {
            if (_hadRequestResult)
            {
                txtDebugConsole.Clear();
                txtDebugConsole.AppendText(Environment.NewLine + ">  ");
                _hadRequestResult = false;
            }

            if (e.KeyCode == Keys.Enter)
            {
                string[] splitStrings = txtDebugConsole.Text.Split('>');

                Dictionary<string, string>[] request = PruvotApi.Request(Rig.IpAddress, Rig.Port, splitStrings[splitStrings.Length -1].Trim());
                if (request != null)
                {
                    txtDebugConsole.AppendText(Environment.NewLine + ">  " + Environment.NewLine + 
                                                JsonConvert.SerializeObject(request, Formatting.Indented));
                }

                _hadRequestResult = true;
            }
        }
    }
}
