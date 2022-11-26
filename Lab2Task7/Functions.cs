using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task7
{
    internal class Functions
    {
        public static void Swap(int[] array, int i, int j)
        {
            int value = array[i];
            array[i] = array[j];
            array[j] = value;
        }
    }
}
