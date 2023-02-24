﻿using System;

namespace SumAverageRunningInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            double average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; number++)
            {
                sum += number;
            }
            average = (double)sum / 100;

            Console.WriteLine($"The Sum of number from 1 to 100 is {sum}");
            Console.WriteLine($"The average is {average}");
            Console.ReadKey();
        }
    }
}
