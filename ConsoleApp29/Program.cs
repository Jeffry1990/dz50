using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthArray = 0;
            int[] array = new int[lengthArray];
            int[] arrayCopy = new int[lengthArray];
            int arraySum = 0;

            while (true)
            {
                Console.WriteLine($"Введите число, exit или sum: ");
                string Message = Console.ReadLine();

                if (Message != "sum" && Message != "exit")
                {
                    int numberRand = Convert.ToInt32(Message);
                    lengthArray += 1;
                    array = new int[lengthArray];

                    for (int i = 0; i < arrayCopy.Length; i++)
                    {
                        array[i] = arrayCopy[i];
                    }

                    array[lengthArray - 1] = numberRand;
                    arrayCopy = new int[lengthArray];

                    for (int i = 0; i < array.Length; i++)
                    {
                        arrayCopy[i] = array[i];
                    }

                    arrayCopy[lengthArray - 1] = numberRand;
                }

                else if (Message == "sum")
                {
                    for (int i = 0; i < array.Length; i++)
                        arraySum += array[i];
                    Console.WriteLine($"Сумма массива: {arraySum} ");
                    arraySum = 0;
                }

                else if (Message == "exit")
                {
                    break;
                }

                else Console.WriteLine($"Нет такой команды ");
            }
        }
    }
}
    

