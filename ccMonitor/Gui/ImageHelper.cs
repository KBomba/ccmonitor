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

        // https://www.iconfinder.com/icons/10513/green_refresh_icon
        public const string GreenReloadButton =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAACNElEQVQ4jWNgwA2Y8cjhB73TK5KqGnNyydHLOH1xTe2JB7P/zVxVu6ltSn5ey5TcvMb+zOys0mg3FRUVdnyaWRZtbJp57P6M/4fuTv6/73bf/123uv5vu9H6f9O1hv/rrtb8n7Ov4G5ibqg9Vt0puTG2+29M+r7/zoT/u291/9t+o+3/5utN/9Zfrf2/+nL5v6UXiv7PP5v9b+qh5E8RcX6GWA1Jz4v1Wn+u6f2W683/N1yt/bfqUuXfpReK/y48m/Nv9un0/1NPJP6fcDT6f9nM4G0MDAxMWA2JTggyXXC45ElhQ0KHi4uLkouLi5Kvr7t24/KoI92HQ/+1HQj4X7PZ66ONjY0gzsAIDfVTScwI90ERS/TXSigITIrND0iOzfVNMDY25oJLJmeE68xZ2dA3c2Vd3/TlVX1RUUHyyJpbZ2fVh4b6yuG0MTohyAIe+nf6/09bXb4ltzzGO70w1CO9NNRj+o68k9P3Zt+PTvDXxWqAsTED67pjbXd23+r+t/1mO0roL7tQ9H/B2ex/s06l/e/dE/s6JiPAAashGfmx7hsvN3zfeK3u/5orVf+XXyz5v/Bc3v85pzP+T4OGfteh0P+16/1fOPs5i2M1JCkzymXKpryLi8/l/Zt7JvP/9JNJ/yYdi/3fczjsX9uBgP+Va31eRiYEeuAMCwYGBgZtbW02X1937bA4f5fweF+38PgAt9JFvieKl3jdDQr3NcWrGRdIqfOu9gn2USVLMxQw4pIAAKWaEYbnjqbwAAAAAElFTkSuQmCC";

        // https://www.iconfinder.com/icons/10514/red_refresh_icon
        public const string RedReloadButton =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAACJElEQVQ4jWNgwA2Y8cjhBwsL/JI60oNyydHLuL7Er/Zrr/u/nSUemxZku+UtyHDOm5vmkF0T7uSmoqLCjk8zy4Eq75nful3+f223//+1xfL/10aT/19q9f9/qdL8/7lc5f/NfI27haGu9lh1F0Y4275rdfj+tdX6/9dGk39f6gz+f6nS+velQvX/5xLFfx+KFP+/zVf8dy9b/VNysKchVkNKo3y8XtQYv/9So/P/c7nav4+lSn/fFyv+fVug+O9VvvL/57kq/59kq/5fnWi+jYGBgQmrIalBHqZ3CzWfdMc5dbi4uCi5uNgo+bq7a+9NMTjyMEP137109f9nk7U/2tjYCOIMjBg/d5X8cC8fZLHEUE+tigi3pLIIt+TSCI8EY2NjLrhkXqCDztZy376tpV59W4s9+qKCvOSRNa9Os6oP9XWRw2ljiq+Dxbdu1/9fO+z/f22x+r+nwG5LY4Sjd02gqUdDqKXHxRytk9dzNe6n+bvoYjXAmIGB9XaN/Z2vTab/vtYZQkNfDSX0X+Up/7+RqfG6IMTDAash5VEe7m+rdb9/qVT//7lM+f/HYsX/7wqV/iOH/oNMtf8nknVe+Dk7i2M1pDDM3eV0tu7FdwWK/17nK/9/kaP872m26n9Y6B9N0nuZHOrngTMsGBgYGLS1tdl83R21k4LdXZICXN2SQjzddiYandiVYHQ3OsjXFK9mXKA70qE62MdHlSzNUMCISwIAPn7zm90FdXsAAAAASUVORK5CYII=";

        // https://www.iconfinder.com/icons/10515/refresh_yellow_icon
        public const string YellowReloadButton =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAACR0lEQVQ4jWNgwA2Y8cjhB0umFyR1NabnkqOXcdvSotp/Dxr/7V+ZsmnppOC85ZN88xb1Omc3FNq5qaiosOPU6cDAwHJ0Y+HM//dK//+/nfL//43g//+vOv//f8no///ziv//nxH4/2Sb0N3STEd7rAaU5obY/rie/v3/zYj//665/ft/2ez/v/Mq//6fEfn/7yT7v3/H2P//Pczx7+N2/k8ZcS6G2A3J8/f6cNL2/f8LWv//npH49/ck998/x9j+/j3M/u/vAa7/f/by/P+zi+//nkma2xgYGJiwGpKV4Gz6Yrf4k/4aiw4XFxclFxcbpWBfd+3z8+WP/NnB/+/3FqH/r1dIfLSxsRHEGR4xoe4qRRnOPshi6dGeWg3Zjkl1OQ7JtVlOCcbGxlxwybyMQJ3dq8v7dq/M6du9NLEvOSpIHlnzxqlG9XGhLnI4bcxM8LX4f6/8///baf//3wj9f2Sl+5bWclvvhjwjj+ZCPY/b68VOPtkidD8twUUXqwHGxgysj49E3Pl3zf3f/8sW//9dUPv3/6zY/38nOf79O8b2HxaIrzcJvS7JcHDAakh5vrf7j9M63/+flfr/7xTP/3/H2f7/O8Lx/+9Brv9/9kFC//d2gf8Pl0m/8HN2FsdqSGGmi8uV1VIX/x5h//f3EOf/v/u4/v3Zzfv/zw6+f7+3Cv6/v0jmZXqMlwfOsGBgYGDQ1tZmC/Z11E6Nc3FJi3ZyS4t3dbswU+nE5dnKd6PDfU3xasYFZlZYVAf7+KiSpRkKGHFJAAAHKhF2ozQLQwAAAABJRU5ErkJggg==";

        // https://www.iconfinder.com/icons/27856/exit_out_sign_out_icon
        public const string Exit =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAB7klEQVQ4jaXSz0uTcRwH8PfBQC8d0rJDWWtarNTlTJsZJmU72DIjYVmyqT0+ytLHJ7f2YKSM9QMjL0EMnovtICpexBxMYrnpQOZCHUhBBFG3TvonvD3MorXnoaAPvI/vF1++nw/wv/NBsfBfowtsjtsZD1z9mgfY8gAbACuASgClAA4DKNAFUr4qxr3V/PFWYWJCjukB9vEDhIpc5KVP5JJs5uexS9yOvWCwyxzLAV5jEiq0gaT3LKNSJT8FrPwe6mJvbRGzgCcYhAo+Tz/lL+T3rA6Z+a6/glv+8/wWErKBR1CggoFNP72pB5ST/Xy8rjCQHqW01kd4QCTkCkbcZ5geOccvakc2oIL+jVHaFi+zPlzLpsUG2qM2OpZbKaXEDLA8UM6waOL6sIUfX7VpvuBu3MEb0WY6E7cprroopUSOpB9mgCX3ac7dO8Wk18yg7w4VV4vmH8hr9zOFPzPmETjrLOXKYDmnpUZ2N9dRdwsejS1EhDJOtRv43m3iilLPnprCXAAoaHq2XxtY6DQy1FbCiFDGqGSh21qkCSx0GrUvEQAmbh7ZmncaGBZMHKg7yL2yCYARQMkesk8XCF4rPjHjOLYz7zJy6OIhArgCoAHABQAnAeTrln/Om1tHW2fbj3O4sZgAHACuAzD8rbcLPDobNCiQek4AAAAASUVORK5CYII=";
            
        // https://www.iconfinder.com/icons/315158/clipboard_upload_icon#size=16
        public const string CopySingle =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAxElEQVQ4jeWSMQrCUAyGewBBbNKbeA2xR3B0cXLSl5Ru9TBuLo6uouAVPIEgIr7/vaEOdniCWit0MvAPCfxfQpIoajNY3I4FngyGjYxdc+2zIE8yX8bGHVjdJhY7rTWSIGWBJ8EsyXwZigVnUhQsbvth5EdXFrtiQR6KFAUrTknmy1pAnf4JEKtdkyAlhW0MqMwLmt9GbOw4hHwJwLK6f06KI6vb/7SDV7X2ACQwdQBWuLeAzuSSkMA8vbG6TZj3jB2Enjuaekjd2lJm7QAAAABJRU5ErkJggg==";

        // https://www.iconfinder.com/icons/315160/clipboard_text_icon
        public const string CopyAll =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAkElEQVQ4jWNgwAOEa34GCNf8rObJ/SyKTx1OIFLz87dQ9a/zwjU/q4nSwFPyWUy45me1SPWPEtG63/+RsXDNz88CVd8dhat/+uNzcjVE8Y9skZqfDchYuPpnhUjNj60iNT9/43NyA7rN2DDtDUB3PhzX/jpAHwNGvTCQLhCu/ukvUvPzNz7NwrW/juE0gBwAABIiOSx3yiyrAAAAAElFTkSuQmCC";

        // https://www.iconfinder.com/icons/173170/camera_icon
        public const string SnapShot =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAB8UlEQVQ4jc2TsWsTcRSAL4h/hYv/QYeApZCkyftd7yQZQsItt9wShEATAoGAklToVIdA1LPodFrr2iGDWKLhPEUczXU6Cg1UMqS0U1ZpPxeveija0Qff9r1vek/T/vsprK5umqb50bbtL4ZhfCrk88/+KCqlsrrIXRG5k06nr2uapq2srNyQQuFbr9sF4OFggBIhm83eSixnMpkllc9/VSIoEXSRp7rIA6XUvhLBWFvDtm1umyZKBKXU50wms3QZMAxjtL6+TqPR+Cftdpter4dhGKPLgGmafrPZJKbT6eD7PrPZjNlshu/7dDodms0m3W6Xfr+PaZp+IlCv16nX67RaLebzOQfRERsvP3Dv+XsOoiPm8zmtVovY+y1Qq9Wo1WoMh0MOp8c4r6ZYbyD1BG5uhhxOjxkOh8ReIqDruu84Do7jEEUR91+8o/oatJ0fuNDz3hJFEbGn63oyYNs2tm0ThiFbuyOuPb5A80DzIPXogq3dEWEYEnuJgFLKtywLy7LwPI+T0zOWN/ZJDc5JDc5Z3tjn5PQMz/OIPaVUMlAulymXy1QqFSaTCYvFgu29gO29gMViwWQyoVKpEHuJgIiMi8UiMaVSCdd1CYKAIAhwXZdSqcSvjoiMf957LlcVkbFSyr8KIjIu5HLVv/3Qlec7Al94IYG5PTkAAAAASUVORK5CYII=";

        // https://www.iconfinder.com/icons/173091/save_icon
        public const string SaveDisk =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAACLElEQVQ4jZXTP2gTcRjG8R+dDjoIosVSwUGHpHRxKSSFcP6SplhKKeItBYdEtA4RJEHXOlhKTXL22jSNjanbLWeG0DmxaiyX0nA4yA1eh9DhaEgIHtyVJiWPw/nnaoPUF77rZ3l4CSGEBAKBCyzLuiil3nGfb/Lvbvl8d8Yp5fwsO0Mp9bIse4X8Os/ExMWrj9996X9ew6NXBdRqtVNp+/uIRCLwU4qFhQWEX0q4HHt/cPPuk9s2MDU7yrzQQXhgLltGt9v9XbvdhmlZiMVi8FMKQRAQSpVAeODS0+0DL528ZgOLOohwGuh0OrAsC98NA9Fo9A+QLoEIALOowzM1O2oDSzrIKjD3xgY6Jyewjo5gGAaazSY+lcsoFApQFMUGVgFmyQnEdZA14EZSxcPsRzzIfsD919sIZ0oIrTsr4nr8K8gawMSdQEIHWcd/xSScAK+jL32M/njtXPWlj8HwTkDQMRzfhaZpZ2Y8M6umYTi+C0ZwAis63MkKTNNEPp/H283NnuXzeZimCXeyAmbFCaRswDAMSJKEXC7XM0mSYBiGDaScQFqHm6+g1WpBURTIstwzRVHQarXg5itg0k4go8O1LKPRaGCvWsXnnZ2e7VWraDQacC3LYDJOYEOHS5BxWK9DFEVkMpmeiaKIw3odLkEGs/ET8AaDA4PzW+pIoghVVfFN0/6ZqqoYSRQxOL+leoPBAfuhOG5ojAtPz9wLPTtPY1x42sNxQ4QQ8gPwYXwpfZC68AAAAABJRU5ErkJggg==";

        // https://www.iconfinder.com/icons/4000/jabber_raw_icon
        public const string Raw = 
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAACNklEQVQ4je1S30tTARg93av3uukyrRkss6n0y4ZCzEvRD81QglC2lcmCCPdQRkovivWgjsB6uG3J7NeDuRk92EvrYSBRkYX1oHIzkQ2hCGujoQlBZRqs00M2lCD8AzrwPXx85zt8fOcA/7EUBTKEpspsk99hzPNvTNN3AjgAIHNxbsqUpPOOHPPLMxu2h6uycx8CMAMAtunXBC4XllKra2Ssu4+vdh/laKmN/ZYKuvN3stlc/N5Xe+Jn7GaAY/vqqCl2jpTaaE7LaAeAIs/mXdQUOzXFzqlLN/gt8obh2ka+LnPyQ0snZ7t7+dbVkuRoip2DlnJuSRHc0AlC0wtrDTXFzrG9xxixneZCNM7E/AITsY/88mSIUe9tRq/2MuoL8F2bl08tZezSSzQLcEMxrPPGL3Zx4fEzMhwh43GSZOL7PKO+Pk66Whl2nuOErYHjh+oZ2mqlRyfyeAp+ACjDEVOhf25ikrMDg5zq6OLkyWbO3A3y04NHy04etlbzzvpcqjLoSkFCBhoAAA5jnn8pUVPsnL5yi9P9oWT/vPggr6/OoCqDh0V8BuBMelehN/hHFn/wp+buhxjvucdRaw2D5h306kRekMCiVRgGULLM/E0C1J61Rg6VVCYFxqvrGcy30JeRRlUGz6aCWUA3APGv9OQCblUGVRn06kReM6TToxOpymCHBJYLmEkFXP9K4J4qEV/bpN8iqgy2SOB+AbF0oBWAYSUxzkoFThUIcOcA7QCqAcgrWfwF058kRzCBDTYAAAAASUVORK5CYII=";

        // https://www.iconfinder.com/icons/105249/about_help_query_question_support_icon
        public const string Readme =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAADDUlEQVQ4jYWSXUyTdxTG/7wURnR+kHHBkDCWbSZe6CR4MdmiJkuWuQRjlmUXZJtE4yao4VNdZKbFBWk7kDmTMSMizIwtMdGA4gcIaCsRCo6AmQjabG3B9n3/b9+KgoKQ/nbRLBU12ZOcu/P8znNyjhDzZFESSgffXFB8c6eSd92u5DsrY7+58oXIPbtU/J8WlfQnZVaPNBU2j89VOkNYnQbFrZINtR6UgptTpjzn92LjhVdeak6y3EnZ2Hh/tPy6QcUNA2tPiGpXiJq+B/wyMEFd/wRratwsLnG5RM75xOf9Me8e+efM3qtByhw6mxt9+B/OAjA9F6b3/hN+7H9Ay8gUnzb4SN7n6hO5JxOi9m+HEj87rc4WdUreP+ZhWJ1mejZMy91JPj/lY+LJHHeNp9h7Q7S7p9h0wkvynu6qKKD4Vlb27/5wfrvGujoPP3UbnBl5xN6rOqWdks0NPgDOjk5i7w3x658TZNhuz4rci+kRQNHQ+nUNOtsuqXx9WSWvTWPXFY2CDklxp+TDEx4AhrQZrD0Gp+9M8tExD4t2OyMp4ktvrUqt0vmgUWXLhQBbLwbYfkllR5vKpqYxmm8/AuCa9zH7HTrfOYLsa1VZUOi6J4RFESL/r1dTbf6ZeItGxnGVnHN+vmoNkH3Khzf0FIARY4ZDNwwKOyQlXZKDXTpKwUBYfHl5oRBCxKRbvdfiLJI4iyTJppHVECC7PhK9wzNFmUOPrteuUdkdIrZoELG1LUUIIUTigeGcZLuOyRyBxFkkOb+NA/BJk86aOpX36lWyTqqsrdfY1mzMSyDEhi5Tmm1sIL5cEmuWmMySj+vGONRpsKQiCv2v0qsCKLt7BoUQMdFz7nG/8/bhQDCuXKKYJeVtEoDMWuMFQFqlh9gdju0vvHTiQffKlUf8vrTDQZZXj1PYovNGtY5ijkBNZkmKXbKwqK91/vRnVdKftKLG27T6Z41VtUHSa3Res+osrpAs+0GGXy8bPC5yuxJebn5GSw4MZ6ZWuM0ZR8f/yDgaaH7L/rdt6f7R1c/3/QtbzhawaeJimQAAAABJRU5ErkJggg==";

        // https://www.iconfinder.com/icons/105259/about_faq_help_info_information_question_sign_support_icon
        public const string About =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAC50lEQVQ4jYWSW0jTYRjGP+c00TQlL8xEjOwiQnHoRUmQ3RRFREiQiZIkVlri+UAeNjVxmydCSETTjBBLU1bpclpTp6lTE7U8rEao2fY/bekUFA9PF0PnCXrgu3uf3/s8vB8huyTi2SWPnrBPHH7Ii+6R8mJUBdb3O8JIRLMz+Z8ck4Zc/Yun6+Jl8+sFKiPEKgMSWxgElc+AFze8zI9W5ZErrYcONLuKptyv1v7R5PQYkN9ngLjfiDgFi/KRBVSMLKBqaAEBpVo4JanVJPSDy16/1eXaeU1qJ4eMbhbZKg4hjRQWVzawuLKBJs0SitVGvJteRvCLObilqQdJRI2dxZ4+5nKzgVpL+MwgWckgrZPFrUYKsm+LoExrqJ8wQdxvgGTAiHbtMq4/n4VbSm+RBZA4HhjSRCOmnUZsB434TwySlAxuN1EIbaKQqeIg6uHw5IsB0gEjXn5dgEAysUYi5F5mQMLYhRv1NCI/UrjXRiFKTiG8mQYArKxvonHahPQuFpkqFsIeDg1TS7hUMQPHWJU5hW3yuK9HEYvztRTutOpxV65H8Gs9tiT7sYTtel0sMrs5pLVQsI9X/yRExCMk5vthD4lu1VZEQ1BJIfS9DhdrZ7cBb6dN++rlKlnw4kY2SXibAyGEWHmJZ7tsRAxsRAxcJTS8Sy2AN1MmRMrN9aIVNB610yjoNcI6YRTkrsKdEEKIS9ZkqJuUBV9ohvAz5rYBxX0mBFRROFtNIbCGwrlqGpEyw64EhAQp+Z6S3yO2OQyss/U4U2wBpCuWsJVu63kV6cGL7R8lhFhZzpmiPeVdoudshToUdhqhYVYBAK2aVVx79XcXwLNgBtYPuqP2fWmXXK2Pz1PdnGcJB6c8HQRlOqTKDQhrNAP4QgbuUgYOCYMtu7fvVNKQ6+nS2Tq/ZzR8yzl4lbI4KmbhlM/geCGzeSxjtJJEKO0ONu/QkaxJf498rVBQNl8vKNPLTkp/SZwfa/z2zv0DNF4dLms9sh0AAAAASUVORK5CYII=";

        // https://www.iconfinder.com/icons/17930/display_card_graphic_graphic_card_hardware_vga_video_card_icon
        public const string Gpu =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAACWElEQVQ4jc3SS0jTAQDH8T+kMnFZoIEeSsU8iFhhKQ7S+cLE3Apfqcv5LnWmJvM1dc5H5oJ8smZkYg/TkA5uoWbZdNLMHhJlHgq69CIkUsMKSb7duwTWoe/99zt9BOF/6PhfrZu1TSu2+fneTR+oTqj6Oif7SbiSg9KsRT1joNTaRoGljbJpI/n3z3Pa2kmlzUDhhJ78e3o000ZqpnuI6FQiWCxT3wFgHeu8nhi3YKZutbO0PM4p30N8XrPyyNRJvHsIS6tzvH9npmC3gqGBEry00QiTE3d/rq/BGj8o70/BThDIL5cz+ELPDrGYsY99nGnJRiTY02gqoaBdxlbBkWNFAbgWByFo63S3Wf7Ey1c3kF1toOPZKFUPrqG8086F11aSxs8RNVxJWF8pgsoPkTqUhMuVuBSH4KTwRRCJRAovR3vkMjFp6iMU9zdyc6Cebl0i+wwplIfuIV0ZiEdDAofzwzlaGElYay5uhRKcUn0QTmZmtGsMZoymHuK7M9mpjsFZuR8HmTd2qd74ZEXgnB6AR60cWY6UoGR/AnSpuOQF4pDoifDkoW09chbE16GhZC+xtXLCmjOIasnFvyyJbdlxiNKjEKWF46mIZXu8BL/yDHapYnDNPYAwYxn56qjdYEvhCrFN/kiaoglvTsOvJpmsoXrGPgzR/fQiXfM9dCz00jrXzeibQYqHdbjmSTaE0vQ4k9r0FqEO4+9G3JM8F74tFrE4lsJzcyo2s4LZkTS+PM4lriJ49Y/IjBopXZpQzlYfpKVCSmO1FG2VlEv1IegrJWxa7z/tFwXWYEiNc/W7AAAAAElFTkSuQmCC";

        // https://www.iconfinder.com/icons/24176/nvidia_icon
        public const string Nvidia =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAACxklEQVQ4jc2TXUhTARTHz4tCDxb4EFJIUza3u7t77zbb5tx2dX4uRedwu3Npko78CEoDoUgohcq+BFETDWemaYW4zJIwK0SxNFFRLEqnzm+lQWAf+FA7PShiPUYP/eA8/n8czuEP8F/CsmGEjYvhOC6G4zj99rCc2RphMVsjLCaz1mIyay0KBRX8W1AoFPpJpdKUIwbW+eB+ofvN6zPe9dXTuL6Sg4vL2ehaPIbv5tNw1J2Kg7OpmJHF5gIAAEmSvgzDlDIM85miqAk2MnSw4lbUK0uasqa4OKVpZCxrc/mTFV1rKTixkohDS3E4sGjAzJwtgQ/DME6aptdomi6QSCQNcjk9XlzCOlqexH6taIhwGRJU55rbzDOTqyk4tBSHvQuR+HIhGjNyNLkglUpzKIrapGn6JEEQHrFY3Meysq68U+GXQ0NpVWWr7nttp3ZTJqPTGtqNG70Lenzm1mCXm8UMuzoXaJouIEnyG0VRZSKR6ItQKDyQeSLsbO/7WG/xTfX0nefan/YCRXPpDYOzfzbZ+2g4HjvmwtA5q94S8Pn8vSKRaIYgiKckSV4iCGJaq2MGrtXpRvKLVO3Wo7qqpk7jZPeY6UfheX2dTi+Pv1If6elwa9BmV+4cUcnn8z0CgaCHYRhTQpK6tcVpc3X1p290D1m9VY0Jw0kmlTHVprSVNbCjjeNKb+O0FG32w7k7LyQI4pBAIHDweDwPw5BL9vzYcqNJezXRqL5QUh5bW90RtdY2Fe6tn5Jg5Qch1nwk0LpbsI2vv79/YPpxraP7bZr3xYQZ+9zJ2LMYjY/nNfhwToF3Z6R42yVGh4tELluWtzu8BwAOAgAVGBiQFa4LqVSq+fVyZdA9mYLXIlfzHApNcLVKL7iujQm5GJUoKhIzfNmfG/gAgB8A7AcAHgAIAYAEAAkAiAAgCAACAGAfAPj+TU3+Pb8AdOgcR9lwhkYAAAAASUVORK5CYII=";
    }
}
