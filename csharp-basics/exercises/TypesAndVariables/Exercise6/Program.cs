using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter many single digit Numbers : ");

            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            Console.Write($"Sum is= {sum} \n \n");
            Console.WriteLine("Again, Enter many single digit Numbers : ");

            Console.ReadKey();
        }
    }
}
