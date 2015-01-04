using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ccMonitor.Api;
using Newtonsoft.Json;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace ccMonitor.Gui
{
    public partial class RigTab : UserControl
    {
        private RigController.Rig Rig { get; set; }

        // Used for the API console
        private readonly List<string> _apiCommands;
        private int _apiCommandsIndex;
        private string _stringBeforeUpOrDown;

        public RigTab(RigController.Rig rig)
        {
            Rig = rig;
            _apiCommands = new List<string>();
            InitializeComponent();
        }

        public void UpdateGui()
        {
            UpdateStatCharts();

            // Adds missing gpu tabs
            foreach (GpuLogger gpu in Rig.GpuLogs)
            {
                bool found = false;
                foreach (TabPage tabPage in tbcRig.TabPages)
                {
                    if (tabPage != tabRigOverview && tabPage != tabRigApiConsole
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

            // Removes deleted gpus
            List<TabPage> sentencedTabPages = new List<TabPage>();
            foreach (TabPage tabPage in tbcRig.TabPages)
            {
                if (tabPage != tabRigOverview && tabPage != tabRigApiConsole)
                {
                    bool found = false;
                    foreach (GpuLogger gpu in Rig.GpuLogs)
                    {
                        if (tabPage.Text == gpu.Info.ToString())
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        sentencedTabPages.Add(tabPage);
                    }
                }
            }

            foreach (TabPage tabPage in sentencedTabPages)
            {
                tbcRig.TabPages.Remove(tabPage);
            }
        }

        private void UpdateStatCharts()
        {
            DateTime now = DateTime.Now;
            int gpuCount = Rig.GpuLogs.Count(gpu => gpu.Info.Available);


            List<GpuLogger.Benchmark.HashEntry> hashEntries = null;
            if (Rig.GpuLogs.Count > 0 && Rig.GpuLogs[0] != null && Rig.GpuLogs[0].CurrentBenchmark != null) hashEntries = Rig.GpuLogs[0].CurrentBenchmark.HashLogs.OrderBy(entry => entry.TimeStamp).ToList();
            if (hashEntries != null && hashEntries.Count > 1)
            {
                chartStats.Series["TotalHashrateSeries"].ChartType = SeriesChartType.FastLine;
                chartStats.Series["TotalHashrateSeries"].Points.AddXY(now, Rig.GpuLogs[0].CurrentBenchmark.CurrentStatistic.HashCountedRate);

                chartStats.Series["TotalSpreadSeries"].ChartType = SeriesChartType.FastLine;
                chartStats.Series["TotalSpreadSeries"].Points.AddXY(now, Rig.GpuLogs[0].CurrentBenchmark.CurrentStatistic.StdMadFactor);
                chartStats.Series["TotalSpreadSeries"].YAxisType = AxisType.Primary;

                Color totalHashrateColor = chartStats.Series["TotalHashrateSeries"].Color;
                chartStats.Series["TotalSpreadSeries"].BorderColor = totalHashrateColor;
                chartStats.Series["TotalSpreadSeries"].BorderWidth = 2;
                chartStats.Series["TotalSpreadSeries"].Color = Color.FromArgb(255, Color.Red);
            }
            /*chartStats.Series["TotalHashrateSeries"].Points.AddXY(now, Rig.CurrentStatistic.TotalHashRate);
            if (Rig.CurrentStatistic.AveragePercentiles != null)
            {
                chartStats.Series["TotalSpreadSeries"].Points.AddXY(now,
                Rig.CurrentStatistic.AveragePercentiles["-2σ"] * gpuCount,
                Rig.CurrentStatistic.AveragePercentiles["+2σ"] * gpuCount);
            }

            Color totalHashrateColor = chartStats.Series["TotalHashrateSeries"].Color;
            chartStats.Series["TotalSpreadSeries"].BorderColor = totalHashrateColor;
            chartStats.Series["TotalSpreadSeries"].Color = Color.FromArgb(50, totalHashrateColor);

            Random r = new Random();
            foreach (GpuLogger gpu in Rig.GpuLogs)
            {
                Series total = new Series(gpu.Info.ToString());
                total.ChartArea = chartStats.ChartAreas[0].Name;
                total.Color = Color.FromArgb(50, r.Next(0,255), r.Next(0,255), r.Next(0,255));
            }*/
        }

        private void txtApiConsole_KeyDown(object sender, KeyEventArgs e)
        {
            // Always go to the end of the textbox, never type in the middle
            txtApiConsole.SelectionStart = txtApiConsole.TextLength;
            txtApiConsole.ScrollToCaret();

            // Never remove the last >
            if (e.KeyCode == Keys.Back)
            {
                if (txtApiConsole.Text[txtApiConsole.TextLength - 1] == '>')
                {
                    e.SuppressKeyPress = true;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                string[] splitStrings = txtApiConsole.Text.Split('>');
                string trimmed = splitStrings[splitStrings.Length - 1].Trim();
                // Only the last line starting with a > is needed

                // Avoid sending empty requests
                if (trimmed != string.Empty)
                {
                    _apiCommands.Insert(0, trimmed);

                    Dictionary<string, string>[] request = PruvotApi.Request(Rig.IpAddress, Rig.Port, trimmed);
                    if (request != null)
                    {
                        txtApiConsole.AppendText(Environment.NewLine +
                                                 JsonConvert.SerializeObject(request, Formatting.Indented)
                                                 + Environment.NewLine + " >  ");
                        _apiCommandsIndex = 0;
                    }
                }
                else
                {
                    txtApiConsole.AppendText(Environment.NewLine + " >  ");
                }

                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                if (string.IsNullOrEmpty(_stringBeforeUpOrDown))
                {
                    _stringBeforeUpOrDown = txtApiConsole.Lines[txtApiConsole.Lines.Length - 1];
                    // Keep the current string in memory when browsing through history of commands
                }

                StringBuilder sb = new StringBuilder(txtApiConsole.TextLength);
                for (int index = 0; index < txtApiConsole.Lines.Length - 1; index++)
                {
                    sb.AppendLine(txtApiConsole.Lines[index]);
                }

                if (_apiCommands.Count > 0)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        if (_apiCommandsIndex >= _apiCommands.Count)
                        {
                            _apiCommandsIndex = _apiCommands.Count - 1;
                        }

                        sb.AppendLine(" >  " + _apiCommands[_apiCommandsIndex]);
                    }
                    else
                    {
                        _apiCommandsIndex -= 2;
                        // -2 seems to give the most normal behavior
                        if ( _apiCommandsIndex < 0)
                        {
                            _apiCommandsIndex = -1;
                            sb.AppendLine(_stringBeforeUpOrDown);
                        }
                        else
                        {
                            sb.AppendLine(" >  " + _apiCommands[_apiCommandsIndex]);
                        }
                    }

                    _apiCommandsIndex++;
                }
                else
                {
                    sb.AppendLine(_stringBeforeUpOrDown);
                }

                txtApiConsole.Text = sb.ToString(0, sb.Length - 2);
                txtApiConsole.SelectionStart = txtApiConsole.TextLength;
                txtApiConsole.ScrollToCaret();

                e.SuppressKeyPress = true;
            }
            else
            {
                _stringBeforeUpOrDown = string.Empty;
            }
        }
    }
}
