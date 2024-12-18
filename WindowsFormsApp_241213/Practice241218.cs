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
            bool coin_fornt = true;
            bool coin_back = false;
            bool result = coinToss_winorlose(coin_fornt);
            if (result == true)
            {
                textBox_print.Text = "승리";
            }
            else
            {
                textBox_print.Text += "패배";
            }
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
        Boolean coinToss_winorlose(Boolean front_back)
        {
            Random random = new Random();
            int a = random.Next(0, 2);
            if (a == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

    }

}