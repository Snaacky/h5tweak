namespace H5Tweak
{
    partial class TweakUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFOV = new System.Windows.Forms.TrackBar();
            this.lblFOV = new System.Windows.Forms.Label();
            this.lblFPS = new System.Windows.Forms.Label();
            this.tbFPS = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbFOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFPS)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFOV
            // 
            this.tbFOV.Location = new System.Drawing.Point(12, 33);
            this.tbFOV.Maximum = 150;
            this.tbFOV.Name = "tbFOV";
            this.tbFOV.Size = new System.Drawing.Size(269, 45);
            this.tbFOV.TabIndex = 0;
            this.tbFOV.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblFOV
            // 
            this.lblFOV.AutoSize = true;
            this.lblFOV.Location = new System.Drawing.Point(12, 17);
            this.lblFOV.Name = "lblFOV";
            this.lblFOV.Size = new System.Drawing.Size(31, 13);
            this.lblFOV.TabIndex = 1;
            this.lblFOV.Text = "FOV:";
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(12, 81);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(30, 13);
            this.lblFPS.TabIndex = 4;
            this.lblFPS.Text = "FPS:";
            // 
            // tbFPS
            // 
            this.tbFPS.Location = new System.Drawing.Point(12, 97);
            this.tbFPS.Maximum = 300;
            this.tbFPS.Minimum = 60;
            this.tbFPS.Name = "tbFPS";
            this.tbFPS.Size = new System.Drawing.Size(269, 45);
            this.tbFPS.TabIndex = 3;
            this.tbFPS.Value = 60;
            this.tbFPS.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // TweakUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 164);
            this.Controls.Add(this.lblFPS);
            this.Controls.Add(this.tbFPS);
            this.Controls.Add(this.lblFOV);
            this.Controls.Add(this.tbFOV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TweakUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H5Tweak";
            this.Load += new System.EventHandler(this.TweakUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbFOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbFOV;
        private System.Windows.Forms.Label lblFOV;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.TrackBar tbFPS;
    }
}

