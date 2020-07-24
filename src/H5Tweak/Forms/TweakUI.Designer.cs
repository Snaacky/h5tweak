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
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.gbCustomRes = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.cbAspectRatio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslIsGameRunning = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbFOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFPS)).BeginInit();
            this.gbSettings.SuspendLayout();
            this.gbCustomRes.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFOV
            // 
            this.tbFOV.Location = new System.Drawing.Point(6, 32);
            this.tbFOV.Maximum = 150;
            this.tbFOV.Minimum = 1;
            this.tbFOV.Name = "tbFOV";
            this.tbFOV.Size = new System.Drawing.Size(269, 45);
            this.tbFOV.TabIndex = 0;
            this.tbFOV.Value = 78;
            this.tbFOV.Scroll += new System.EventHandler(this.tbFOV_Scroll);
            // 
            // lblFOV
            // 
            this.lblFOV.AutoSize = true;
            this.lblFOV.Location = new System.Drawing.Point(6, 16);
            this.lblFOV.Name = "lblFOV";
            this.lblFOV.Size = new System.Drawing.Size(47, 13);
            this.lblFOV.TabIndex = 1;
            this.lblFOV.Text = "FOV: 78";
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(6, 80);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(43, 13);
            this.lblFPS.TabIndex = 4;
            this.lblFPS.Text = "FPS: 60";
            // 
            // tbFPS
            // 
            this.tbFPS.Location = new System.Drawing.Point(6, 96);
            this.tbFPS.Maximum = 300;
            this.tbFPS.Minimum = 1;
            this.tbFPS.Name = "tbFPS";
            this.tbFPS.Size = new System.Drawing.Size(269, 45);
            this.tbFPS.TabIndex = 3;
            this.tbFPS.Value = 60;
            this.tbFPS.Scroll += new System.EventHandler(this.tbFPS_Scroll);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.tbFPS);
            this.gbSettings.Controls.Add(this.lblFPS);
            this.gbSettings.Controls.Add(this.tbFOV);
            this.gbSettings.Controls.Add(this.lblFOV);
            this.gbSettings.Enabled = false;
            this.gbSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSettings.Location = new System.Drawing.Point(12, 12);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(285, 144);
            this.gbSettings.TabIndex = 5;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = " Settings ";
            // 
            // gbCustomRes
            // 
            this.gbCustomRes.BackColor = System.Drawing.SystemColors.Control;
            this.gbCustomRes.Controls.Add(this.btnApply);
            this.gbCustomRes.Controls.Add(this.cbAspectRatio);
            this.gbCustomRes.Controls.Add(this.label3);
            this.gbCustomRes.Controls.Add(this.txtHeight);
            this.gbCustomRes.Controls.Add(this.label2);
            this.gbCustomRes.Controls.Add(this.txtWidth);
            this.gbCustomRes.Controls.Add(this.label1);
            this.gbCustomRes.Enabled = false;
            this.gbCustomRes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomRes.Location = new System.Drawing.Point(12, 171);
            this.gbCustomRes.Name = "gbCustomRes";
            this.gbCustomRes.Size = new System.Drawing.Size(285, 82);
            this.gbCustomRes.TabIndex = 6;
            this.gbCustomRes.TabStop = false;
            this.gbCustomRes.Text = "Custom Resolution";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(197, 39);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(78, 23);
            this.btnApply.TabIndex = 19;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbAspectRatio
            // 
            this.cbAspectRatio.FormattingEnabled = true;
            this.cbAspectRatio.Items.AddRange(new object[] {
            "16:9",
            "21:9",
            "4:3",
            "5:4"});
            this.cbAspectRatio.Location = new System.Drawing.Point(124, 41);
            this.cbAspectRatio.Name = "cbAspectRatio";
            this.cbAspectRatio.Size = new System.Drawing.Size(52, 21);
            this.cbAspectRatio.TabIndex = 18;
            this.cbAspectRatio.Text = "21:9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Aspect Ratio:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(67, 41);
            this.txtHeight.MaxLength = 4;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(39, 22);
            this.txtHeight.TabIndex = 16;
            this.txtHeight.Text = "1440";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Height:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(9, 41);
            this.txtWidth.MaxLength = 4;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(39, 22);
            this.txtWidth.TabIndex = 14;
            this.txtWidth.Text = "3440";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Width:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslIsGameRunning});
            this.statusStrip1.Location = new System.Drawing.Point(0, 266);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(307, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslIsGameRunning
            // 
            this.tsslIsGameRunning.Name = "tsslIsGameRunning";
            this.tsslIsGameRunning.Size = new System.Drawing.Size(154, 17);
            this.tsslIsGameRunning.Text = "Halo 5: Forge is not running";
            // 
            // TweakUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 288);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbCustomRes);
            this.Controls.Add(this.gbSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TweakUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H5Tweak";
            this.Load += new System.EventHandler(this.TweakUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbFOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFPS)).EndInit();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbCustomRes.ResumeLayout(false);
            this.gbCustomRes.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbFOV;
        private System.Windows.Forms.Label lblFOV;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.TrackBar tbFPS;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbCustomRes;
        private System.Windows.Forms.ComboBox cbAspectRatio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslIsGameRunning;
    }
}

