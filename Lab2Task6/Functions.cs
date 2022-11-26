using Repeats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task6
{
    internal class Functions
    {
        public static int[] Duplicate(int[] array)
        {
            int value = R.GettingANegativeValue(array);
            int[] finalArray = new int[array.GetLength(0) + value];
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] >= 0)
                {
                    finalArray[count] = array[i];
                    count++;
                }
                else if (array[i] < 0)
                {
                    finalArray[count] = array[i];
                    count++;
                    finalArray[count] = array[i];
                    count++;
                }
            }
            return finalArray;
        }

    }
}
