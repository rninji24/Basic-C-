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
    public partial class Practice241219 : Form
    {
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
            Error = 999
        }
        public Practice241219()
        {
            InitializeComponent();

            

        }

        private void button_input_Click(object sender, EventArgs e)
        {
            string days = textBox_input.Text;
            
            switch (InputCheck(days))
            {
                case Days.Monday:
                    textBox_result.Text = "월요일\r\n";
                    break;
                case Days.Tuesday:
                    textBox_result.Text = "화요일\r\n";
                    break;
                case Days.Wednesday:
                    textBox_result.Text = "수요일\r\n";
                    break;
                case Days.Thursday:
                    textBox_result.Text = "월요일\r\n";
                    break;
                case Days.Friday:
                    textBox_result.Text = "목요일\r\n";
                    break;
                case Days.Saturday:
                    textBox_result.Text = "금요일\r\n";
                    break;
                case Days.Sunday:
                    textBox_result.Text = "토요일\r\n";
                    break;
                default:
                    textBox_result.Text = "월,화,수,목,금,토,일 중에 입력하세요\r\n";
                    break;
            }
        }

        Days InputCheck(string message)
        {
            Days days;

            switch (message)
            {
                case "월":
                    return Days.Monday;
                case "화":
                    return Days.Tuesday;
                case "수":
                    return Days.Wednesday;
                case "목":
                    return Days.Thursday;
                case "금":
                    return Days.Friday;
                case "토":
                    return Days.Saturday;
                case "일":
                    return Days.Sunday;
                default:
                    return Days.Error;
            }
        }

    }
}
