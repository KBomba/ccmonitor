using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ccMonitor.Api;
using ccMonitor.Gui;
using Newtonsoft.Json;

namespace ccMonitor
{
    public partial class Monitor : Form
    {
        private RigController _controller;

        private System.Threading.Timer _updateTimer; // Different thread
        private System.Windows.Forms.Timer _guiTimer; // Same thread

        private bool _rawLogsGotFocus; // used for auto-selecting txtRawLogs

        public Monitor()
        {
            InitializeComponent();

            LoadSettings();
            LoadLogs();
            LoadReadMe();

            InitTimers();
            InitGui();
        }

        private void LoadReadMe()
        {
            if (File.Exists("README.txt"))
            {
                using (TextReader tr = File.OpenText("README.txt"))
                {
                    txtReadMe.Text = tr.ReadToEnd();
                }
            }
        }

        private void InitGui()
        {
            dgvRigs.AutoGenerateColumns = false;
            dgvRigs.DataSource = _controller.RigLogs;

            tabRawLogs.Enter += tabRawLogs_Enter;
            txtRawLogs.GotFocus += txtRawLogs_GotFocus;
            txtRawLogs.MouseUp += txtRawLogs_MouseUp;
            txtRawLogs.Leave += txtRawLogs_Leave;
        }

        private void InitTimers()
        {
            _updateTimer = new System.Threading.Timer(UpdateController, null, 0, Timeout.Infinite);

            _guiTimer = new System.Windows.Forms.Timer {Interval = 5000};
            _guiTimer.Tick += GuiTimerTick;
            _guiTimer.Start();
            UpdateGui();
        }

        private void GuiTimerTick(object sender, EventArgs e)
        {
            UpdateGui();
            RemoveDeletedRigs();
        }

        private void RemoveDeletedRigs()
        {
            // Really complicated way to dynamically remove deleted rigs
            // Need to find a better way
            Dictionary<string, bool> rigExistence = new Dictionary<string, bool>();
            foreach (TabPage tabPage in tbcRigStats.TabPages)
            {
                rigExistence.Add(tabPage.Text, false);
            }

            foreach (RigController.RigInfo rig in _controller.RigLogs)
            {
                if (rigExistence.ContainsKey(rig.UserFriendlyName))
                {
                    rigExistence[rig.UserFriendlyName] = true;
                }
            }

            foreach (TabPage tabPage in tbcRigStats.TabPages)
            {
                if (rigExistence[tabPage.Text] == false)
                {
                    tbcRigStats.TabPages.Remove(tabPage);
                }
            }
        }

