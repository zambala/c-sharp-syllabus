﻿using System;

namespace PrintDayInWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the number of the day 0-6: ");  
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 0: 
                    Console.WriteLine("Sunday"); 
                    break;
                case 1: 
                    Console.WriteLine("Monday"); 
                    break;
                case 2: 
                    Console.WriteLine("Tuesday"); 
                    break;
                case 3: 
                    Console.WriteLine("Wednesday"); 
                    break;
                case 4: 
                    Console.WriteLine("Thursday"); 
                    break;
                case 5: 
                    Console.WriteLine("Friday"); 
                    break;
                case 6: 
                    Console.WriteLine("Saturday"); 
                    break;
                default: 
                    Console.WriteLine("Not a valid day"); 
                    break;
            }
            Console.WriteLine("bye");
        }
    }
}
