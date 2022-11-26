using Repeats;

namespace Lab2Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = R.CreateArraySize(5, 10);
            int[] array = R.FillingTheArray(arraySize, -10, 10);
            R.PrintArray(array);
            int[] finalArray = Functions.Duplicate(array);
            Console.WriteLine();
            R.PrintArray(finalArray);
        }
    }
}