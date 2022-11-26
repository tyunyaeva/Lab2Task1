using Repeats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task5
{
    internal class Functions
    {
        public static int[] DeleteNegative(int[] array)
        {
            int value = R.GettingANegativeValue(array);
            int[] finalArray = new int[array.GetLength(0) - value];
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] > -1)
                {
                    finalArray[count] = array[i];
                    count++;
                }
            }
            return finalArray;
        }

    }
}
