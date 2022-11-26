using Repeats;

namespace Lab2Task2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int arraySize = R.CreateArraySize(2, 4);
            int[,,] array = Functions.CreateArray(arraySize, -10, 10);
            R.PrintArray3(array);
            Functions.Replace(array);
            Console.WriteLine("Вид массива после изменений:");
            R.PrintArray3(array);
        }
    }
}