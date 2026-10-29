using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int total = 0;
        float average;
        int largest = 0;
        bool isZero = false;

        Console.WriteLine("Please enter a series of numbers and I will give you the sum, average, and the largest number in the list.");

        while (!isZero)
        {

            Console.Write("Enter a number: ");
            int response = int.Parse( Console.ReadLine() );

            if (response != 0)
            {
                numbers.Add(response);
            }
            else
            {
                isZero = true;
            }


        }


        foreach (int number in numbers)
        {
            
            largest = number > largest ? number : largest;

            total += number;

        }

        average = total / numbers.Count;

        Console.WriteLine($"Largest number: {largest}");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");


    }
}