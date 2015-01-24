using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
            public double HashRateTop { get; set; }
            public double HashRateBottom { get; set; }
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
            chartHash.LostFocus += chart_Focus;
            chartHash.Series["AvailabilityFoundSeries"].Color = Color.FromArgb(50, Color.Red);
            chartHash.Series["AvailabilityDifficultySeries"].Color = Color.FromArgb(50, Color.Red);
        }

        public void UpdateCharts(HashSet<GpuLogger.Benchmark.HashEntry> hashLogs, List<GpuLogger.Benchmark.Availability> availabilityTimeStamps)
        {
            List<ChartFriendlyHashEntry> chartFriendlyHashEntries = new List<ChartFriendlyHashEntry>(hashLogs.Count);
            DateTime now = DateTime.Now;
            TimeSpan start = new TimeSpan(_hours, 0, 0);
            IEnumerable<ChartFriendlyHashEntry> friendlyHashEntries = hashLogs.OrderBy(entry => entry.TimeStamp).Select(hashEntry => new ChartFriendlyHashEntry
            {
                TimeStamp = GuiHelper.UnixTimeStampToDateTime(hashEntry.TimeStamp),
                HashRate = (double) Decimal.Round(hashEntry.HashRate, MidpointRounding.AwayFromZero),
                Found = hashEntry.Found,
                Difficulty = (double) hashEntry.Difficulty,
                HashCount = hashEntry.HashCount
            }).Where(chartFriendlyHashEntry => _hours > 9000 || chartFriendlyHashEntry.TimeStamp > (now - start));

            List<ChartFriendlyHashEntry> values = friendlyHashEntries as List<ChartFriendlyHashEntry> ?? friendlyHashEntries.ToList();
            if (values.Count > 0)
            {
                chartFriendlyHashEntries.AddRange(values);

                chartHash.SuspendLayout();
                chartHash.DataSource = chartFriendlyHashEntries;
                chartHash.DataBind();

                UpdateAvailabilityCharts(availabilityTimeStamps, values);
                AutoFormatXAxis(chartFriendlyHashEntries);
                chartHash.ResumeLayout(true);
            }
        }

        private void UpdateAvailabilityCharts(List<GpuLogger.Benchmark.Availability> availabilityTimeStamps, IList<ChartFriendlyHashEntry> friendlyHashEntry)
        {
            chartHash.Series["AvailabilityFoundSeries"].Points.Clear();
            chartHash.Series["AvailabilityDifficultySeries"].Points.Clear();
            DateTime firstTimeStamp = friendlyHashEntry[0].TimeStamp;
            const double chartFoundMaximum = 5;
            const double chartFoundMinimum = 0;
            double chartDifficultyMaximum = friendlyHashEntry.Max(value => value.Difficulty)*1.2;
            const double chartDifficultyMinimum = 0;;

            for (int index = 0; index < availabilityTimeStamps.Count - 1; index++)
            {
                GpuLogger.Benchmark.Availability availabilityTimeStamp = availabilityTimeStamps[index];
                DateTime dateTime = GuiHelper.UnixTimeStampToDateTime(availabilityTimeStamp.TimeStamp);
                if (!availabilityTimeStamp.Available && dateTime > firstTimeStamp)
                {
                    GpuLogger.Benchmark.Availability nextAvailabilityTimeStamp = availabilityTimeStamps[index + 1];

                    DateTime nextDateTime = GuiHelper.UnixTimeStampToDateTime(nextAvailabilityTimeStamp.TimeStamp);

                    chartHash.Series["AvailabilityFoundSeries"].Points.AddXY(dateTime + new TimeSpan(0, 0, 1),
                        chartFoundMinimum);
                    chartHash.Series["AvailabilityFoundSeries"].Points.AddXY(dateTime + new TimeSpan(0, 0, 1),
                        chartFoundMaximum + 1);
                    chartHash.Series["AvailabilityFoundSeries"].Points.AddXY(nextDateTime - new TimeSpan(0, 0, 1),
                        chartFoundMaximum + 1);
                    chartHash.Series["AvailabilityFoundSeries"].Points.AddXY(nextDateTime - new TimeSpan(0, 0, 1),
                        chartFoundMinimum);

                    chartHash.Series["AvailabilityDifficultySeries"].Points.AddXY(dateTime + new TimeSpan(0, 0, 1),
                        chartDifficultyMinimum);
                    chartHash.Series["AvailabilityDifficultySeries"].Points.AddXY(dateTime + new TimeSpan(0, 0, 1),
                        chartDifficultyMaximum + 1);
                    chartHash.Series["AvailabilityDifficultySeries"].Points.AddXY(nextDateTime - new TimeSpan(0, 0, 1),
                        chartDifficultyMaximum + 1);
                    chartHash.Series["AvailabilityDifficultySeries"].Points.AddXY(nextDateTime - new TimeSpan(0, 0, 1),
                        chartDifficultyMinimum);
                }
            }

            chartHash.ChartAreas["ChartAreaFoundHashrate"].AxisY2.Maximum = chartFoundMaximum;
            chartHash.ChartAreas["ChartAreaFoundHashrate"].AxisY2.Minimum = chartFoundMinimum;
            chartHash.ChartAreas["ChartAreaDifficultyHashcount"].AxisY2.Maximum = chartDifficultyMaximum;
            chartHash.ChartAreas["ChartAreaDifficultyHashcount"].AxisY2.Minimum = chartDifficultyMinimum;
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

        private void chart_Focus(object sender, EventArgs e)
        {
            Chart chart = sender as Chart;
            if (chart != null) chart.Focus();
        }

        private void chart_MouseLeave(object sender, EventArgs e)
        {
            Chart chart = sender as Chart;
            if (chart != null) chart.Parent.Focus();
        }

        private void chartHash_AxisViewChanged(object sender, ViewEventArgs e)
        {
            if (e.Axis.AxisName == AxisName.X)
            {
                double start = e.Axis.ScaleView.ViewMinimum;
                double end = e.Axis.ScaleView.ViewMaximum;

                double[] hashrate =
                    chartHash.Series["HashrateSeries"].Points.Where(
                        point => point.XValue >= start && point.XValue <= end).Select(x => x.YValues[0]).ToArray();
                if (hashrate.Length > 0)
                {
                    double ymin = hashrate.Min();
                    double ymax = hashrate.Max();
                    chartHash.ChartAreas["ChartAreaFoundHashrate"].AxisY.Minimum = ymin * 0.99;
                    chartHash.ChartAreas["ChartAreaFoundHashrate"].AxisY.Maximum = ymax * 1.01;
                }

                chartHash.ChartAreas["ChartAreaFoundHashrate"].AxisY2.Minimum = 0;
                chartHash.ChartAreas["ChartAreaFoundHashrate"].AxisY2.Maximum = 5;

                double[] diff =
                    chartHash.Series["DifficultySeries"].Points.Where(
                        point => point.XValue >= start && point.XValue <= end).Select(x => x.YValues[0]).ToArray();
                if (diff.Length > 0)
                {
                    const double ymin = 0;
                    double ymax = diff.Max();
                    chartHash.ChartAreas["ChartAreaDifficultyHashcount"].AxisY2.Minimum = ymin;
                    chartHash.ChartAreas["ChartAreaDifficultyHashcount"].AxisY2.Maximum = ymax * 1.4;
                }
            }
        }
    }
}
