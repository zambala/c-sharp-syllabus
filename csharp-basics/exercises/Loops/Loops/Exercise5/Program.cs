using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string wordFirst = Console.ReadLine();
            Console.WriteLine("Enter another word: ");
            string wordSecond = Console.ReadLine();

            int wordsTogether = (wordFirst + wordSecond).Length;

            Console.Write(wordFirst);

            for (int i = 0; i < 30 - wordsTogether; i++)
            {
                Console.Write(".");
            }

            Console.Write(wordSecond);
            Console.WriteLine("\n");
        }
    }
}
