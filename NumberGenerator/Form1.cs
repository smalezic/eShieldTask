using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGenerator
{
    public partial class Form1 : Form
    {
        private char BACKSLASH = '\\';

        public Form1()
        {
            InitializeComponent();

            //var now = DateTime.Now;
            //CultureInfo ci = CultureInfo.InvariantCulture;
            //LblClock.Text = now.ToString("hh:mm:ss.fff", ci);
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                String selectedFolder = fbd.SelectedPath + BACKSLASH;

                PathStructure path = new PathStructure(LblFileName.Text);
                LblFileName.Text = selectedFolder + path.GetFileName();
            }
        }

        private void TxtFileName_KeyUp(object sender, KeyEventArgs e)
        {
            PathStructure path = new PathStructure(LblFileName.Text);
            LblFileName.Text = path.GetFolderName() + TxtFileName.Text;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            LblClock.Text = "00:00:00.000";
            var startTime = DateTime.Now;

            if (String.IsNullOrWhiteSpace(TxtAmount.Text))
            {
                MessageBox.Show("Please enter the amount of numbers!");
            }
            else
            {
                int amount;

                if (int.TryParse(TxtAmount.Text, out amount))
                {
                    StreamWriter sw = null;

                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    int generatedNumber;

                    ProgressBar.Value = 0;
                    ProgressBar.Maximum = amount;

                    try
                    {
                        sw = new StreamWriter(LblFileName.Text);

                        for (int i = 0; i < amount; i++)
                        {
                            Task T = new Task(() =>
                            {
                                generatedNumber = rand.Next(2, 26);
                                sw.WriteLineAsync(generatedNumber.ToString());
                                sw.Flush();
                            });

                            Task T2 = T.ContinueWith((it) =>
                            {
                                var passedTime = (DateTime.Now - startTime);
                                LblClock.Text = passedTime.ToString("hh':'mm':'ss'.'fff");

                                ProgressBar.Value++;
                            },
                            TaskScheduler.FromCurrentSynchronizationContext());

                            T.Start();
                        }
                    }
                    finally
                    {
                        if (sw != null)
                        {
                            sw.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The amount of numbers is not in correct format!");
                }
            }
        }
    }
}
