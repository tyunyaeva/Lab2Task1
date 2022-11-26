using Repeats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task8
{
    internal class Functions
    {
        public static int[] Search(int[] array)
        {
            int value = R.IntTryParse();
            bool trySearch = false;
            int Count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] == value)
                {
                    Count++;
                    trySearch = true;
                }
            }
            if (trySearch)
            {
                int[] result = new int[Count];
                return result;
                int arrayIndex = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i] == value)
                    {
                        result[arrayIndex] = i;
                        arrayIndex++;
                    }
                }
            }
            else
            {
                int[] result = new int[1] {-1};
                return result;
            }
        }
    }
}
