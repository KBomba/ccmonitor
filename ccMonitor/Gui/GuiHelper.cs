using System;

namespace ccMonitor.Gui
{
    public static class GuiHelper
    {
        public static string GetRightMagnitude(double rate, string append = "")
        {
            string[] sizes = { "", "K", "M", "G", "T", "P", "E", "Z", "Y" };
            int order = 0;
            while (rate >= 1000 && order + 1 < sizes.Length)
            {
                order++;
                rate = rate / 1000;
            }

            return String.Format("{0:0.###} {1}{2}", rate, sizes[order], append);
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
    }
}
