using Repeats;

namespace Lab2Task8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            int arraySize = R.IntTryParse();
            if (arraySize < 1)
            {
                Console.WriteLine("Вы ввели размерность массива равную или меньше 0, пожалуйста, попробуйте снова");
                return;
            }
            int[] array = R.FillingTheArray(arraySize, 0, 10);
            R.PrintArray(array);
            Console.WriteLine("\nВведите число, вхождения которого надо проверить");
            int[] result = Functions.Search(array);
            if (result[0] == -1)
            {
                Console.WriteLine("Вхожденний данного числа в массие не найдено");
                return;
            }
            R.PrintArray(result);
        }
    }
}