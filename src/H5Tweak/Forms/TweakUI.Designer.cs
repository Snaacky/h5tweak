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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TweakUI));
            this.tbFOV = new System.Windows.Forms.TrackBar();
            this.lblFOV = new System.Windows.Forms.Label();
            this.lblFPS = new System.Windows.Forms.Label();
            this.tbFPS = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb3440 = new System.Windows.Forms.RadioButton();
            this.rb2560 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbFOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFPS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFOV
            // 
            this.tbFOV.Location = new System.Drawing.Point(6, 32);
            this.tbFOV.Maximum = 150;
            this.tbFOV.Name = "tbFOV";
            this.tbFOV.Size = new System.Drawing.Size(269, 45);
            this.tbFOV.TabIndex = 0;
            this.tbFOV.Value = 78;
            this.tbFOV.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblFOV
            // 
            this.lblFOV.AutoSize = true;
            this.lblFOV.Location = new System.Drawing.Point(6, 16);
            this.lblFOV.Name = "lblFOV";
            this.lblFOV.Size = new System.Drawing.Size(32, 13);
            this.lblFOV.TabIndex = 1;
            this.lblFOV.Text = "FOV:";
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(6, 80);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(28, 13);
            this.lblFPS.TabIndex = 4;
            this.lblFPS.Text = "FPS:";
            // 
            // tbFPS
            // 
            this.tbFPS.Location = new System.Drawing.Point(6, 96);
            this.tbFPS.Maximum = 300;
            this.tbFPS.Name = "tbFPS";
            this.tbFPS.Size = new System.Drawing.Size(269, 45);
            this.tbFPS.TabIndex = 3;
            this.tbFPS.Value = 60;
            this.tbFPS.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFPS);
            this.groupBox1.Controls.Add(this.lblFPS);
            this.groupBox1.Controls.Add(this.tbFOV);
            this.groupBox1.Controls.Add(this.lblFOV);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 144);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Settings ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.rb3440);
            this.groupBox2.Controls.Add(this.rb2560);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 60);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Widescreen Support";
            // 
            // rb3440
            // 
            this.rb3440.AutoSize = true;
            this.rb3440.Enabled = false;
            this.rb3440.Location = new System.Drawing.Point(93, 21);
            this.rb3440.Name = "rb3440";
            this.rb3440.Size = new System.Drawing.Size(75, 17);
            this.rb3440.TabIndex = 12;
            this.rb3440.TabStop = true;
            this.rb3440.Text = "3440x1***";
            this.rb3440.UseVisualStyleBackColor = true;
            this.rb3440.CheckedChanged += new System.EventHandler(this.rb3440_CheckedChanged);
            // 
            // rb2560
            // 
            this.rb2560.AutoSize = true;
            this.rb2560.Enabled = false;
            this.rb2560.Location = new System.Drawing.Point(9, 21);
            this.rb2560.Name = "rb2560";
            this.rb2560.Size = new System.Drawing.Size(75, 17);
            this.rb2560.TabIndex = 10;
            this.rb2560.TabStop = true;
            this.rb2560.Text = "2560x1***";
            this.rb2560.UseVisualStyleBackColor = true;
            this.rb2560.CheckedChanged += new System.EventHandler(this.rb2560_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(207, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TweakUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 245);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TweakUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H5Tweak";
            this.Load += new System.EventHandler(this.TweakUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbFOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFPS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tbFOV;
        private System.Windows.Forms.Label lblFOV;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.TrackBar tbFPS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rb3440;
        private System.Windows.Forms.RadioButton rb2560;
    }
}

