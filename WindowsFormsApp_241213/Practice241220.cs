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

        private void button_input_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            
            int student_num = int.Parse(textBox_input.Text);
            int[] student_score = new int[student_num];

            for (int i = 0; i < student_num; i++)
            {
                int score = random.Next(100);
                student_score[i] = score;
                textBox_result.Text += "학생" + (i + 1) + "의 점수: " + student_score[i] + "점\r\n";
            }
        }
    }
}
