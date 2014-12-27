using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ccMonitor.Gui
{
    public partial class SensorLogView : UserControl
    {
        private class UserFriendlySensorValue
        {
            public string TimeStamp { get; set; }
            public string Temperature { get; set; }
            public string FanPercentage { get; set; }
            public string FanRpm { get; set; }
            public string CoreClockFrequency { get; set; }
            public string MemoryClockFrequency { get; set; }
            public string ShareAnswerPing { get; set; }
            public string MiningUrlPing { get; set; }
            public string NetworkRigPing { get; set; }
        }

        private readonly int _rows;

        public SensorLogView(int rows)
        {
            _rows = rows;
            InitializeComponent();
            dgvSensorLogs.AutoGenerateColumns = false;
            dgvSensorLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSensorLogs.ColumnHeadersHeight = 42;
        }
        
        public void UpdateLogs(List<GpuLogger.Benchmark.SensorValue> sensorLog)
        {
            List<UserFriendlySensorValue> userFriendlySensorValues = new List<UserFriendlySensorValue>(sensorLog.Count);
            List<GpuLogger.Benchmark.SensorValue> sortedSensorLog = sensorLog.OrderByDescending(value => value.TimeStamp).ToList();

            // If over 9000, just use max size, else make sure it doesn't get out of index
            int max = _rows > 9000 ? sortedSensorLog.Count : sortedSensorLog.Count < _rows ? sortedSensorLog.Count : _rows;
            for (int index = 0; index < max; index++)
            {
                GpuLogger.Benchmark.SensorValue sensorValue = sortedSensorLog[index];
                UserFriendlySensorValue userFriendlySensorValue = new UserFriendlySensorValue
                {
                    TimeStamp =
                        GuiHelper.UnixTimeStampToDateTime(sensorValue.TimeStamp).ToString(CultureInfo.InvariantCulture),
                    Temperature = sensorValue.Temperature.ToString(CultureInfo.InvariantCulture) + "°C",
                    FanPercentage = sensorValue.FanPercentage.ToString(CultureInfo.InvariantCulture) + " %",
                    FanRpm = sensorValue.FanRpm.ToString(CultureInfo.InvariantCulture),
                    CoreClockFrequency = GuiHelper.GetRightMagnitude(sensorValue.CoreClockFrequency, "Hz"),
                    MemoryClockFrequency = GuiHelper.GetRightMagnitude(sensorValue.MemoryClockFrequency, "Hz"),
                    ShareAnswerPing = sensorValue.ShareAnswerPing.ToString(CultureInfo.InvariantCulture) + " ms",
                    MiningUrlPing = sensorValue.MiningUrlPing.ToString(CultureInfo.InvariantCulture) + " ms",
                    NetworkRigPing = sensorValue.NetworkRigPing.ToString(CultureInfo.InvariantCulture) + " ms",
                };

                userFriendlySensorValues.Add(userFriendlySensorValue);
            }

            dgvSensorLogs.DataSource = userFriendlySensorValues;
        }
    }
}
