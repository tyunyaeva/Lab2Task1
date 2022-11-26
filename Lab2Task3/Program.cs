using Repeats;

namespace Lab2Task3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int arraySize = R.CreateArraySize(5, 10);
            int[] array = R.FillingTheArray(arraySize, -100, 100);
            R.PrintArray(array);
            int summ = Functions.GettingSumm(array);
            Console.WriteLine("\nСумма всех неотрицательных значений массива = {0}", summ);
        }
    }
}