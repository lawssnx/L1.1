using System;
using System.Collections.Generic;
class Programm
{
    static void Main(string[] args)
    {
        Console.Write("Введіть список чисел через пробіл:");
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        Console.Write("Введіть індекс елемента, який потрібно видалити:");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("_______");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.WriteLine("_______");

        numbers.RemoveAt(index);

        int newIndex = index;
        while (newIndex < numbers.Count && numbers[newIndex] < numbers[index])
        {
            newIndex++;
            numbers.Insert(newIndex, numbers[index]);

        }

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.ReadKey();


    }
}
