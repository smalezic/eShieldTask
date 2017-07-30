using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGenerator
{
    public partial class Form1 : Form
    {
        #region Fields

        private char BACKSLASH = '\\';
        CancellationTokenSource _cts;

        #endregion Fields

        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Event Handlers

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
            LblFileName.Text = path.GetFolderName() + TxtFileName.Text.Trim();
        }
        
        private async void BtnStart_Click(object sender, EventArgs e)
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

                if (int.TryParse(TxtAmount.Text.Trim(), out amount))
                {
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    
                    ProgressBar.Value = 0;
                    ProgressBar.Maximum = amount;

                    _cts = new CancellationTokenSource();
                    CancellationToken ct = _cts.Token;

                    BtnStart.Enabled = false;
                    BtnCancel.Enabled = true;

                    for (int i = 0; i < amount; i++)
                    {
                        try
                        {
                            Task numberGenerator = await Task.Factory.StartNew(async () =>
                            {
                                await SaveToFileAsync(LblFileName.Text, rand.Next(2, 26).ToString());
                            }, ct);

                            Task userInterfaceUpdater = numberGenerator.ContinueWith((it) =>
                            {
                                LblClock.Text = (DateTime.Now - startTime).ToString("hh':'mm':'ss'.'fff");
                                ProgressBar.Value++;
                            }, TaskScheduler.FromCurrentSynchronizationContext());
                        }
                        catch (AggregateException exc)
                        {
                            foreach (var flattenExp in exc.Flatten().InnerExceptions)
                            {
                                Console.WriteLine("Error - {0}", flattenExp.Message);
                            }
                        }
                        catch(OperationCanceledException exc)
                        {
                            if (exc.CancellationToken.IsCancellationRequested)
                            {
                                MessageBox.Show("The operation is canceled");
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Unknown error!");
                            }
                        }
                        catch(Exception exc)
                        {
                            MessageBox.Show("Unknown error - {0}", exc.Message);
                        }
                    }

                    if (_cts.IsCancellationRequested == false)
                    {
                        MessageBox.Show("Done!");
                    }

                    BtnStart.Enabled = true;
                    BtnCancel.Enabled = false;
                }
                else
                {
                    MessageBox.Show("The amount is not in correct format!");
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _cts.Cancel();

            BtnStart.Enabled = true;
            BtnCancel.Enabled = false;
        }

        private void BtnFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String selectedFile = ofd.FileName;
                LblFileNameForInspection.Text = selectedFile;

                try
                {
                    FileInspector fi = new FileInspector(selectedFile);
                    var fileAttribute = fi.GetFileAttributes();

                    if (fileAttribute != null && fileAttribute.Result)
                    {
                        LblAttribute.Text = fileAttribute.Attribute.ToString();
                        LblCreationTime.Text = fileAttribute.CreationTime.ToString("yyyy-MM-dd, HH:mm:ss.fff");
                        LblAccessTime.Text = fileAttribute.LastAccessTime.ToString("yyyy-MM-dd, HH:mm:ss.fff");
                        LblWriteTime.Text = fileAttribute.LastWriteTime.ToString("yyyy-MM-dd, HH:mm:ss.fff");
                        LblFileSizeHigh.Text = fileAttribute.FileSizeHigh.ToString();
                        LblFileSizeLow.Text = fileAttribute.FileSizeLow.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Reading the file wasn't successful");
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Error - {0}", exc.Message);
                }
            }
        }

        #endregion Event Handlers

        #region IO Method

        private async Task SaveToFileAsync(string path, string line)
        {
            using (var sw = File.AppendText(path))
            {
                await sw.WriteLineAsync(line);
            }
        }

        #endregion IO Method
    }
}
