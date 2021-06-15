
namespace Controls_Randomizer
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.lblVersion = new System.Windows.Forms.Label();
            this.checkFullRandom = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.radioTimer = new System.Windows.Forms.RadioButton();
            this.radioMap = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.checkRngSound = new System.Windows.Forms.CheckBox();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Location = new System.Drawing.Point(12, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(281, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "FF8 Controls Randomizer EN/FR 1.03";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkFullRandom
            // 
            this.checkFullRandom.AutoSize = true;
            this.checkFullRandom.Location = new System.Drawing.Point(12, 25);
            this.checkFullRandom.Name = "checkFullRandom";
            this.checkFullRandom.Size = new System.Drawing.Size(85, 17);
            this.checkFullRandom.TabIndex = 2;
            this.checkFullRandom.Text = "Full Random";
            this.checkFullRandom.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 80);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(281, 25);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Timer (sec):";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 108);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(232, 18);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Waiting for game...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(250, 24);
            this.numTimer.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(43, 20);
            this.numTimer.TabIndex = 3;
            this.numTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioTimer
            // 
            this.radioTimer.AutoSize = true;
            this.radioTimer.Checked = true;
            this.radioTimer.Location = new System.Drawing.Point(90, 42);
            this.radioTimer.Name = "radioTimer";
            this.radioTimer.Size = new System.Drawing.Size(51, 17);
            this.radioTimer.TabIndex = 4;
            this.radioTimer.TabStop = true;
            this.radioTimer.Text = "Timer";
            this.radioTimer.UseVisualStyleBackColor = true;
            this.radioTimer.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioMap
            // 
            this.radioMap.AutoSize = true;
            this.radioMap.Location = new System.Drawing.Point(147, 42);
            this.radioMap.Name = "radioMap";
            this.radioMap.Size = new System.Drawing.Size(86, 17);
            this.radioMap.TabIndex = 5;
            this.radioMap.Text = "Map Change";
            this.radioMap.UseVisualStyleBackColor = true;
            this.radioMap.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Randomize on";
            // 
            // checkRngSound
            // 
            this.checkRngSound.AutoSize = true;
            this.checkRngSound.Location = new System.Drawing.Point(12, 61);
            this.checkRngSound.Name = "checkRngSound";
            this.checkRngSound.Size = new System.Drawing.Size(109, 17);
            this.checkRngSound.TabIndex = 6;
            this.checkRngSound.Text = "Audio Notification";
            this.checkRngSound.UseVisualStyleBackColor = true;
            this.checkRngSound.CheckedChanged += new System.EventHandler(this.checkRngSound_CheckedChanged);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(250, 108);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(43, 18);
            this.lblCount.TabIndex = 12;
            this.lblCount.Text = "0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 135);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.checkRngSound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioMap);
            this.Controls.Add(this.radioTimer);
            this.Controls.Add(this.numTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.checkFullRandom);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 174);
            this.MinimumSize = new System.Drawing.Size(321, 174);
            this.Name = "formMain";
            this.Text = "FF8 Controls Randomizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnApplicationExit);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnApplicationExit);
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.CheckBox checkFullRandom;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.RadioButton radioTimer;
        private System.Windows.Forms.RadioButton radioMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkRngSound;
        private System.Windows.Forms.Label lblCount;
    }
}

