using System;

class Program
{
    static void Main(string[] args)
    {
        List<Fraction> fractionList = new List<Fraction>()
        {
            new Fraction(),
            new Fraction(5),
            new Fraction(3, 4),
            new Fraction(1, 3) 
        };

         
        foreach (Fraction fraction in fractionList)
        {
            Console.WriteLine(fraction.ToFractionString());

            Console.WriteLine(fraction.ToDecimal());
        }

        
    }
}