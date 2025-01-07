using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_241213
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();            
        }
        public void OutArray()
        {
            string content = File.ReadAllText(@"input.txt");

        }
    }
}
