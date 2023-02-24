using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 110; i++)
            {
                int count = 0;
                if (i % 3 == 0) Console.Write("Coza");
                else if (i % 5 == 0) Console.Write("Loza");
                else if (i % 7 == 0) Console.Write("Woza");
                else Console.Write(i);

                if (i % 11 == 0)
                    Console.WriteLine("\n");
                else
                    Console.Write("\t");
            }
            Console.ReadKey();
        }
    }
}
