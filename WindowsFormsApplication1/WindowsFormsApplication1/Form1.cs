using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void DoStuff()
        {
            for (int i = 1; i < 6; i++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    break;                 
                }
                backgroundWorker1.ReportProgress(i * 20);
                Thread.Sleep(1000);
            }           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DoStuff();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = "Done";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = e.ProgressPercentage.ToString();
        }
    }
}
