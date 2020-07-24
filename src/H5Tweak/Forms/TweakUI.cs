using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace H5Tweak
{
    public partial class TweakUI : Form
    {
        public TweakUI()
        {
            InitializeComponent();
        }

        private void TweakUI_Load(object sender, EventArgs e)
        {
            Thread IsGameRunningThread = new Thread(IsGameRunningListener);
            IsGameRunningThread.Start();
        }

        private void IsGameRunningListener()
        {
             // This thread is started on form load and runs infinitely.
             // It will check for an active Halo 5 Forge process.
             // If the game is running and the UI is disabled, it will enable the UI and call to populate the inputs.
             // If the game is not running and the UI is enabled, it will disable the UI.
            while (true)
            {
                if (Utils.IsGameRunning())
                {
                    if (!gbSettings.Enabled && !gbCustomRes.Enabled )
                    {
                        gbSettings.Invoke(new MethodInvoker(delegate { gbSettings.Enabled = true; }));
                        gbCustomRes.Invoke(new MethodInvoker(delegate { gbCustomRes.Enabled = true; }));
                        tsslIsGameRunning.Text = "Halo 5: Forge is running";
                        PopulateInputFields();
                    }
                }

                if (!Utils.IsGameRunning())
                {
                    if (gbSettings.Enabled && gbCustomRes.Enabled)
                    {
                        gbSettings.Invoke(new MethodInvoker(delegate { gbSettings.Enabled = false; }));
                        gbCustomRes.Invoke(new MethodInvoker(delegate { gbCustomRes.Enabled = false; }));
                        tsslIsGameRunning.Text = "Halo 5: Forge is not running";
                    }
                }

                Thread.Sleep(1000);
            }
        }

        private void PopulateInputFields()
        {
            int fov = Poker.GetFOV();
            lblFOV.Invoke(new MethodInvoker(delegate { if (fov != 0) { lblFOV.Text = "FOV: " + fov.ToString(); } }));
            tbFOV.Invoke(new MethodInvoker(delegate { if (fov != 0) { tbFOV.Value = fov; } }));

            int fps = Poker.GetFPS();
            lblFPS.Invoke(new MethodInvoker(delegate { if (fps != 0) { lblFPS.Text = "FPS: " + fps.ToString(); } }));
            tbFPS.Invoke(new MethodInvoker(delegate { tbFPS.Value = fps; }));

            // Disabled for testing. Reset these to automatically grab res w/h
            // txtWidth.Invoke(new MethodInvoker(delegate { txtWidth.Text = Screen.PrimaryScreen.Bounds.Width.ToString(); }));
            // txtHeight.Invoke(new MethodInvoker(delegate { txtHeight.Text = Screen.PrimaryScreen.Bounds.Height.ToString(); }));
        }

        private void tbFOV_Scroll(object sender, EventArgs e)
        {
            lblFOV.Text = "FOV: " + tbFOV.Value.ToString();
            Poker.SetFOV(tbFOV.Value);
        }

        private void tbFPS_Scroll(object sender, EventArgs e)
        {
            lblFPS.Text = "FPS: " + tbFPS.Value.ToString();
            Poker.SetFPS(1000000 / Convert.ToInt16(tbFPS.Value));
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWidth.Text) | string.IsNullOrEmpty(txtHeight.Text) | cbAspectRatio.Text == null)
            {
                MessageBox.Show("Width, height, and aspect ratio cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("To apply the ultrawide resolution, the game must be restarted. Would you like to close the game now?", "H5Tweak", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process h5 = System.Diagnostics.Process.GetProcessesByName("halo5forge").FirstOrDefault();
                h5.Kill();
                h5.WaitForExit();

                h5.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                h5.StartInfo.FileName = "explorer.exe";
                h5.StartInfo.Arguments = @"shell:appsFolder\Microsoft.Halo5Forge_8wekyb3d8bbwe!Ausar";
                h5.Start();

                while (!Utils.IsGameRunning())
                {
                    Thread.Sleep(1000);
                }

                Console.WriteLine(Poker.HasFOVBeenSet());
                while (!Poker.HasFOVBeenSet())
                {
                    Console.WriteLine(Poker.HasFOVBeenSet());
                    Poker.SetResolutionWidth(Convert.ToInt16(txtWidth.Text));
                    Poker.SetResolutionHeight(Convert.ToInt16(txtHeight.Text));
                    switch (cbAspectRatio.Text)
                    {
                        case "16:9":
                            Poker.SetAspectRatio(1.77f);
                            break;
                        case "21:9":
                            Poker.SetAspectRatio(2.33f);
                            break;
                        case "4:3":
                            Poker.SetAspectRatio(1.33f);
                            break;
                        case "5:4":
                            Poker.SetAspectRatio(1.25f);
                            break;
                    }
                    Thread.Sleep(100);
                }
            }
        }
    }
}