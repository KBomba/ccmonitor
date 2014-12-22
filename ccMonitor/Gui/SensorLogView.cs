using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccMonitor.Gui
{
    public partial class SensorLogView : UserControl
    {
        public class UserFriendlySensorValue
        {
            public string TimeStamp { get; set; }
            public string Temperature { get; set; }
            public string FanPercentage { get; set; }
            public string CoreClockFrequency { get; set; }
            public string MemoryClockFrequency { get; set; }
            public string ShareAnswerPing { get; set; }
            public string MiningUrlPing { get; set; }
            public string NetworkRigPing { get; set; }
        }

        public SensorLogView()
        {
            InitializeComponent();
            dgvSensorLogs.AutoGenerateColumns = false;
            dgvSensorLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSensorLogs.ColumnHeadersHeight = 42;
        }
        
        public void UpdateLogs(List<GpuLogger.SensorValues> sensorLog)
        {
            dgvSensorLogs.DataSource = null;
            List<UserFriendlySensorValue> userFriendlySensorValues = new List<UserFriendlySensorValue>(sensorLog.Count);

            foreach (GpuLogger.SensorValues sensorValue in sensorLog)
            {
                UserFriendlySensorValue userFriendlySensorValue = new UserFriendlySensorValue
                {
                    TimeStamp = GuiHelper.UnixTimeStampToDateTime(sensorValue.TimeStamp).ToString(CultureInfo.InvariantCulture),
                    Temperature = sensorValue.Temperature.ToString(CultureInfo.InvariantCulture) + "°C",
                    FanPercentage = sensorValue.FanPercentage.ToString(CultureInfo.InvariantCulture) + " %",
                    CoreClockFrequency = GuiHelper.GetRightMagnitude(sensorValue.CoreClockFrequency, "Hz"),
                    MemoryClockFrequency = GuiHelper.GetRightMagnitude(sensorValue.MemoryClockFrequency, "Hz"),
                    ShareAnswerPing = sensorValue.ShareAnswerPing.ToString(CultureInfo.InvariantCulture) + " ms",
                    MiningUrlPing = sensorValue.MiningUrlPing.ToString(CultureInfo.InvariantCulture) + " ms",
                    NetworkRigPing = sensorValue.NetworkRigPing.ToString(CultureInfo.InvariantCulture) + " ms",
                }; 

                userFriendlySensorValues.Add(userFriendlySensorValue);
            }

            dgvSensorLogs.DataSource = userFriendlySensorValues.OrderByDescending(value => value.TimeStamp).ToList();
        }
    }
}
