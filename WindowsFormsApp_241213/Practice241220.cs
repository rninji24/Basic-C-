using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_241213
{
    public partial class Practice241220 : Form
    {

        public Practice241220()
        {
            InitializeComponent();           
        }

        void makeSentence(string name, int score)
        { 
            textBox_result.Text += name + ": " + score + "점\r\n";
        }
        private void button_input_Click(object sender, EventArgs e)
        {        
            #region practice1
            //int student_num = int.Parse(textBox_input.Text);
            //int[] student_score = new int[student_num];
            //textBox_result.Text = "";
            //for (int i = 0; i < student_num; i++)
            //{
            //    int score = random.Next(101);
            //    student_score[i] = score;
            //    string studentName = "학생" + (i+1).ToString();
            //    makeSentence(studentName, student_score[i]);        
            //}
            #endregion
           
        }

        int computerRSP()
        {
            Random r = new Random();
            int x = r.Next(0, 3);
            if (x == 0)
            {
                textBox_computerChoice.Text = "가위";
            }
            else if (x == 1)
            {
                textBox_computerChoice.Text = "바위";
            }
            else if (x == 2)
            {
                textBox_computerChoice.Text = "보";
            }
            return x;
        }

        int use_win = 0;
        int computer_win = 0;
        string[] match = { "가위", "바위", "보" };

        private void Match(int idx, int computer)
        {
            if (idx == 0 && computer == 2)
            {
                use_win++;
            }
            else if (idx == 1 && computer == 0)
            {
                use_win++;
            }
            else if (idx == 2 && computer == 1)
            {
                use_win++;
            }
            else if (idx == 2 && computer == 0)
            {
                computer_win++;
            }
            else if (idx == 0 && computer == 1)
            {
                computer_win++;
            }
            else if (idx == 1 && computer == 2)
            {
                computer_win++;
            }
            textBox_result.Text += "사용자: " + match[idx] + " 컴퓨터: " + match[computer] + " | 점수 사용자: " + use_win.ToString() + " 컴퓨터: " + computer_win.ToString() + "\r\n";

            if (use_win == 3 || computer_win == 3)
            {
                if (use_win == 3 && computer != 3)
                {
                    textBox_result.Text += "사용자 승리\r\n";
                }
                else if (use_win != 3 || computer_win == 3)
                {
                    textBox_result.Text += "컴퓨터 승리\r\n";
                }
                else
                {
                    textBox_result.Text += "무승부\r\n";
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox_myChoice.Text = "가위";
            int idx = 0;
            int computer = computerRSP();
            Match(idx, computer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_myChoice.Text = "바위";
            int idx = 1;
            int computer = computerRSP();
            Match(idx, computer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_myChoice.Text = "보";
            int idx = 2;
            int computer = computerRSP();
            Match(idx, computer);
        }
    }
}
