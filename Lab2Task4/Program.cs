using Repeats;

namespace Lab2Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = R.CreateArraySize(5, 10);
            int[,] array = Functions.FillingTheArray(arraySize, 1, 10);
            Functions.PrintArray(array);
            Console.WriteLine();
            int summ = Functions.GettingSumm(array);
            Console.WriteLine("Сумма элементов на четных позициях = {0}", summ);
        }
    }
}