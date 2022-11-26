using Repeats;

namespace Lab2Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите вариант решения:\n1)Рандомное заполнение массивов" +
                "\n2)Гарантированно равные массивы");
            int possibleAnswer = R.IntTryParse();
            switch (possibleAnswer)
            {
                case 1:
                    int arraySize = R.CreateArraySize(5, 10);
                    int[] arrayOne = Functions.FillingTheArray(arraySize);
                    int[] arrayTwo = Functions.FillingTheArray(arraySize);
                    Console.WriteLine("Массив 1:");
                    R.PrintArray(arrayOne);
                    Console.WriteLine("\nМассив 2:");
                    R.PrintArray(arrayTwo);
                    if(Functions.Code(arrayOne, arrayTwo))
                    {
                        Console.WriteLine("\nМассивы равны");
                        return;
                    }
                    Console.WriteLine("\nМассивы не равны");
                    break;
                case 2:
                    int[] arrayOneTrue = new int[5] {1, 10, 15, 4, 3};
                    int[] arrayTwoTrue = new int[5] {10, 15, 1, 3, 4};
                    Console.WriteLine("Массив 1:");
                    R.PrintArray(arrayOneTrue);
                    Console.WriteLine("\nМассив 2:");
                    R.PrintArray(arrayTwoTrue);
                    if (Functions.Code(arrayOneTrue, arrayTwoTrue))
                    {
                        Console.WriteLine("\nМассивы равны");
                        return;
                    }
                    Console.WriteLine("\nМассивы не равны");
                    break;
                default:
                    Console.WriteLine("Введите корректное значение и повторите снова!");
                    break;
            }

        }
    }
}