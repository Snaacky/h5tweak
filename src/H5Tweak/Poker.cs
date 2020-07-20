using System;
using System.Linq;
using System.Text.RegularExpressions;
using Process.NET;
using Process.NET.Memory;

namespace H5Tweak
{
    public class Poker
    {
        private const string EXPECTED_VERSION = "1.194.6192.2";
        private static readonly Regex versionRegex = new Regex(@"Microsoft.Halo5Forge_([0-9]+.[0-9]+.[0-9]+.[0-9]+)_x64__8wekyb3d8bbwe");

        public static ProcessSharp GetProcess()
        {
            var h5forge = System.Diagnostics.Process.GetProcessesByName("halo5forge").FirstOrDefault();

            Match match = versionRegex.Match(h5forge.MainModule.FileName);
            if (!match.Success)
            {
                throw new Exception("Unable to determine application version.");
            }

            string version = match.Groups[1].Value;
            if (version != EXPECTED_VERSION)
            {
                throw new Exception(string.Format("H5Tweak does not support the installed version of H5Tweak. Expected={0}. Installed={1}.", EXPECTED_VERSION, version));
            }

            var process = new ProcessSharp(h5forge, Process.NET.Memory.MemoryType.Remote);
            process.Memory = new ExternalProcessMemory(process.Handle);
            return process;
        }

        public static int GetFPS()
        {
            using (ProcessSharp proc = GetProcess())
            {
                return 1000000 / proc.Memory.Read<int>((IntPtr)0x7FF696665078);
            }
        }

        public static int GetFOV()
        {
            using (ProcessSharp proc = GetProcess())
            {
                return Convert.ToInt16(proc.Memory.Read<float>((IntPtr)0x7FF698B4E210));
            }
        }

        public static bool HasMenuResolutionUpdated()
        {
            using (ProcessSharp proc = GetProcess())
            {
                return proc.Memory.Read<int>((IntPtr)0x7FF69944BF7C) != 0;
            }
        }

        public static int GetResolutionWidth()
        {

            using (ProcessSharp proc = GetProcess())
            {
                return proc.Memory.Read<int>((IntPtr)0x7FF697A97614);
            }
        }

        public static void SetResolutionWidth(int width)
        {
            using (ProcessSharp proc = GetProcess())
            {
                IntPtr[] widthAddresses = { (IntPtr)0x7FF697A97610, (IntPtr)0x7FF697A9761C,
                                            (IntPtr)0x7FF697A97648, (IntPtr)0x7FF699381944,
                                            (IntPtr)0x7FF6992E7448, (IntPtr)0x7FF6992EF660,
                                            (IntPtr)0x7FF699450FDC, (IntPtr)0x7FF6995F146C };

                foreach (IntPtr address in widthAddresses)
                {
                    proc.Memory.Write(address, width);
                }
            }
        }

        public static void SetResolutionHeight(int height)
        {
            using (ProcessSharp proc = GetProcess())
            {
                IntPtr[] heightAddresses = { (IntPtr)0x7FF697A97614, (IntPtr)0x7FF697A97620,
                                             (IntPtr)0x7FF697A9764C, (IntPtr)0x7FF697ACC374,
                                             (IntPtr)0x7FF699381948, (IntPtr)0x7FF6992E744C,
                                             (IntPtr)0x7FF6992EF664, (IntPtr)0x7FF699450FE0,
                                             (IntPtr)0x7FF6995F1470 };

                foreach (IntPtr address in heightAddresses)
                {
                    proc.Memory.Write<int>(address, height);
                }
            }
        }

        public static void SetAspectRatio(float ratio)
        {
            using (ProcessSharp proc = GetProcess())
            {
                proc.Memory.Write((IntPtr)0x7FF697A975F0, ratio);
            }
        }

        public static void SetFOV(float fov)
        {
            using (ProcessSharp proc = GetProcess())
            {
                proc.Memory.Write((IntPtr)0x7FF698B4E210, fov);
            }
        }

        public static void SetFPS(int fps)
        {
            using (ProcessSharp proc = GetProcess())
            {
                IntPtr[] fpsAddresses = { (IntPtr)0x7FF696665078, (IntPtr)0x7FF696665088, (IntPtr)0x7FF696665098 };
                foreach (IntPtr address in fpsAddresses)
                {
                    proc.Memory.Write(address, fps);
                }
            }
        }
    }
}
