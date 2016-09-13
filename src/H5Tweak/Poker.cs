using System;
using System.Diagnostics;
using System.Linq;

using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Helpers;
using System.Text.RegularExpressions;

namespace H5Tweak
{
    public static class Poker
    {
        const string EXPECTED_VERSION = "1.114.4592.2";
        static Regex versionRegex = new Regex(@"Microsoft.Halo5Forge_([0-9]+.[0-9]+.[0-9]+.[0-9]+)_x64__8wekyb3d8bbwe");

        private static Process getProcess()
        {
            Process proc = ApplicationFinder.FromProcessName("halo5forge").FirstOrDefault();

            Match match = versionRegex.Match(proc.MainModule.FileName);
            if (!match.Success)
            {
                throw new Exception("Unable to determine application version.");
            }

            String version = match.Groups[1].Value;
            if (version != EXPECTED_VERSION)
            {
                throw new Exception(String.Format("Wrong version. Expected={0}. Actual={1}.", EXPECTED_VERSION, version));
            }

            return proc;
        }

        public static int GetFPS()
        {
            using (var m = new MemorySharp(getProcess()))
            {
                var fpsPtr = new IntPtr(0x34B8C50);
                int[] integers = m.Read<int>(fpsPtr, 1);
                int math = 1000000 / integers[0];
                return math;
            }
        }

        public static int GetFOV()
        {
            using (var m = new MemorySharp(getProcess()))
            {
                var fovPtr = new IntPtr(0x58ECF90);
                return Convert.ToInt16(m[fovPtr].Read<float>());
            }
        }

        public static void SetFOV(float fov)
        {
            using (var m = new MemorySharp(getProcess()))
            {
                var fovPtr = new IntPtr(0x58ECF90);
                m[fovPtr].Write<float>(fov);
            }
        }

        public static void SetFPS(int fps)
        {
            using (var m = new MemorySharp(getProcess()))
            {
                var fovPtr = new IntPtr(0x34B8C50);
                var fovPtr1 = new IntPtr(0x34B8C60);
                var fovPtr2 = new IntPtr(0x34B8C70);
                m[fovPtr].Write<int>(fps);
                m[fovPtr1].Write<int>(fps);
                m[fovPtr2].Write<int>(fps);
            }
        }
    }
}
