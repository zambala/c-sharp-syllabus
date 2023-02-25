using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Console.ReadLine();
            Int64 n = int.Parse(input);

            if (n == int.Parse(input))
                {
                if (n < 0)
                    {
                        n *= -1;
                    }
                if (n >= 10000000000)
                    {
                        Console.WriteLine("Number is greater or equals 10,000,000,000!");
                    }
                    else
                    {
                        int digits = 1;
                        if (n >= 10 && n <= 99)
                        {
                            digits = 2;
                        }
                        else if (n >= 100 && n <= 999)
                        {
                            digits = 3;
                        }
                        else if (n >= 1000 && n <= 9999)
                        {
                            digits = 4;
                        }
                        else if (n >= 10000 && n <= 99999)
                        {
                            digits = 5;
                        }
                        else if (n >= 100000 && n <= 999999)
                        {
                            digits = 6;
                        }
                        else if (n >= 1000000 && n <= 9999999)
                        {
                            digits = 7;
                        }
                        else if (n >= 10000000 && n <= 99999999)
                        {
                            digits = 8;
                        }
                        else if (n >= 100000000 && n <= 999999999)
                        {
                            digits = 9;
                        }
                        else if (n == 1000000000)
                        {
                            digits = 10;
                        }
                        Console.WriteLine("Number of digits in the number: " + digits);
                    }
                }
                else
                {
                    Console.WriteLine("The number is not a long");
                }
        }
    }
}
