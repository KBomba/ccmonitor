using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Markup;

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

        public static Image GetImageFromBase64DataUri(string uri)
        {
            string base64Data = Regex.Match(uri, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
            byte[] binData = Convert.FromBase64String(base64Data);

            Image image;
            using (MemoryStream stream = new MemoryStream(binData))
            {
                image = new Bitmap(stream);
            }
            return image;
        }

        public const string ReloadButtonImage =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAABoElEQVQ4jWNgoCX476DA8ctWvveLs4weuQZI/LaX+/7bTvbtLxtFfdINcOcT+mErk/vDXubfV3vp118sxXWJ0vjTQTbip73Mqe/2sv+/2Mv8/2Qv/f+DndT/N3aS1whq/uEgPeGbvcz/T3YyH9/bS817ayM5642txL9XtpL/n9hJ1uDV/MVOMvqTvfT/D/ZSN545SIn8N2ZgfWkrcfaZrcT/h3YSDQRtf28ndeu1rcSr+w4SCgwMDAwvnbnFH9uIv7pnI47fZgYGBoZnDlIiL20l/j+xEd9MUDE28MhaROqxjfj/BzYii8gy4Ko2A9tda9GvN61FLv4PZWDGpuakDbf+UUuemZM8GdixGnLdRmjeVSuh/5et+TPQ5fZbCCgcMed5cdCC5/MScwY+rAacshOSPW/J//K0hcC3k1b8sw9b8JkfM2E1PGzOm7bfjOfGPnPu/3ss2PPweuWEOb/xcXPeq0cseP8fsuD5v9+c5/9ec+7/u8w5/+w05ywhGBYMDAwMZ4wZWPeasQXuteDu227COWWLGWf5KksGaaI0kwoAs/GVHnUwtUwAAAAASUVORK5CYII=";

        public const string CopySingleImage =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAg0lEQVQ4je2OsQ3CUBBDM0AKxF3YhwnCHoguBcIGZSlWoGWYX/CdX5CCJkLkhJDoYsmd/eyqCmTUzijUh9REuVk5VdYY7kbhq0LdpY1RcOSuuZTn1Eal1emxNaiNLuMVznun+qkNOjrz1akSXe7flz95ASyA/wIMap0qUdnOw20W8ItGa8pJ7oWRXlgAAAAASUVORK5CYII=";

        public const string CopyAllImage =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAkElEQVQ4jWNgwAOEa34GCNf8rObJ/SyKTx1OIFLz87dQ9a/zwjU/q4nSwFPyWUy45me1SPWPEtG63/+RsXDNz88CVd8dhat/+uNzcjVE8Y9skZqfDchYuPpnhUjNj60iNT9/43NyA7rN2DDtDUB3PhzX/jpAHwNGvTCQLhCu/ukvUvPzNz7NwrW/juE0gBwAABIiOSx3yiyrAAAAAElFTkSuQmCC";

    }
}
