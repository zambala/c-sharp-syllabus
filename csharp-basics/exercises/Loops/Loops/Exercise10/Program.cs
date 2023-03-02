using System;

namespace NumberSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter min number");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter max number");
            int max = int.Parse(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                for (int j = i; j <= max; j++)
                {
                    Console.Write(j);
                }
                for (int j = min; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}