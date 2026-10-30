using System;

class Program
{

    static string firstName;
    static string lastName;
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();

        PrintName(firstName, lastName);
    }

    static void PrintName(string first, string last)
    {
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}