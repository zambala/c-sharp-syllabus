using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;

            Random random = new Random();
            int number = random.Next(min, max);

            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            int guess1 = int.Parse(Console.ReadLine());

            if (guess1 < number)
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {number}.");
            }
            else if (guess1 > number)
            {
                Console.WriteLine($"Sorry, you are too high.  I was thinking of  {number}.");
            }
            else
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
        }
    }
}
