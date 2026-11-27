using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment genericAssignment = new Assignment("Sam Bennet", "Multiplication");

        MathAssignment mathAssignment1 = new MathAssignment("Robert", "Fractions", "Section 7.3", "Problems 8-16");

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(genericAssignment.GetSummary());

        Console.WriteLine(mathAssignment1.GetHomework());

        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}