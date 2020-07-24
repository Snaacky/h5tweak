using Process.NET;
using Process.NET.Memory;
using System;
using System.Linq;

namespace H5Tweak
{
    public class Poker
    {

        public static ProcessSharp GetProcess()
        {
            var process = new ProcessSharp(System.Diagnostics.Process.GetProcessesByName("halo5forge").FirstOrDefault(), MemoryType.Remote);
            process.Memory = new ExternalProcessMemory(process.Handle);
            return process;
        }

        public static IntPtr GetModuleBase()
        {
            using (ProcessSharp proc = GetProcess())
            {
                // Once in a while, this previously returned a "successful" exception. 
                // This hopefully fixes that.
                try
                {
                    return proc["halo5forge.exe"].BaseAddress;
                } 
                catch (System.ComponentModel.Win32Exception)
                {
                    return GetModuleBase();
                }
            }
        }

        public static int GetFPS()
        {
            using (ProcessSharp proc = GetProcess())
            {
                return 1000000 / proc.Memory.Read<int>(IntPtr.Add(GetModuleBase(), 0x3425078));
            }
        }

        public static int GetFOV()
        {
            using (ProcessSharp proc = GetProcess())
            {
                return Convert.ToInt32(proc.Memory.Read<float>(IntPtr.Add(GetModuleBase(), 0x590E210)));
            }
        }

        public static bool HasFOVBeenSet()
        {
            return GetFOV() != 0;
        }

        public static void SetResolutionWidth(int width)
        {
            using (ProcessSharp proc = GetProcess())
            {
                int[] widthAddresses = {  0x4857610, 0x485761C,
                                          0x4857648, 0x6141944,
                                          0x60A7448, 0x60AF660,
                                          0x6210FDC, 0x63B146C,
                                          0x60A7448, 0x60AF660,
                                          0x4856520, 0x4857634,
                                          0x48577C4, 0x488C378,
                                          0x58FE228, 0x61B54B8,
                                          0x61D6158, 0x48B4310 };

                int[] widthAddresses2 = { 0x60A7448, 0x60AF660,
                                          0x626B868, 0x626B850,
                                          0x626B840, 0x626B8B0,
                                          0x626B958, 0x626B8C8,
                                          0x489BCB8, 0x626BA90,
                                          0x626B940, 0x626BAF0,
                                          0x626BB58, 0x626BB08,
                                          0x626BAA8, 0x48B480C,
                                          0x626BB98, 0x626BB70,
                                          0x626BB80, 0x626B828,
                                          0x489C0D0 };

                foreach (int address in widthAddresses)
                {
                    proc.Memory.Write(IntPtr.Add(GetModuleBase(), address), width);
                }

                foreach (int address in widthAddresses2) 
                {
                   proc.Memory.Write<float>(IntPtr.Add(GetModuleBase(), address), (float)Convert.ToDouble(width));
                }
            }
        }

        public static void SetResolutionHeight(int height)
        {
            using (ProcessSharp proc = GetProcess())
            {
                int[] heightAddresses = {   0x4857614, 0x4857620,
                                            0x485764C, 0x488C374,
                                            0x6141948, 0x60A744C,
                                            0x60AF664, 0x620BF7C,
                                            0x6210FE0, 0x63B1470,
                                            0x5A56D00, 0x46DF780,
                                            0x5A56D00, 0x46DF780,
                                            0x485652C, 0x4856544,
                                            0x485653C, 0x485654C,
                                            0x4856534, 0x4856524,
                                            0x485766C, 0x4856554,
                                            0x488C37C, 0x61B33E8,
                                            0x49BAE58, 0x623C4D8,
                                            0x48577C8, 0x61C5AD8,
                                            0x4857638, 0x485654C,
                                            0x4856554, 0x4857638,
                                            0x48577C8, 0x488C37C,
                                            0x49BAE58, 0x4856524,
                                            0x61B33E8, 0x623C4D8,
                                            0x4856544, 0x485652C,
                                            0x46DF780, 0x485653C,
                                            0x4856534 };

                int[] heightAddresses2 = { 0x60A744C, 0x60AF664,
                                           0x489BCBC, 0x48B4810,
                                           0x5F99CC8, 0x489C0D4,
                                           0x5F99CD4, 0x626B82C,
                                           0x626B854, 0x626B844,
                                           0x626B8B4, 0x626B95C,
                                           0x626BA94, 0x626B944,
                                           0x626BAF4, 0x626BB0C,
                                           0x626B86C, 0x626BB74,
                                           0x626BAAC, 0x626BB84,
                                           0x626BB5C, 0x626BB9C,
                                           0x626B8CC };

                foreach (int address in heightAddresses)
                {
                    proc.Memory.Write(IntPtr.Add(GetModuleBase(), address), height);
                }

                foreach (int address in heightAddresses2)
                {
                    proc.Memory.Write<float>(IntPtr.Add(GetModuleBase(), address), (float)Convert.ToDouble(height));
                }
            }
        }

        public static void SetAspectRatio(float ratio)
        {
            using (ProcessSharp proc = GetProcess())
            {
                proc.Memory.Write(IntPtr.Add(GetModuleBase(), 0x48575F0), ratio);
            }
        }

        public static void SetFOV(float fov)
        {
            using (ProcessSharp proc = GetProcess())
            {
                proc.Memory.Write(IntPtr.Add(GetModuleBase(), 0x590E210), fov);
            }
        }

        public static void SetFPS(int fps)
        {
            using (ProcessSharp proc = GetProcess())
            {
                int[] fpsAddresses = { 0x3425078, 0x3425088, 0x3425098 };
                foreach (int address in fpsAddresses)
                {
                    proc.Memory.Write(IntPtr.Add(GetModuleBase(), address), fps);
                }
            }
        }
    }
}
