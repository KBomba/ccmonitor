using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace ccMonitor.Gui
{
    static class ImageHelper
    {
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
