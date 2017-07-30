namespace NumberGenerator
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblClock = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblFileSizeLow = new System.Windows.Forms.Label();
            this.LblFileSizeHigh = new System.Windows.Forms.Label();
            this.LblWriteTime = new System.Windows.Forms.Label();
            this.LblAccessTime = new System.Windows.Forms.Label();
            this.LblCreationTime = new System.Windows.Forms.Label();
            this.LblAttribute = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblFileNameForInspection = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFileBrowse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblFileName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtFileName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnBrowse);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 100);
            this.panel1.TabIndex = 0;
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Location = new System.Drawing.Point(198, 48);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(0, 13);
            this.LblFileName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Generated numbers will be saved at:";
            // 
            // TxtFileName
            // 
            this.TxtFileName.Location = new System.Drawing.Point(74, 10);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(238, 20);
            this.TxtFileName.TabIndex = 2;
            this.TxtFileName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFileName_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File name:";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(318, 8);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 0;
            this.BtnBrowse.Text = "Br&owse...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.LblClock);
            this.panel2.Controls.Add(this.TxtAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BtnStart);
            this.panel2.Controls.Add(this.ProgressBar);
            this.panel2.Location = new System.Drawing.Point(13, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 105);
            this.panel2.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(318, 36);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblClock
            // 
            this.LblClock.AutoSize = true;
            this.LblClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClock.Location = new System.Drawing.Point(74, 36);
            this.LblClock.Name = "LblClock";
            this.LblClock.Size = new System.Drawing.Size(82, 18);
            this.LblClock.TabIndex = 4;
            this.LblClock.Text = "00:00:00.000";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(74, 10);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(82, 20);
            this.TxtAmount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount:";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(318, 7);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "&Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(19, 68);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(374, 23);
            this.ProgressBar.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LblFileSizeLow);
            this.panel3.Controls.Add(this.LblFileSizeHigh);
            this.panel3.Controls.Add(this.LblWriteTime);
            this.panel3.Controls.Add(this.LblAccessTime);
            this.panel3.Controls.Add(this.LblCreationTime);
            this.panel3.Controls.Add(this.LblAttribute);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.LblFileNameForInspection);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.BtnFileBrowse);
            this.panel3.Location = new System.Drawing.Point(429, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 212);
            this.panel3.TabIndex = 2;
            // 
            // LblFileSizeLow
            // 
            this.LblFileSizeLow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFileSizeLow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFileSizeLow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblFileSizeLow.Location = new System.Drawing.Point(126, 184);
            this.LblFileSizeLow.Name = "LblFileSizeLow";
            this.LblFileSizeLow.Size = new System.Drawing.Size(180, 20);
            this.LblFileSizeLow.TabIndex = 14;
            // 
            // LblFileSizeHigh
            // 
            this.LblFileSizeHigh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFileSizeHigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFileSizeHigh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblFileSizeHigh.Location = new System.Drawing.Point(126, 156);
            this.LblFileSizeHigh.Name = "LblFileSizeHigh";
            this.LblFileSizeHigh.Size = new System.Drawing.Size(180, 20);
            this.LblFileSizeHigh.TabIndex = 13;
            // 
            // LblWriteTime
            // 
            this.LblWriteTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblWriteTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblWriteTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblWriteTime.Location = new System.Drawing.Point(126, 129);
            this.LblWriteTime.Name = "LblWriteTime";
            this.LblWriteTime.Size = new System.Drawing.Size(180, 20);
            this.LblWriteTime.TabIndex = 12;
            // 
            // LblAccessTime
            // 
            this.LblAccessTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAccessTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAccessTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblAccessTime.Location = new System.Drawing.Point(126, 101);
            this.LblAccessTime.Name = "LblAccessTime";
            this.LblAccessTime.Size = new System.Drawing.Size(180, 20);
            this.LblAccessTime.TabIndex = 11;
            // 
            // LblCreationTime
            // 
            this.LblCreationTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCreationTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCreationTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblCreationTime.Location = new System.Drawing.Point(126, 74);
            this.LblCreationTime.Name = "LblCreationTime";
            this.LblCreationTime.Size = new System.Drawing.Size(180, 20);
            this.LblCreationTime.TabIndex = 10;
            // 
            // LblAttribute
            // 
            this.LblAttribute.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAttribute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAttribute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblAttribute.Location = new System.Drawing.Point(126, 47);
            this.LblAttribute.Name = "LblAttribute";
            this.LblAttribute.Size = new System.Drawing.Size(180, 20);
            this.LblAttribute.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "File size low:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "File seze high:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Last write time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Last access time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Creation time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Attribute:";
            // 
            // LblFileNameForInspection
            // 
            this.LblFileNameForInspection.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFileNameForInspection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFileNameForInspection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblFileNameForInspection.Location = new System.Drawing.Point(68, 8);
            this.LblFileNameForInspection.Name = "LblFileNameForInspection";
            this.LblFileNameForInspection.Size = new System.Drawing.Size(238, 20);
            this.LblFileNameForInspection.TabIndex = 2;
            this.LblFileNameForInspection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "File name: ";
            // 
            // BtnFileBrowse
            // 
            this.BtnFileBrowse.Location = new System.Drawing.Point(312, 7);
            this.BtnFileBrowse.Name = "BtnFileBrowse";
            this.BtnFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnFileBrowse.TabIndex = 0;
            this.BtnFileBrowse.Text = "&Browse";
            this.BtnFileBrowse.UseVisualStyleBackColor = true;
            this.BtnFileBrowse.Click += new System.EventHandler(this.BtnFileBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 238);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Number Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblClock;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnFileBrowse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblFileNameForInspection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblFileSizeLow;
        private System.Windows.Forms.Label LblFileSizeHigh;
        private System.Windows.Forms.Label LblWriteTime;
        private System.Windows.Forms.Label LblAccessTime;
        private System.Windows.Forms.Label LblCreationTime;
        private System.Windows.Forms.Label LblAttribute;
        private System.Windows.Forms.Button BtnCancel;
    }
}

