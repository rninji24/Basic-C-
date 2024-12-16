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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //MessageBox.Show("안녕하세요?");

            /*
             텍스트 박스에 메시지 출력
             */
            // textBox_print.Text = "이것은\r\n멀티라인\r\n텍스트박스\r\n인데요.";
            byte theNumberOfStudent = 30;
            short fiveHourToSecond= 18000;
            int moneyOfDream = 2000000000;
            float myFatherHeight = 174.8f;
            double incomeTax= 3.3;
            decimal grossDomesticProduct = 105400000000000;

            textBox_print.Text += theNumberOfStudent.GetType();
            textBox_print.Text += " theNumberOfStudent: " + theNumberOfStudent.ToString() + "\r\n";
            textBox_print.Text += fiveHourToSecond.GetType();
            textBox_print.Text += " fiveHourToSecond: " + fiveHourToSecond.ToString() + "\r\n";
            textBox_print.Text += moneyOfDream.GetType();
            textBox_print.Text += " moneyOfDream: " + moneyOfDream.ToString() + "\r\n";
            textBox_print.Text += myFatherHeight.GetType();
            textBox_print.Text += " myFatherHeight: " + myFatherHeight.ToString() + "\r\n";
            textBox_print.Text += incomeTax.GetType();
            textBox_print.Text += " incomeTax: " + incomeTax.ToString() + "\r\n";
            textBox_print.Text += grossDomesticProduct.GetType();
            textBox_print.Text += " grossDomesticProduct: " + grossDomesticProduct.ToString() + "\r\n";





        }

        private void textBox_print_TextChanged(object sender, EventArgs e)
        {
            int a = 0;

            a = 9999;
        }
    }
}
