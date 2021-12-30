﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 

namespace quizgame
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }
        startgame sg = new startgame();
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                sum = sum + i;  
                backgroundWorker1.ReportProgress(i);
                if(i==100)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(100);
                    return;
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(100);
                    return; 
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                label1.Text = "100%";
                this.Hide();
                sg.Show();
            }
            else if (e.Error !=null)
            {
                label1.Text = e.Error.Message;
            }
            else
            {
                label1.Text = e.Result.ToString();
            }
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
