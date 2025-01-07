using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp_241213
{
    public partial class Practice250106 : Form
    {
        BackgroundWorker worker;
        public Practice250106()
        {
            InitializeComponent();

            // 프로그래스 바 초기 설정
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            this.worker = new BackgroundWorker();
            // BackgroundWorker의 ReportProgress() 메소드 활용 여부, 보통 true
            this.worker.WorkerReportsProgress = true;
            // CancelAsync()로 BackgroundWorker를 멈출 수 있게 할지, 보통 true
            this.worker.WorkerSupportsCancellation = true;

            // BackgroundWorker가 UI스레드와 별개로 수행할 메소드
            this.worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            // ReportProgress() 메소드가 수행될 때 실행될 메소드
            this.worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            // ReportProgress()가 100으로 호출되면 마지막에 한 번 실행되는 메소드
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_Complete);

            void Worker_DoWork(object sender, DoWorkEventArgs e) 
            {
                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(30);
                    this.worker.ReportProgress(i);
                }
            }
            void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e) 
            { 
                // ProgressPercentage는 0~100 사이의 값을 가짐
                progressBar1.Value = e.ProgressPercentage;
            }
            void Worker_Complete(object sender, EventArgs e) 
            {
                MessageBox.Show("Complete");
            }
        }
    }
}
