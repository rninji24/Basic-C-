using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Random random = new Random();
            
            int student_num = int.Parse(textBox_input.Text);
            int[] student_score = new int[student_num];
            textBox_result.Text = "";
            for (int i = 0; i < student_num; i++)
            {
                int score = random.Next(101);
                student_score[i] = score;
                string studentName = "학생" + (i+1).ToString();
                makeSentence(studentName, student_score[i]);        
            }
        }
    }
}
