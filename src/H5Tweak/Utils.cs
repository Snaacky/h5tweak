using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace H5Tweak
{
    public class Utils
    {

        private const string EXPECTED_VERSION = "1.194.6192.2";
        private static readonly Regex versionRegex = new Regex(@"Microsoft.Halo5Forge_([0-9]+.[0-9]+.[0-9]+.[0-9]+)_x64__8wekyb3d8bbwe");
        void CheckRunningVersion()
        {
            /* Match match = versionRegex.Match(h5forge.MainModule.FileName);
            if (!match.Success)
            {
                throw new Exception("Unable to determine application version.");
            }

            string version = match.Groups[1].Value;
            if (version != EXPECTED_VERSION)
            {
                throw new Exception(string.Format("H5Tweak does not support the installed version of H5Tweak. Expected={0}. Installed={1}.", EXPECTED_VERSION, version));
            }*/ 
        }

        public static bool IsGameRunning()
        {
            var process = System.Diagnostics.Process.GetProcessesByName("halo5forge");
            return process.Length > 0;
        }

    }
}
