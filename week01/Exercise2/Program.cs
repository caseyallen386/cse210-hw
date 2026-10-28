using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage?");

        int perc = int.Parse( Console.ReadLine() );

        string letter;
        bool passed = true;

        if (perc >= 90)
        {
            letter = "A";
        }
        else if (perc >= 80)
        {
            letter = "B";
        }
        else if (perc >= 70)
        {
            letter = "C";
        }
        else if (perc >= 60)
        {
            letter = "D";
            passed = false;
        }
        else
        {
            letter = "F";
            passed = false;
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (passed)
        {
            Console.WriteLine("You Passed!");

        }
        else
        {
            Console.WriteLine("Study a little harder next time!");
        }
    }
}