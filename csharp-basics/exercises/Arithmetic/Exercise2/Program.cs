using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 != 0)
            {
                Console.WriteLine("Odd Number");
            }
            else
            {
                Console.WriteLine("Even Number");
                
            }
            Console.WriteLine("Bye!");

        }
    }
}
