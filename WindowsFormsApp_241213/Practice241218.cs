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
            int num = 30;
            int num2 = 4;
            int[] result = clac_division_mod(num, num2);
            textBox_print.Text = result[0].ToString() + "\r\n";
            textBox_print.Text += result[1].ToString() + "\r\n";

        }

        int[] clac_division_mod(int x, int y)
        {
        
            int result = x / y;
            int result2 = x % y;
            int[] ints = new int[2];
            ints[0] = result;
            ints[1] = result2;
            return ints;
        }

    }
    
}
