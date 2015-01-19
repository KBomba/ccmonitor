using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ccMonitor.Gui
{
    public partial class SensorChart : UserControl
    {
        private class ChartFriendlySensorValue
        {
            public DateTime TimeStamp { get; set; }
            public double Temperature { get; set; }
            public double Fan { get; set; }
            public double CoreClockFrequency { get; set; }
            public double MemoryClockFrequency { get; set; }
            public int ShareAnswerPing { get; set; }
            public int MiningUrlPing { get; set; }
            public int NetworkRigPing { get; set; }
        }
        
        private readonly int _hours;

        public SensorChart(int hours = 1)
        {
            _hours = hours;

            InitializeComponent();

            chartSensor.MouseWheel += chart_MouseWheel;
            chartSensor.Series["AvailabilityTemperatureSeries"].Color = Color.FromArgb(50, Color.Red);
            chartSensor.Series["AvailabilityPingSeries"].Color = Color.FromArgb(50, Color.Red);
        }

        public void UpdateCharts(List<GpuLogger.Benchmark.SensorValue> sensorValues, List<GpuLogger.Benchmark.Availability> availabilityTimeStamps, string os)
        {
            List<ChartFriendlySensorValue> chartFriendlySensorValues = new List<ChartFriendlySensorValue>(sensorValues.Count);
            DateTime now = DateTime.Now;
            TimeSpan start = new TimeSpan(_hours, 0, 0);

            bool windows = os.StartsWith("windows");
            chartSensor.ChartAreas["ChartAreaTemperatureFan"].AxisY2.Title = windows ? "Fan (RPM)" : "Fan (%)";

            IEnumerable<ChartFriendlySensorValue> friendlySensorValues = sensorValues
                .OrderBy(value => value.TimeStamp).Select(sensorValue => new ChartFriendlySensorValue
            {
                TimeStamp = GuiHelper.UnixTimeStampToDateTime(sensorValue.TimeStamp), 
                Temperature = (double) sensorValue.Temperature,
                Fan = (double) (windows ? sensorValue.FanRpm : sensorValue.FanPercentage),
                CoreClockFrequency = (double) sensorValue.CoreClockFrequency,
                MemoryClockFrequency = (double) sensorValue.MemoryClockFrequency,
                ShareAnswerPing = sensorValue.ShareAnswerPing,
                MiningUrlPing = sensorValue.MiningUrlPing,
                NetworkRigPing = sensorValue.NetworkRigPing,
            }).Where(chartFriendlySensorValue => _hours > 9000 || chartFriendlySensorValue.TimeStamp > (now - start));

            IList<ChartFriendlySensorValue> values = friendlySensorValues as IList<ChartFriendlySensorValue> ?? friendlySensorValues.ToList();

            if (values.Count > 0)
            {
                chartFriendlySensorValues.AddRange(values);

                chartSensor.SuspendLayout();
                chartSensor.DataSource = chartFriendlySensorValues;
                chartSensor.DataBind();

                UpdateAvailabilityCharts(availabilityTimeStamps, values);
                AutoFormatXAxis(chartFriendlySensorValues);
                chartSensor.ResumeLayout(true);
            }
        }

        private void UpdateAvailabilityCharts(List<GpuLogger.Benchmark.Availability> availabilityTimeStamps, IList<ChartFriendlySensorValue> friendlySensorValues)
        {
            chartSensor.Series["AvailabilityTemperatureSeries"].Points.Clear();
            chartSensor.Series["AvailabilityPingSeries"].Points.Clear();
            DateTime firstTimeStamp = friendlySensorValues[0].TimeStamp;
            double chartTempMaximum = friendlySensorValues.Max(value => value.Temperature)*1.2;
            double chartTempMinimum = friendlySensorValues.Min(value => value.Temperature)*0.8;
            double chartPingMaximum = friendlySensorValues.SelectMany(
                value => new[] {value.MiningUrlPing, value.NetworkRigPing, value.ShareAnswerPing}).Max()*1.2;
            const double chartPingMinimum = 0;

            for (int index = 0; index < availabilityTimeStamps.Count - 1; index++)
            {
                GpuLogger.Benchmark.Availability availabilityTimeStamp = availabilityTimeStamps[index];
                DateTime dateTime = GuiHelper.UnixTimeStampToDateTime(availabilityTimeStamp.TimeStamp);
                if (!availabilityTimeStamp.Available && dateTime > firstTimeStamp)
                {
                    GpuLogger.Benchmark.Availability nextAvailabilityTimeStamp = availabilityTimeStamps[index + 1];

                    DateTime nextDateTime = GuiHelper.UnixTimeStampToDateTime(nextAvailabilityTimeStamp.TimeStamp);

                    chartSensor.Series["AvailabilityTemperatureSeries"].Points.AddXY(dateTime + new TimeSpan(0, 0, 1),
                        chartTempMinimum);
                    chartSensor.Series["AvailabilityTemperatureSeries"].Points.AddXY(dateTime + new TimeSpan(0, 0, 1),
                        chartTempMaximum + 1);
                    chartSensor.Series["AvailabilityTemperatureSeries"].Points.AddXY(nextDateTime - new TimeSpan(0, 0, 1),
                        chartTempMaximum + 1);
                    chartSensor.Series["AvailabilityTemperatureSeries"].Points.AddXY(nextDateTime - new TimeSpan(0, 0, 1),
                        chartTempMinimum);

                    chartSensor.Series["AvailabilityPingSeries"].Points.AddXY(dateTime + new TimeSpan(0, 0, 1),
                        chartPingMinimum);
                    chartSensor.Series["AvailabilityPingSeries"].Points.AddXY(dateTime + new TimeSpan(0, 0, 1),
                        chartPingMaximum + 1);
                    chartSensor.Series["AvailabilityPingSeries"].Points.AddXY(nextDateTime - new TimeSpan(0, 0, 1),
                        chartPingMaximum + 1);
                    chartSensor.Series["AvailabilityPingSeries"].Points.AddXY(nextDateTime - new TimeSpan(0, 0, 1),
                        chartPingMinimum);
                }
            }

            chartSensor.ChartAreas["ChartAreaTemperatureFan"].AxisY.Maximum = chartTempMaximum;
            chartSensor.ChartAreas["ChartAreaTemperatureFan"].AxisY.Minimum = chartTempMinimum;
            chartSensor.ChartAreas["ChartAreaPingFrequency"].AxisY.Maximum = chartPingMaximum;
            chartSensor.ChartAreas["ChartAreaPingFrequency"].AxisY.Minimum = chartPingMinimum;
        }

        private void AutoFormatXAxis(List<ChartFriendlySensorValue> chartFriendlySensorValues)
        {
            int hours = _hours;
            if (hours > 9000)
            {
                hours = (int) Math.Round((chartFriendlySensorValues[chartFriendlySensorValues.Count - 1].TimeStamp -
                                          chartFriendlySensorValues[0].TimeStamp).TotalHours, MidpointRounding.AwayFromZero);
            }
            foreach (ChartArea chartArea in chartSensor.ChartAreas)
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

        private void chartSensor_AxisViewChanged(object sender, ViewEventArgs e)
        {
            if (e.Axis.AxisName == AxisName.X)
            {
                double start = e.Axis.ScaleView.ViewMinimum;
                double end = e.Axis.ScaleView.ViewMaximum;

                double[] temp =
                    chartSensor.Series["TemperatureSeries"].Points.Where(
                        point => point.XValue >= start && point.XValue <= end).Select(x => x.YValues[0]).ToArray();
                if (temp.Length > 0)
                {
                    double ymin = temp.Min();
                    double ymax = temp.Max();
                    chartSensor.ChartAreas["ChartAreaTemperatureFan"].AxisY.Minimum = ymin * 0.8;
                    chartSensor.ChartAreas["ChartAreaTemperatureFan"].AxisY.Maximum = ymax * 1.2;
                }

                double[] sharePing =
                    chartSensor.Series["SharepingSeries"].Points.Where(
                        point => point.XValue >= start && point.XValue <= end).Select(x => x.YValues[0]).ToArray();
                double[] miningPing =
                    chartSensor.Series["MiningpingSeries"].Points.Where(
                        point => point.XValue >= start && point.XValue <= end).Select(x => x.YValues[0]).ToArray();
                double[] networkPing =
                    chartSensor.Series["NetworkpingSeries"].Points.Where(
                        point => point.XValue >= start && point.XValue <= end).Select(x => x.YValues[0]).ToArray();
                if (sharePing.Length > 0 && miningPing.Length > 0 && networkPing.Length > 0)
                {
                    double sharePingMax = sharePing.Max(), miningPingMax = miningPing.Max(), networkPingMax = networkPing.Max();

                    double ymin = 0;
                    double ymax = Math.Max(sharePingMax, Math.Max(miningPingMax, networkPingMax));
                    chartSensor.ChartAreas["ChartAreaPingFrequency"].AxisY.Minimum = ymin * 0.8;
                    chartSensor.ChartAreas["ChartAreaPingFrequency"].AxisY.Maximum = ymax * 1.2;
                }
            }
        }
    }
}
