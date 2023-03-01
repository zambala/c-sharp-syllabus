using System;

namespace AsciiFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many levels should the *AsciiFigure* have: ");
            int size = int.Parse(Console.ReadLine());

            int i = 1;
            string symbol = "";

            while (i <= size)
            {
                string dash1 = new string('/', 4 * (size - i));
                string dash2 = new string('\\', 4 * (size - i));
                Console.WriteLine(dash1 + symbol + dash2);
                symbol += "********";
                i++;
            }
        }
    }
}