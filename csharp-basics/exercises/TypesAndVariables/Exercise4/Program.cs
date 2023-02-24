using System;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your surename?");
            string sureName = Console.ReadLine();

            Console.WriteLine("What is your year of birth?");
            int birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your name is {name} {sureName} and you were born in {birthYear}.");
        }
    }
}
