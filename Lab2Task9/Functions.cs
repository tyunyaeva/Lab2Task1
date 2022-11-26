using Repeats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task9
{
    internal class Functions
    {
        public static int[] FillingTheArray(int arraySize)
        {
            Random rand = new Random();
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                if (i == 0)
                {
                    array[i] = rand.Next(0, 3);

                }
                else
                {
                    array[i] = array[i - 1] += rand.Next(1, 5);
                }
            }
            return array;
        }
        public static bool Code(int[] arrayOne, int[] arrayTwo)
        {
            bool result = true;
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    result = false;
                    return result;
                }
            }
            return result;
        }
    }
}
