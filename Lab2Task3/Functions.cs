using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task3
{
    internal class Functions
    {

        public static int GettingSumm(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    summ += array[i];
                }
            }
            return summ;
        }

    }
}
