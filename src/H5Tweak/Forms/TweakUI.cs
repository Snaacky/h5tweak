using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;

namespace H5Tweak
{
    public partial class TweakUI : Form
    {

        public TweakUI()
        {
            InitializeComponent();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            lblFOV.Text = "FOV: " + tbFOV.Value.ToString();
            Poker.SetFOV(tbFOV.Value);
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                rb2560.Enabled = true;
                rb3440.Enabled = true;

            }
            else
            {
                rb2560.Enabled = false;
                rb3440.Enabled = false;
            }
        }

        private void rb2560_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: Might replace this system after it's done, either c&p from below or delete.
        }

        private void rb3440_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: Find a way to launch Windows 10 apps automatically
            Process[] process = Process.GetProcessesByName("halo5forge");
            DialogResult dialogResult = MessageBox.Show("To apply the ultrawide resolution, the game must be restarted. Would you like to close the game now?", "H5Tweak", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                process[0].Kill();
                MessageBox.Show("Halo 5: Forge has been killed. Re-open the game and the resolution will be applied.");

                while (Process.GetProcessesByName("halo5forge").Length == 0)
                {
                    System.Threading.Thread.Sleep(1000);
                }


                while (!Poker.HasMenuResolutionUpdated())
                {
                    Poker.SetResolutionWidth(3440);
                    Poker.SetResolutionHeight(1440);
                    Poker.SetAspectRatio(2.33f);
                }

            }

            MessageBox.Show("done");

        }

    }
}