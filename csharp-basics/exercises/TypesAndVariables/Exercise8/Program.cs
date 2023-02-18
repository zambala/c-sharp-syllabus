using System;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi Minūtes");
            var minutes = int.Parse(Console.ReadLine());

            var minutesInYear = 365 * 24 * 60;
            var minutesInDay = 24 * 60;

            var years = minutes / minutesInYear;
            var minutesToDays = minutes % minutesInYear;
            var days = minutesToDays / minutesInDay;

            Console.WriteLine($"It's {years} and {days} days.");

            Console.ReadKey();
            Console.ReadKey();
            //tramt
        }
    }
}

