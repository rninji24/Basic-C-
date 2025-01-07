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

        Random rand = new Random();

        enum RSP
        {
            rock,
            scissors,
            paper
        }

        int user_score = 0;
        int com_score = 0;

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        void PlayRSPGame(RSP user)
        {
            
        }

        

        
    }
}
