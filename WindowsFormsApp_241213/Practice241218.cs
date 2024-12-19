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
    public partial class Practice241218 : Form
    {
        public Practice241218()
        {
            InitializeComponent();

            #region practice1
            //int num = 30;
            //int num2 = 4;
            //int[] result = clac_divide_remain(num, num2);
            //textBox_print.Text = result[0].ToString() + "\r\n";
            //textBox_print.Text += result[1].ToString() + "\r\n";
            #endregion

            #region practice2
            //bool coin_fornt = true;
            //bool coin_back = false;
            //bool result = coinToss_winorlose(coin_fornt);
            //if (result == true)
            //{
            //    textBox_result.Text = "승리";
            //}
            //else
            //{
            //    textBox_result.Text += "패배";
            //}
            #endregion


        }

        #region practice1 함수
        int[] clac_divide_remain(int x, int y)
        {

            int result = x / y;
            int result2 = x % y;
            int[] ints = new int[2];
            ints[0] = result;
            ints[1] = result2;
            return ints;
        }
        #endregion

        #region practice2 함수
        Boolean coinToss_winorlose(Boolean coinSide)
        {
            Random randomObj = new Random();
            int random = randomObj.Next();

            bool compare = Convert.ToBoolean(random % 2);
            if (random % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

            // 코인 뽑기
            //bool result = false;
            //if(random % 2 == 1)
            //{
            //    result = true;
            //} // 0, false
            // 사용자 입력과 비교
            //if (coinSide == result)
            //{
            //    return true;
            //}
            //return false;

        }
        #endregion

        #region 241219 practice1
        private void button_input_Click(object sender, EventArgs e)
        {
            // textBox_input.Text의 문자열을
            // textBox_result.Text로 복사
            
            if (textBox_input.Text == "true" || textBox_input.Text == "false")
            {
                textBox_result.Text = "입력하신 값은 " + Convert.ToBoolean(textBox_input.Text) + " 입니다!\r\n";
                textBox_result.Text += "동전 던지기 결과...\r\n";
                bool result = coinToss_winorlose(Convert.ToBoolean(textBox_input.Text));
                if (result == true)
                {
                    textBox_result.Text += "승리";
                }
                else
                {
                    textBox_result.Text += "패배";
                }
            }
            else
            {
                textBox_result.Text = "true 또는 false만 입력하세요";
                
            }
    
        }

        private void appendrdbText(object sender, EventArgs e)
        {
            if (radioButton_true.Checked) textBox_input.Text = radioButton_true.Text;
            else if (radioButton_false.Checked) textBox_input.Text = radioButton_false.Text;

        }
        private void radioButton_true_CheckedChanged(object sender, EventArgs e)
        {
            appendrdbText(sender, e);
        }
        #endregion
    }

}