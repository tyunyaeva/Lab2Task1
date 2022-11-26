using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task1
{
    public static class Functions
    {
        public static void Swap(int[] array, int i, int j)
        {
            int value = array[i];
            array[i] = array[j];
            array[j] = value;
        }

        public static void ShakerSort(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        Swap(array, i - 1, i);
                    }
                }
                left++;
            }
        }
    }
}
