using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp_241213
{
    public partial class Form250107 : Form
    {
        private Random random = new Random();
        private int finishedCount = 0;
        private Stopwatch stopwatch = new Stopwatch();

        public Form250107()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox_result.Items.Clear();
            finishedCount = 0;

            string[] cars = { "CAR1", "CAR2", "CAR3", "CAR4", "CAR5" };
            Thread[] threads = new Thread[cars.Length];

            stopwatch = Stopwatch.StartNew();

            foreach (string car in cars)
            {
                Thread thread = new Thread(() => RunRace(car));
                thread.IsBackground = true;
                thread.Start();
            }
        }

        private void RunRace(string carName)
        { 
            int distance = 0;
            int finishline = 0;

            while (distance < finishline)
            { 
                int move = random.Next(1, 10);
                int delay = random.Next(100, 1000);
                distance += move;

                Thread.Sleep(delay);
            }

            int rank = Interlocked.Increment(ref finishedCount);
            TimeSpan elapsedTime = stopwatch.Elapsed;
            string result = $"{carName} 결승선 도착! 순서:{rank} 경과 시간:{elapsedTime.TotalSeconds:F2}";

            Invoke(new Action(() =>
            {
                listBox_result.Items.Add(result);
            }));
        }
    }
}
