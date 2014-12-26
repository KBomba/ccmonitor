using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ccMonitor.Gui
{
    public partial class HashLogView : UserControl
    {
        private class UserFriendlyHashEntry
        {
            public string TimeStamp { get; set; }
            public string HashRate { get; set; }
            public string HashCount { get; set; }
            public string Found { get; set; }
            public string Height { get; set; }
            public string Difficulty { get; set; }
        }

        private readonly int _rows;

        public HashLogView(int rows)
        {
            _rows = rows;

            InitializeComponent();

            dgvHashLogs.AutoGenerateColumns = false;
            dgvHashLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvHashLogs.ColumnHeadersHeight = 42;
        }

        public void UpdateLogs(HashSet<GpuLogger.Benchmark.HashEntry> hashLogs)
        {
            dgvHashLogs.DataSource = null;
            List<UserFriendlyHashEntry> userFriendlyHashEntries = new List<UserFriendlyHashEntry>(hashLogs.Count);

            List<GpuLogger.Benchmark.HashEntry> sortedHashLogs = hashLogs.OrderByDescending(entry => entry.TimeStamp).ToList();
            // If over 9000, just use max size, else make sure it doesn't get out of index
            int max = _rows > 9000? sortedHashLogs.Count : sortedHashLogs.Count < _rows ? sortedHashLogs.Count : _rows;
            for (int index = 0; index < max; index++)
            {
                GpuLogger.Benchmark.HashEntry hashEntry = sortedHashLogs[index];
                UserFriendlyHashEntry userFriendlyHashEntry = new UserFriendlyHashEntry
                {
                    TimeStamp =
                        GuiHelper.UnixTimeStampToDateTime(hashEntry.TimeStamp).ToString(CultureInfo.InvariantCulture),
                    HashRate = GuiHelper.GetRightMagnitude(hashEntry.HashRate, "H"),
                    HashCount = GuiHelper.GetRightMagnitude(hashEntry.HashCount),
                    Found = String.Format("{0:0}", hashEntry.Found),
                    Height = String.Format("{0:0}", hashEntry.Height),
                    Difficulty = hashEntry.Difficulty.ToString(CultureInfo.InvariantCulture)
                };

                userFriendlyHashEntries.Add(userFriendlyHashEntry);
            }

            dgvHashLogs.DataSource = userFriendlyHashEntries;
        }
    }
}
