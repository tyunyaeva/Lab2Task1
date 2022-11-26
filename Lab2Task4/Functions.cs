using Repeats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task4
{
    internal class Functions
    {
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static int[,] FillingTheArray(int arraySize, int begin, int end)
        {
            Random rand = new Random();
            int[,] array = new int[arraySize, arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    array[i, j] = rand.Next(begin, end);
                }
            }
            return array;
        }

        public static int GettingSumm(int[,] array)
        {
            int summ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        summ += array[i, j];
                    }
                }
            }
            return summ;
        }

    }
}
