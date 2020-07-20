using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Helpers;

namespace H5Tweak
{
    public static class Poker
    {
        private const string EXPECTED_VERSION = "1.194.6192.2";
        private static readonly Regex versionRegex = new Regex(@"Microsoft.Halo5Forge_([0-9]+.[0-9]+.[0-9]+.[0-9]+)_x64__8wekyb3d8bbwe");

        private static Process GetProcess()
        {
            Process proc = ApplicationFinder.FromProcessName("halo5forge").FirstOrDefault();

            if (proc != null)
            {
                Match match = versionRegex.Match(proc.MainModule.FileName);
                if (!match.Success)
                {
                    throw new Exception("Unable to determine application version.");
                }

                string version = match.Groups[1].Value;
                if (version != EXPECTED_VERSION)
                {
                    throw new Exception(string.Format("H5Tweak does not support the installed version of H5Tweak. Expected={0}. Installed={1}.", EXPECTED_VERSION, version));
                }
            }

            return proc;
        }

        public static int GetFPS()
        {
            using (var m = new MemorySharp(GetProcess()))
            {
                return 1000000 / m.Read<int>((IntPtr)0x3425078);
            }
        }

        public static int GetFOV()
        {
            using (var m = new MemorySharp(GetProcess()))
            {
                return Convert.ToInt16(m[(IntPtr)0x590E210].Read<float>());
            }
        }

        public static bool HasMenuResolutionUpdated()
        {

            using (var m = new MemorySharp(GetProcess()))
            {
                var output = m.Read<int>((IntPtr)0x6210FDC) != 0;
                Console.WriteLine(output);
                return output;
            }
        }

        public static int GetResolutionWidth()
        {
            using (var m = new MemorySharp(GetProcess()))
            {
                return m.Read<int>((IntPtr)0x4857610);
            }
        }

        public static void SetResolutionWidth(int width)
        {
            using (var m = new MemorySharp(GetProcess()))
            {
                // The first 4 initalize on launch, the last 4 on menu load.
                IntPtr[] widthAddresses = { (IntPtr)0x4857610, (IntPtr)0x485761C,
                                            (IntPtr)0x4857648, (IntPtr)0x6141944,
                                            (IntPtr)0x60A7448, (IntPtr)0x60AF660,
                                            (IntPtr)0x6210FDC, (IntPtr)0x63B146C };

                foreach (IntPtr address in widthAddresses)
                {
                    m[address].Write<int>(width);
                }
            }
        }

        public static void SetResolutionHeight(int height)
        {
            using (var m = new MemorySharp(GetProcess()))
            {
                // The first 5 initalize on launch, the last 5 on menu load.
                IntPtr[] heightAddresses = { (IntPtr)0x4857614, (IntPtr)0x4857620,
                                             (IntPtr)0x485764C, (IntPtr)0x488C374,
                                             (IntPtr)0x6141948, (IntPtr)0x60A744C,
                                             (IntPtr)0x60AF664, (IntPtr)0x620BF7C,
                                             (IntPtr)0x6210FE0, (IntPtr)0x63B1470 };

                foreach (IntPtr address in heightAddresses)
                {
                    m[address].Write<int>(height);
                }
            }
        }

        public static void SetAspectRatio(float ratio)
        {
            using (var m = new MemorySharp(GetProcess()))
            {
                m[(IntPtr)0x48575F0].Write<float>(ratio);
            }
        }

        public static void SetFOV(float fov)
        {
            using (var m = new MemorySharp(GetProcess()))
            {
                m[(IntPtr)0x590E210].Write<float>(fov);
            }
        }

        public static void SetFPS(int fps)
        {
            using (var m = new MemorySharp(GetProcess()))
            {
                IntPtr[] fpsAddresses = { (IntPtr)0x3425078, (IntPtr)0x3425088, (IntPtr)0x3425098 };
                foreach (IntPtr address in fpsAddresses)
                {
                    m[address].Write<int>(fps);
                }
            }
        }
    }
}
