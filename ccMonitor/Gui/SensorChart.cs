using System;
using System.Collections.Generic;
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
        }

        public void UpdateCharts(List<GpuLogger.Benchmark.SensorValue> sensorValues, string os)
        {
            List<ChartFriendlySensorValue> chartFriendlySensorValues = new List<ChartFriendlySensorValue>(sensorValues.Count);
            DateTime now = DateTime.Now;
            TimeSpan start = new TimeSpan(_hours, 0, 0);

            bool windows = os.StartsWith("windows");
            chartSensor.ChartAreas["ChartAreaTemperatureFan"].AxisY2.Title = windows ? "Fan (RPM)" : "Fan (%)";

            chartFriendlySensorValues.AddRange(sensorValues.OrderBy(value => value.TimeStamp).Select(sensorValue => new ChartFriendlySensorValue
            {
                TimeStamp = GuiHelper.UnixTimeStampToDateTime(sensorValue.TimeStamp), 
                Temperature = sensorValue.Temperature,
                Fan = windows ? sensorValue.FanRpm : sensorValue.FanPercentage,
                CoreClockFrequency = sensorValue.CoreClockFrequency,
                MemoryClockFrequency = sensorValue.MemoryClockFrequency,
                ShareAnswerPing = sensorValue.ShareAnswerPing,
                MiningUrlPing = sensorValue.MiningUrlPing,
                NetworkRigPing = sensorValue.NetworkRigPing,
            }).Where(chartFriendlySensorValue => _hours > 9000 || chartFriendlySensorValue.TimeStamp > (now - start)));

            chartSensor.DataSource = chartFriendlySensorValues;
            chartSensor.DataBind();
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
