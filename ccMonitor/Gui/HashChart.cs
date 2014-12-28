using System;
using System.Collections.Generic;
using System.Linq;
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

        private readonly int _hours;

        public HashChart(int hours = 1)
        {
            _hours = hours;
            InitializeComponent();
            
            chartHash.MouseWheel += chart_MouseWheel;
        }

        public void UpdateCharts(HashSet<GpuLogger.Benchmark.HashEntry> hashLogs)
        {
            List<ChartFriendlyHashEntry> chartFriendlyHashEntries = new List<ChartFriendlyHashEntry>(hashLogs.Count);
            DateTime now = DateTime.Now;
            TimeSpan start = new TimeSpan(_hours, 0, 0);
            chartFriendlyHashEntries.AddRange(hashLogs.OrderBy(entry => entry.TimeStamp).Select(hashEntry => new ChartFriendlyHashEntry
            {
                TimeStamp = GuiHelper.UnixTimeStampToDateTime(hashEntry.TimeStamp), 
                HashRate = Math.Round(hashEntry.HashRate, MidpointRounding.AwayFromZero), 
                Found = hashEntry.Found, 
                Difficulty = hashEntry.Difficulty, 
                HashCount = hashEntry.HashCount
            }).Where(chartFriendlyHashEntry => _hours > 9000 || chartFriendlyHashEntry.TimeStamp > (now - start)));

            chartHash.DataSource = chartFriendlyHashEntries;
            chartHash.DataBind();

            AutoFormatXAxis(chartFriendlyHashEntries);
        }

        private void AutoFormatXAxis(List<ChartFriendlyHashEntry> chartHashEntries)
        {
            int hours = _hours;
            if (hours > 9000)
            {
                hours = (int)Math.Round((chartHashEntries[chartHashEntries.Count - 1].TimeStamp -
                                          chartHashEntries[0].TimeStamp).TotalHours, MidpointRounding.AwayFromZero);
            }

            foreach (ChartArea chartArea in chartHash.ChartAreas)
            {
                if (hours < 6)
                {
                    chartArea.AxisX.LabelStyle.Format = "ddd HH:mm:ss";
                }
                else if (hours < 320)
                {
                    chartArea.AxisX.LabelStyle.Format = "MMM dd HH:mm";
                }
                else if (hours < 4600)
                {
                    chartArea.AxisX.LabelStyle.Format = "MMM dd YY HH";
                }
                else
                {
                    chartArea.AxisX.LabelStyle.Format = "MMM dd YYYY";
                }
            }
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

                    double posXStart = chart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 3;
                    double posXFinish = chart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 3;

                    chart.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                }
            }
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
