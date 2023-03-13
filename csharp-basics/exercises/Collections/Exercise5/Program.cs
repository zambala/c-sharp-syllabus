using System;
using System.Collections.Generic;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HappyNumbers();
        }

        public static void HappyNumbers()
        {
                var numberList = new List<int>();
                Console.WriteLine("Enter a number");
                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int value))
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Error! Positive numbers only");
                    }
                    else
                    {
                        numberList.Add(value);

                    }

                    while (value > 1)
                    {
                        value = CalculateSquare(value);
                        Console.WriteLine(value);

                        if (value == 1)
                        {
                            Console.WriteLine("Happy");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else if (numberList.Contains(value))
                        {
                            Console.WriteLine("Not happy");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else
                        {
                            numberList.Add(value);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not a number...");
                }
        }

        public static int CalculateSquare(int num)
        {

            var sum = 0;

            while (num != 0)
            {
                sum += (num % 10) * (num % 10);
                num /= 10;
            }
            return sum;
        }
    }
}
