using System;
using System.Diagnostics;
using System.Linq;

using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Helpers;

namespace H5Tweak
{
    public static class Poker
    {
        private static Process getProcess()
        {
            return ApplicationFinder.FromProcessName("halo5forge").FirstOrDefault();
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
