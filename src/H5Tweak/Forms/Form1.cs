using System;
using System.Windows.Forms;
using System.Linq;
using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Helpers;
using System.Diagnostics;

namespace H5Tweak
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        public int readFPS()
        {
            using (var m = new MemorySharp(ApplicationFinder.FromProcessName("halo5forge").FirstOrDefault()))
            {
                var fpsPtr = new IntPtr(0x34B8C50);
                int[] integers = m.Read<int>(fpsPtr, 1);
                int math = 1000000 / integers[0];
                return math;
            }

        }

        public int readFOV()
        {
            using (var m = new MemorySharp(ApplicationFinder.FromProcessName("halo5forge").FirstOrDefault()))
            {
                var fovPtr = new IntPtr(0x58ECF90);
                return Convert.ToInt16(m[fovPtr].Read<float>());
            }

        }

        void updateFOV(float fov)
        {
            using (var m = new MemorySharp(ApplicationFinder.FromProcessName("halo5forge").FirstOrDefault()))
            {
                var fovPtr = new IntPtr(0x58ECF90);
                m[fovPtr].Write<float>(fov);
            }

        }

        void updateFPS(int fps)
        {
            using (var m = new MemorySharp(ApplicationFinder.FromProcessName("halo5forge").FirstOrDefault()))
            {
                var fovPtr = new IntPtr(0x34B8C50);
                var fovPtr1 = new IntPtr(0x34B8C60);
                var fovPtr2 = new IntPtr(0x34B8C70);
                m[fovPtr].Write<int>(fps);
                m[fovPtr1].Write<int>(fps);
                m[fovPtr2].Write<int>(fps);
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblFOV.Text = "FOV: " + tbFOV.Value.ToString();
            updateFOV(tbFOV.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lblFPS.Text = "FPS: " + tbFPS.Value.ToString();
            int fps = 1000000 / Convert.ToInt16(tbFPS.Value);
            updateFPS(fps);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcessesByName("halo5forge");
            if (process.Length == 0)
            {
                MessageBox.Show("Unable to find running process. Terminating.", "H5Tweak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                int fov = readFOV();
                lblFOV.Text = "FOV: " + fov.ToString();
                tbFOV.Value = fov;

                int fps = readFPS();
                lblFPS.Text = "FPS: " + fps.ToString();
                tbFPS.Value = fps;
            }

        }


    }
}