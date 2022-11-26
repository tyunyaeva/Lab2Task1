using Repeats;

namespace Lab2Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = R.CreateArraySize(5, 10);
            int[] array = R.FillingTheArray(arraySize, -10, 10);
            R.PrintArray(array);
            int[] finalArray = Functions.DeleteNegative(array);
            Console.WriteLine();
            R.PrintArray(finalArray);
        }
    }
}