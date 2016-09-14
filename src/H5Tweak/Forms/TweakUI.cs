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

        bool tbFPSMoved = false;
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (tbFPSMoved == false)
            {
                MessageBox.Show("Halo 5: Forge has its physics tied to its FPS. This function may cause instablity and other issues in game.", "H5Tweak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbFPSMoved = true;
            }
            else
            {
                lblFPS.Text = "FPS: " + tbFPS.Value.ToString();
                int fps = 1000000 / Convert.ToInt16(tbFPS.Value);
                Poker.SetFPS(fps);
            }
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
            MessageBox.Show("This feature is experimental. Please report any issues on the GitHub issue tracker.", "H5Tweak", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (checkBox1.Checked == true)
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
            // TODO: Find a way to launch Windows 10 apps automatically, sorry for manual solution!
            Process[] process = Process.GetProcessesByName("halo5forge");
            DialogResult dialogResult = MessageBox.Show("To apply the ultrawide resolution, the game must be restarted. Would you like to close the game now?", "H5Tweak", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                process[0].Kill();
                MessageBox.Show("Halo 5: Forge has been killed. Re-open the game and the resolution will be applied.", "H5Tweak");
                process = Process.GetProcessesByName("halo5forge");
                while (process.Length == 0)
                {
                   process = Process.GetProcessesByName("halo5forge");
                   System.Threading.Thread.Sleep(1000);
                }

                for (int i = 1; i < 20; i++)
                {
                    Poker.SetResolutionWidth(2560);
                    Poker.SetAspectRatio(2.37f);
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        private void rb3440_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: Find a way to launch Windows 10 apps automatically, sorry for manual solution!
            Process[] process = Process.GetProcessesByName("halo5forge");
            DialogResult dialogResult = MessageBox.Show("To apply the ultrawide resolution, the game must be restarted. Would you like to close the game now?", "H5Tweak", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                process[0].Kill();
                MessageBox.Show("Halo 5: Forge has been killed. Re-open the game and the resolution will be applied.");
                process = Process.GetProcessesByName("halo5forge");
                while (process.Length == 0)
                {
                    process = Process.GetProcessesByName("halo5forge");
                    System.Threading.Thread.Sleep(1000);
                }

                for (int i = 1; i < 20; i++)
                {
                    Poker.SetResolutionWidth(3440);
                    Poker.SetAspectRatio(2.37f);
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}