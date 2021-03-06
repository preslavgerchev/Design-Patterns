﻿namespace StrategyPattern
{
    partial class StrategyPatternForm
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
            this.components = new System.ComponentModel.Container();
            this.lbRandomNumbers = new System.Windows.Forms.ListBox();
            this.lbOrderedNumbers = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.rbFCFS = new System.Windows.Forms.RadioButton();
            this.rbSSTF = new System.Windows.Forms.RadioButton();
            this.rbSCAN = new System.Windows.Forms.RadioButton();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbCurrent = new System.Windows.Forms.GroupBox();
            this.gbRandomNumbers = new System.Windows.Forms.GroupBox();
            this.gbOrderedNumbers = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbCurrent.SuspendLayout();
            this.gbRandomNumbers.SuspendLayout();
            this.gbOrderedNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRandomNumbers
            // 
            this.lbRandomNumbers.FormattingEnabled = true;
            this.lbRandomNumbers.ItemHeight = 16;
            this.lbRandomNumbers.Location = new System.Drawing.Point(16, 47);
            this.lbRandomNumbers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbRandomNumbers.Name = "lbRandomNumbers";
            this.lbRandomNumbers.Size = new System.Drawing.Size(55, 372);
            this.lbRandomNumbers.TabIndex = 0;
            // 
            // lbOrderedNumbers
            // 
            this.lbOrderedNumbers.FormattingEnabled = true;
            this.lbOrderedNumbers.ItemHeight = 16;
            this.lbOrderedNumbers.Location = new System.Drawing.Point(16, 47);
            this.lbOrderedNumbers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbOrderedNumbers.Name = "lbOrderedNumbers";
            this.lbOrderedNumbers.Size = new System.Drawing.Size(55, 372);
            this.lbOrderedNumbers.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(391, 214);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 43);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(45, 505);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(559, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(16, 20);
            this.tbCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(71, 22);
            this.tbCurrent.TabIndex = 6;
            this.tbCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbFCFS
            // 
            this.rbFCFS.AutoSize = true;
            this.rbFCFS.Checked = true;
            this.rbFCFS.Location = new System.Drawing.Point(15, 20);
            this.rbFCFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFCFS.Name = "rbFCFS";
            this.rbFCFS.Size = new System.Drawing.Size(168, 21);
            this.rbFCFS.TabIndex = 7;
            this.rbFCFS.TabStop = true;
            this.rbFCFS.Text = "First Come First Serve";
            this.rbFCFS.UseVisualStyleBackColor = true;
            this.rbFCFS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbFCFS_MouseClick);
            // 
            // rbSSTF
            // 
            this.rbSSTF.AutoSize = true;
            this.rbSSTF.Location = new System.Drawing.Point(15, 47);
            this.rbSSTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSSTF.Name = "rbSSTF";
            this.rbSSTF.Size = new System.Drawing.Size(184, 21);
            this.rbSSTF.TabIndex = 8;
            this.rbSSTF.Text = "Shortest Seek Time First";
            this.rbSSTF.UseVisualStyleBackColor = true;
            this.rbSSTF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSSTF_MouseClick);
            // 
            // rbSCAN
            // 
            this.rbSCAN.AutoSize = true;
            this.rbSCAN.Location = new System.Drawing.Point(15, 74);
            this.rbSCAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSCAN.Name = "rbSCAN";
            this.rbSCAN.Size = new System.Drawing.Size(160, 21);
            this.rbSCAN.TabIndex = 9;
            this.rbSCAN.Text = "SCAN disk (elevator)";
            this.rbSCAN.UseVisualStyleBackColor = true;
            this.rbSCAN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSCAN_MouseClick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(391, 274);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(147, 43);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSCAN);
            this.groupBox1.Controls.Add(this.rbSSTF);
            this.groupBox1.Controls.Add(this.rbFCFS);
            this.groupBox1.Location = new System.Drawing.Point(363, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(213, 124);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Strategy";
            // 
            // gbCurrent
            // 
            this.gbCurrent.Controls.Add(this.tbCurrent);
            this.gbCurrent.Location = new System.Drawing.Point(409, 359);
            this.gbCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCurrent.Name = "gbCurrent";
            this.gbCurrent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCurrent.Size = new System.Drawing.Size(104, 78);
            this.gbCurrent.TabIndex = 10;
            this.gbCurrent.TabStop = false;
            this.gbCurrent.Text = "Current";
            // 
            // gbRandomNumbers
            // 
            this.gbRandomNumbers.Controls.Add(this.lbRandomNumbers);
            this.gbRandomNumbers.Location = new System.Drawing.Point(79, 39);
            this.gbRandomNumbers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRandomNumbers.Name = "gbRandomNumbers";
            this.gbRandomNumbers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRandomNumbers.Size = new System.Drawing.Size(87, 430);
            this.gbRandomNumbers.TabIndex = 12;
            this.gbRandomNumbers.TabStop = false;
            this.gbRandomNumbers.Text = "Random numbers";
            // 
            // gbOrderedNumbers
            // 
            this.gbOrderedNumbers.Controls.Add(this.lbOrderedNumbers);
            this.gbOrderedNumbers.Location = new System.Drawing.Point(181, 39);
            this.gbOrderedNumbers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOrderedNumbers.Name = "gbOrderedNumbers";
            this.gbOrderedNumbers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOrderedNumbers.Size = new System.Drawing.Size(87, 430);
            this.gbOrderedNumbers.TabIndex = 13;
            this.gbOrderedNumbers.TabStop = false;
            this.gbOrderedNumbers.Text = "Ordered numbers";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 569);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(559, 39);
            this.progressBar1.TabIndex = 14;
            // 
            // StrategyPatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 625);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gbOrderedNumbers);
            this.Controls.Add(this.gbRandomNumbers);
            this.Controls.Add(this.gbCurrent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StrategyPatternForm";
            this.Text = "Strategy Pattern";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCurrent.ResumeLayout(false);
            this.gbCurrent.PerformLayout();
            this.gbRandomNumbers.ResumeLayout(false);
            this.gbOrderedNumbers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRandomNumbers;
        private System.Windows.Forms.ListBox lbOrderedNumbers;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.RadioButton rbFCFS;
        private System.Windows.Forms.RadioButton rbSSTF;
        private System.Windows.Forms.RadioButton rbSCAN;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbCurrent;
        private System.Windows.Forms.GroupBox gbRandomNumbers;
        private System.Windows.Forms.GroupBox gbOrderedNumbers;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