        private void UpdateGui()
        {
            // Grabs all the selected items in the General Overview List
            int[] selectedIndexes = new int[lstGeneralOverview.SelectedIndices.Count];
            if (selectedIndexes.Length > 0)
            {
                for (int i = 0; i < selectedIndexes.Length; i++)
                {
                    selectedIndexes[i] = lstGeneralOverview.SelectedIndices[i];
                }
            }

            // Completely refresh the General Overview List
            lstGeneralOverview.Items.Clear();
            lstGeneralOverview.Groups.Clear();
            
            foreach (RigController.RigInfo rig in _controller.RigLogs)
            {
                // Makes sure all rigs that are in the logs are shown in RigStats
                // And updates them
                bool tabPageExists = false;
                foreach (TabPage tabPage in tbcRigStats.TabPages)
                {
                    if (tabPage.Text == rig.UserFriendlyName)
                    {
                        tabPageExists = true;
                    }

                    foreach (RigTab rigTab in tabPage.Controls)
                    {
                        rigTab.UpdateGui();
                    }
                }                

                if (!tabPageExists)
                {
                    // Makes new tabpage in rigstats
                    TabPage tabPage = new TabPage(rig.UserFriendlyName);
                    RigTab rigTab = new RigTab(rig) {Dock = DockStyle.Fill};
                    rigTab.UpdateGui();
                    tabPage.Controls.Add(rigTab);
                    tbcRigStats.TabPages.Add(tabPage);
                }
                
                // Adds the controller info to the listview
                ListViewGroup lvg = new ListViewGroup(rig.UserFriendlyName);
                lstGeneralOverview.Groups.Add(lvg);

                ListViewItem lvi;
                foreach (GpuLogger gpu in rig.GpuLogs)
                {
                    lvi = new ListViewItem(gpu.Info.MinerMap.ToString(CultureInfo.InvariantCulture), lvg);
                    lvi.SubItems.Add(gpu.Info.Bus.ToString(CultureInfo.InvariantCulture));
                    lvi.SubItems.Add(gpu.Info.Name);
                    lvi.SubItems.Add(string.Empty);
                    lvi.SubItems.Add(GetRightMagnitude(gpu.CurrentBenchmark.Statistic.AverageHashRate) + "H");
                    lvi.SubItems.Add(GetRightMagnitude(gpu.CurrentBenchmark.Statistic.StandardDeviation) + "H");
                    lvi.SubItems.Add(GetRightMagnitude(gpu.CurrentBenchmark.Statistic.TotalHashCount));
                    lvi.SubItems.Add(gpu.CurrentBenchmark.Statistic.Accepts + "");
                    lvi.SubItems.Add(string.Empty);
                    lvi.SubItems.Add(gpu.CurrentBenchmark.SensorLog[gpu.CurrentBenchmark.SensorLog.Count -1]
                        .Temperature.ToString(CultureInfo.InvariantCulture));
                    lvi.SubItems.Add(string.Empty);
                    lstGeneralOverview.Items.Add(lvi);
                }

                lvi = new ListViewItem(string.Empty, lvg);
                lvi.SubItems.Add(string.Empty);
                lvi.SubItems.Add(rig.Name + " total");
                lvi.SubItems.Add(rig.CurrentStatistic.Algorithm);
                lvi.SubItems.Add(GetRightMagnitude(rig.CurrentStatistic.TotalHashRate) + "H");
                lvi.SubItems.Add(GetRightMagnitude(rig.CurrentStatistic.AverageStandardDeviation) + "H");
                lvi.SubItems.Add(GetRightMagnitude(rig.CurrentStatistic.TotalHashCount));
                lvi.SubItems.Add(rig.CurrentStatistic.Accepts.ToString(CultureInfo.InvariantCulture));
                lvi.SubItems.Add(rig.CurrentStatistic.Rejects.ToString(CultureInfo.InvariantCulture));
                lvi.SubItems.Add(string.Empty);
                lvi.SubItems.Add(rig.CurrentStatistic.ShareAnswerPing.ToString(CultureInfo.InvariantCulture));
                lstGeneralOverview.Items.Add(lvi);
            }

            // Restores all the previously selected items in the General Overview List
            if (lstGeneralOverview.Items.Count > 0)
            {
                foreach (int selectedIndex in selectedIndexes)
                {
                    lstGeneralOverview.Items[selectedIndex].Selected = true;
                    lstGeneralOverview.Select();
                }
            }
        }

        private static string GetRightMagnitude(double rate)
        {
            string[] sizes = { "", "K", "M", "G", "T", "P", "E", "Z", "Y" };
            int order = 0;
            while (rate >= 10000 && order + 1 < sizes.Length)
            {
                order++;
                rate = rate / 1000;
            }

            return String.Format("{0:0.##} {1}", rate, sizes[order]);
        }

        private void UpdateController(object o)
        {
            _controller.Update();
            _updateTimer.Change(5000, Timeout.Infinite);
        }

        private void LoadSettings()
        {
            
        }

        private void LoadLogs()
        {
            _controller = File.Exists("logs.gz") 
                ? new RigController(JsonControl.GetSerializedGzipFile<BindingList<RigController.RigInfo>>("logs.gz"))
                : new RigController();
        }


        private void Monitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLogs();
            SaveSettings();
        }

        private void SaveLogs()
        {
            JsonControl.WriteSerializedGzipFile("logs.gz", _controller.RigLogs);
        }

        private void SaveSettings()
        {
            
        }

        private void txtRawLogs_Leave(object sender, EventArgs e)
        {
            _rawLogsGotFocus = false;
        }

        void txtRawLogs_GotFocus(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.None)
            {
                txtRawLogs.SelectAll();
                _rawLogsGotFocus = true;
            }
        }

        void txtRawLogs_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_rawLogsGotFocus && txtRawLogs.SelectionLength == 0)
            {
                _rawLogsGotFocus = true;
                txtRawLogs.SelectAll();
            }
        }

        private void tabRawLogs_Enter(object sender, EventArgs e)
        {
            txtRawLogs.Text = JsonConvert.SerializeObject(_controller, Formatting.Indented);
        }
    }
}
