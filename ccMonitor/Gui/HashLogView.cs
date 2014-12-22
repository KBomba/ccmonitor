using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccMonitor.Gui
{
    public partial class HashLogView : UserControl
    {
        public class UserFriendlyHashEntry
        {
            public string TimeStamp { get; set; }
            public string HashRate { get; set; }
            public string HashCount { get; set; }
            public string Found { get; set; }
            public string Height { get; set; }
            public string Difficulty { get; set; }
        }

        public HashLogView()
        {
            InitializeComponent();
            dgvHashLogs.AutoGenerateColumns = false;
            dgvHashLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvHashLogs.ColumnHeadersHeight = 42;
        }

        public void UpdateLogs(HashSet<GpuLogger.HashEntry> hashLogs)
        {
            dgvHashLogs.DataSource = null;
            List<UserFriendlyHashEntry> userFriendlyHashEntries = new List<UserFriendlyHashEntry>(hashLogs.Count);

            foreach (GpuLogger.HashEntry hashEntry in hashLogs)
            {
                UserFriendlyHashEntry userFriendlyHashEntry = new UserFriendlyHashEntry
                {
                    TimeStamp = GuiHelper.UnixTimeStampToDateTime(hashEntry.TimeStamp).ToString(CultureInfo.InvariantCulture),
                    HashRate = GuiHelper.GetRightMagnitude(hashEntry.HashRate, "H"),
                    HashCount = GuiHelper.GetRightMagnitude(hashEntry.HashCount),
                    Found = String.Format("{0:0}", hashEntry.Found),
                    Height = String.Format("{0:0}", hashEntry.Height),
                    Difficulty = hashEntry.Difficulty.ToString(CultureInfo.InvariantCulture)
                };

                userFriendlyHashEntries.Add(userFriendlyHashEntry);
            }

            dgvHashLogs.DataSource = userFriendlyHashEntries.OrderByDescending(entry => entry.TimeStamp).ToList();
        }
    }
}
