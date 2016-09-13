using System;
using System.Windows.Forms;
using System.Linq;
using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Helpers;
using System.Diagnostics;

namespace H5Tweak
{
    public partial class TweakUI : Form
    {

        public TweakUI()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblFOV.Text = "FOV: " + tbFOV.Value.ToString();
            Poker.SetFOV(tbFOV.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lblFPS.Text = "FPS: " + tbFPS.Value.ToString();
            int fps = 1000000 / Convert.ToInt16(tbFPS.Value);
            Poker.SetFPS(fps);
        }

        private void TweakUI_Load(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcessesByName("halo5forge");
            if (process.Length == 0)
            {
                MessageBox.Show("Unable to find running process. Terminating.", "H5Tweak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                int fov = Poker.GetFOV();
                lblFOV.Text = "FOV: " + fov.ToString();
                tbFOV.Value = fov;

                int fps = Poker.GetFPS();
                lblFPS.Text = "FPS: " + fps.ToString();
                tbFPS.Value = fps;
            }
        }
    }
}