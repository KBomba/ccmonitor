using System;

namespace ccMonitor.Gui
{
    public static class GuiHelper
    {
        public static string GetRightMagnitude(long totalHashCount, string append = "")
        {
            return GetRightMagnitude((decimal)totalHashCount, append);
        }

        public static string GetRightMagnitude(double rate, string append = "")
        {
            return GetRightMagnitude((decimal) rate, append);
        }

        public static string GetRightMagnitude(uint hashCount, string append = "")
        {
            return GetRightMagnitude((decimal)hashCount, append);
        }

        public static string GetRightMagnitude(decimal rate, string append = "")
        {
            string[] sizes = { "", "K", "M", "G", "T", "P", "E", "Z", "Y" };
            int order = 0;
            while (rate >= 1000 && order + 1 < sizes.Length)
            {
                order++;
                rate = rate / 1000;
            }

            return String.Format("{0:0.000} {1}{2}", rate, sizes[order], append);
        }

        public static DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        public static long GetCurrentUnixTimeStamp()
        {
            return (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }

        /*[DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WmSetredraw = 11;

        public static void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WmSetredraw, false, 0);
        }

        public static void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WmSetredraw, true, 0);
            parent.Refresh();
        }

        public static void ApplyAll(Control control, Action<Control> action)
        {
            action(control);
            foreach (Control child in control.Controls)
            {
                ApplyAll(child, action);
            }
        }*/
    }
}
