using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace H5Tweak
{
    public static class Updater
    {
        public static bool CheckUpdate()
        {
            WebClient client = new WebClient();
            string version = client.DownloadString("https://snaacky.github.io/H5Tweak/version.txt");

            if (version == Assembly.GetExecutingAssembly().GetName().Version.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
