using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool win = false;

            Console.WriteLine("What the desired sum of both dices should be?");
            int desiredSum = int.Parse(Console.ReadLine());

            while (!win)
            {
                int randomNumber1 = random.Next(1, 7);
                int randomNumber2 = random.Next(1, 7);
                Console.WriteLine($"{randomNumber1} and {randomNumber2} = {randomNumber1 + randomNumber2}");

                if (desiredSum == randomNumber1 + randomNumber2)
                {
                    win = true;
                }
            }
        }
    }
}
