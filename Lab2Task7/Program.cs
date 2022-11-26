using Repeats;

namespace Lab2Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            int arraySize = R.IntTryParse();
            if (arraySize < 1)
            {
                Console.WriteLine("Вы ввели размерность равную или меньше 0, попробуйте снова");
                return;
            }
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("введите {0} число:", i + 1);
                int value = R.IntTryParse();
                array[i] = value;
            }
            R.PrintArray(array);
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("\nОтсортированный массив:");
            R.PrintArray(array);
        }
    }
}