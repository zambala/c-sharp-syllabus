using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Bio in 1 sentence!");
            string bio = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < bio.Length; i++)
            {
                if (char.IsUpper(bio[i])) count++;
            }

            Console.WriteLine($"The number of Uppercase characters in your sentence is {count}");
        }
    }
}
