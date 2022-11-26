using Repeats;

namespace Lab2Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = R.CreateArraySize(5, 10);
            int[] array = R.FillingTheArray(arraySize, 1, 100);
            Console.WriteLine("Полученный массив:");

            R.PrintArray(array);

            Console.WriteLine("\nМассив после сортировки:");

            Functions.ShakerSort(array);
            R.PrintArray(array);
        }
    }
}