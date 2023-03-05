using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayRandom = new int[20];
            Random rand = new Random();

            for (int i = 0; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = rand.Next(1, 20);
            }

            Console.Write($"Random numbers are: " + string.Join(",", arrayRandom) + "\n");

            Console.WriteLine("Enter the position out of 20 random numbers you want to know");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput <= 0 || userInput > 20)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"You have chosen a number {arrayRandom[userInput -1]}");
            }
        }
    }
}
