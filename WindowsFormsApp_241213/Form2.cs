using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_241213
{
    internal class Form2
    {
        public void RefArray(ref int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i;
            }
        }

        public void OutArray(out int[] ints, int n)
        {
            ints = new int[n];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = -i;
            }
        }
        

    }
}
