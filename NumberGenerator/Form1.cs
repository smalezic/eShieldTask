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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGenerator
{
    public partial class Form1 : Form
    {
        private char BACKSLASH = '\\';
        StreamWriter sw = null;

        private ObservableCollection<int> _numberList;
        private Object _lockSync;

        public Form1()
        {
            InitializeComponent();

            //var now = DateTime.Now;
            //CultureInfo ci = CultureInfo.InvariantCulture;
            //LblClock.Text = now.ToString("hh:mm:ss.fff", ci);
            LblFileName.Text = @"D:\Temp\1.txt";
            TxtAmount.Text = "100";

            _numberList = new ObservableCollection<int>();
            _numberList.CollectionChanged += NumberList_CollectionChanged;
            _lockSync = new Object();
        }

        private void NumberList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if(e.NewItems != null)
            {
                foreach(var number in e.NewItems)
                {
                    lock (_lockSync)
                    {
                        StreamWriter sw1 = new StreamWriter(@"D:\Temp\10.txt");
                        string line = (String)number;
                        sw1.WriteLine(line);
                        sw1.Flush();
                        sw1.Close();
                    }
                }
            }
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

        private async Task SaveNumber(StreamWriter sw, int number)
        {
            await sw.WriteLineAsync(number.ToString());
            sw.Flush();
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

                if (int.TryParse(TxtAmount.Text, out amount))
                {

                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    int generatedNumber = 0;

                    ProgressBar.Value = 0;
                    ProgressBar.Maximum = amount;

                    //try
                    //{
                        sw = new StreamWriter(LblFileName.Text);
                    
                        for (int i = 0; i < amount; i++)
                        {
                            Task T = Task.Factory.StartNew( () =>
                            {
                                generatedNumber = rand.Next(2, 26);
                                _numberList.Add(generatedNumber);
                                //await SaveNumber(sw, generatedNumber);
                            });

                            Task T2 = T.ContinueWith((it) =>
                            {
                                var passedTime = (DateTime.Now - startTime);
                                LblClock.Text = passedTime.ToString("hh':'mm':'ss'.'fff");

                                RchOutput.AppendText(generatedNumber.ToString() + Environment.NewLine);

                                ProgressBar.Value++;
                            },
                            TaskScheduler.FromCurrentSynchronizationContext());

                            //T.Start();
                        }

                    //}
                    //finally
                    //{
                    //if (sw != null)
                    //{
                    //    sw.Close();
                    //}
                    //}
                }
                else
                {
                    MessageBox.Show("The amount of numbers is not in correct format!");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sw != null)
            {
                sw.Close();
            }
        }

        private void BtnFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String selectedFile = ofd.FileName;
                LblFileNameForInspection.Text = selectedFile;

                FileInspector fi = new FileInspector(selectedFile);
                var fileAttribute = fi.GetFileAttributes();
                if(fileAttribute != null && fileAttribute.Result)
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
                    MessageBox.Show("Reading file wasn't successful");
                }
            }
        }
    }
}
