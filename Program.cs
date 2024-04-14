using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;


        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine()!;

        string[] inputArray = input.Split(' ');

        int newSize = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                newSize++;
            }
        }

        string[] newArray = new string[newSize];


        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                newArray[index] = inputArray[i];
                index++;
            }
        }

        Console.WriteLine("Новый массив:");
        foreach (string item in newArray)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}