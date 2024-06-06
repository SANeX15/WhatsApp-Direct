using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WhatsApp_Direct
{
    internal class WASend
    {
        public static void CallWA(bool webMode,string code, string MbNo, bool msgEnabled, string message)
        {
            
            switch (msgEnabled)
            {
                case true:
                    switch (webMode)
                    {
                        case false:
                            Process.Start("whatsapp://send?phone=" + code + MbNo + "&text=" + TTU(message));
                            break;
                        case true:
                            Process.Start("http://api.whatsapp.com/send/?phone=" + code + MbNo + "&text=" + TTU(message));
                            break;
                    }
                    break;
                case false:
                    switch (webMode)
                    {
                        case false:
                            Process.Start("whatsapp://send?phone=" + code + MbNo);
                            break;
                        case true:
                            Process.Start("http://api.whatsapp.com/send/?phone=" + code + MbNo);
                            break;
                    }
                    break;
            }
        }

        private static string TTU(string url)
        {
            return HttpUtility.UrlEncode(url);
        }
    }
}
