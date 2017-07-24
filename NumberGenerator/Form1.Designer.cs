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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.BtnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.LblClock = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblFileName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtFileName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnBrowse);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 100);
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
            this.panel2.Controls.Add(this.LblClock);
            this.panel2.Controls.Add(this.TxtAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BtnStart);
            this.panel2.Controls.Add(this.ProgressBar);
            this.panel2.Location = new System.Drawing.Point(13, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 232);
            this.panel2.TabIndex = 1;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(33, 185);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(319, 23);
            this.ProgressBar.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(318, 4);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "&Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
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
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(74, 6);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(100, 20);
            this.TxtAmount.TabIndex = 3;
            // 
            // LblClock
            // 
            this.LblClock.AutoSize = true;
            this.LblClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClock.Location = new System.Drawing.Point(74, 33);
            this.LblClock.Name = "LblClock";
            this.LblClock.Size = new System.Drawing.Size(82, 18);
            this.LblClock.TabIndex = 4;
            this.LblClock.Text = "00:00:00.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}

