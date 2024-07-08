using System;

class Program
{
    static void Main(string[] args)
    {
        string[] inputArray = { "Hello", "2", "world", ": -)" };
        string[] resultArray = FilterStrings(inputArray);

        Console.WriteLine("Исходный массив: " + string.Join(", ", inputArray));
        Console.WriteLine("Результат: " + string.Join(", ", resultArray));
    }

    static string[] FilterStrings(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                resultArray[count] = array[i];
                count++;
            }
        }

        return resultArray;
    }
}