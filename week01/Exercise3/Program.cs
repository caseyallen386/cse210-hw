using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int numbGuess = 0;
        bool guessed = false;

        Console.WriteLine("Welcome to the guess the magic number game!");
        Console.WriteLine("Guess the number between 1 and 100!");


        Console.WriteLine("Enter your first guess:");
        int guess = int.Parse( Console.ReadLine() );
        
        numbGuess++;

        while (!guessed)
        {
            
            if (number == guess)
            {
                guessed = true;
                Console.WriteLine($"You guessed it!");
                string tries = numbGuess > 1 ? "tries" : "try";
                Console.WriteLine($"It took you {numbGuess} {tries}!");
            }
            else
            {

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                    
                }
                else
                {
                    Console.WriteLine("Higher");
                    
                }
                guess = int.Parse(Console.ReadLine());
                numbGuess++;
            }

        }
    }

}