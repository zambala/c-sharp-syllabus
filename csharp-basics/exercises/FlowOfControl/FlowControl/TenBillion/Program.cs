using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Console.ReadLine();
            int n = int.Parse(input);

            //todo - check if number
            if ()
                {
                    //todo - check if n is less than zero
                if (input < 0)
                    {
                        n *= -1;
                    }

                    //fixme
                if (input >= 1000000000)
                    {
                        Console.WriteLine("Number is greater or equals 10,000,000,000!");
                    }
                    else
                    {
                        int digits = 1;
                        if (?)
                        {
                            digits = 2;
                        }
                        else if (?)
                        {
                            digits = 3;
                        }
                        else if (?)
                        {
                            digits = 4;
                        }
                        else if (?)
                        {
                            digits = 5;
                        }
                        else if (?)
                        {
                            digits = 6;
                        }
                        else if (?)
                        {
                            digits = 7;
                        }
                        else if (?)
                        {
                            digits = 8;
                        }
                        else if (?)
                        {
                            digits = 9;
                        }
                        else if (?)
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
