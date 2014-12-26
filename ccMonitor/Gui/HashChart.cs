using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ccMonitor.Gui
{
    public partial class HashChart : UserControl
    {
        private class ChartFriendlyHashEntry
        {
            public DateTime TimeStamp { get; set; }
            public double HashRate { get; set; }
            public uint Found { get; set; }
            public double Difficulty { get; set; }
            public uint HashCount { get; set; }
        }

        public HashChart()
        {
            InitializeComponent();
            
            chartHashrateFound.MouseWheel += chart_MouseWheel;
        }

        private void chart_MouseWheel(object sender, MouseEventArgs e)
        {
            Chart chart = sender as Chart;
            if (chart != null)
            {
                if (e.Delta < 0)
                {
                    chart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                }

                if (e.Delta > 0)
                {
                    double xMin = chart.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = chart.ChartAreas[0].AxisX.ScaleView.ViewMaximum;

                    double posXStart = chart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin)/3;
                    double posXFinish = chart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin)/3;

                    chart.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                }
            }
        }

        public void UpdateCharts(HashSet<GpuLogger.Benchmark.HashEntry> hashLogs)
        {
            List<ChartFriendlyHashEntry> chartFriendlyHashEntries = new List<ChartFriendlyHashEntry>(hashLogs.Count);
            IOrderedEnumerable<GpuLogger.Benchmark.HashEntry> orderedHashLogs = hashLogs.OrderBy(entry => entry.TimeStamp);
            foreach (GpuLogger.Benchmark.HashEntry hashEntry in orderedHashLogs)
            {
                ChartFriendlyHashEntry chartFriendlyHashEntry = new ChartFriendlyHashEntry
                {
                    TimeStamp = GuiHelper.UnixTimeStampToDateTime(hashEntry.TimeStamp),
                    HashRate = Math.Round(hashEntry.HashRate, MidpointRounding.AwayFromZero),
                    Found = hashEntry.Found,
                    Difficulty = hashEntry.Difficulty,
                    HashCount = hashEntry.HashCount
                };

                chartFriendlyHashEntries.Add(chartFriendlyHashEntry);
            }

            chartHashrateFound.DataSource = chartFriendlyHashEntries;
            chartHashrateFound.Series["HashrateSeries"].XValueMember = "TimeStamp";
            chartHashrateFound.Series["HashrateSeries"].YValueMembers = "HashRate";
            chartHashrateFound.Series["FoundSeries"].XValueMember = "TimeStamp";
            chartHashrateFound.Series["FoundSeries"].YValueMembers = "Found";
            chartHashrateFound.Series["DifficultySeries"].XValueMember = "TimeStamp";
            chartHashrateFound.Series["DifficultySeries"].YValueMembers = "Difficulty";
            chartHashrateFound.Series["HashcountSeries"].XValueMember = "TimeStamp";
            chartHashrateFound.Series["HashcountSeries"].YValueMembers = "HashCount";
            chartHashrateFound.DataBind();
        }

        private void chart_MouseEnter(object sender, EventArgs e)
        {
            Chart chart = sender as Chart;
            if (chart != null) chart.Focus();
        }

        private void chart_MouseLeave(object sender, EventArgs e)
        {
            Chart chart = sender as Chart;
            if (chart != null) chart.Parent.Focus();
        }
    }
}
