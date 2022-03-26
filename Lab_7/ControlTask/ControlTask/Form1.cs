using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void GoButt()
        {
            int maxValue = 0;
            System.Text.StringBuilder resultText = new
            System.Text.StringBuilder();
            if (int.TryParse(MaxValue.Text, out maxValue))
            {
                for (int trial = 2; trial <= maxValue; trial++)
                {
                    System.Threading.Thread.Sleep(100);
                    progressBar1.Value = (int)(trial*maxValue/100);
                    bool isPrime = true;
                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    {
                        if (trial % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        resultText.AppendFormat("{0} ", trial);
                    }
                }
            }
            else
            {
                resultText.Append("Unable to parse maximum value.");
            }
            ResultLabel.Text = resultText.ToString();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            GoButt();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Второй поток завершен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(MaxValue.Text == ""))
            {
                int i = int.Parse(MaxValue.Text);
                backgroundWorker1.RunWorkerAsync(i);
            }
        }
    }
}
