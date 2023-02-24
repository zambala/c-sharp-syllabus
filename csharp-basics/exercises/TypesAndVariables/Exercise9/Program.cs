using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input distance(metres): ");
            decimal distance = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Input Time (in minutes): ");
            int timeMinutes = int.Parse(Console.ReadLine());

            int timeSeconds = timeMinutes * 60;
            Console.WriteLine($"Time in Seconds is: {timeSeconds}");
            double timeHoursSimple = (double)timeMinutes / 60;

            var timeHours = TimeSpan.FromSeconds(timeSeconds);
            Console.WriteLine("Time in Hours is {0:00}:{1:00}:{2:00}", (int)timeHours.TotalHours, timeHours.Minutes, timeHours.Seconds);

            decimal metersSecond = distance / timeSeconds;
            decimal KilometersHour = (distance / 1000) / ((decimal)timeSeconds / 3600);
            decimal milesHour = KilometersHour / (decimal)1.609;

            Console.WriteLine($"Your speed in metres/sec is {metersSecond}");
            Console.WriteLine($"Your speed in km/h is {KilometersHour}");
            Console.WriteLine($"Your speed in miles/h is {milesHour}");
            
            Console.WriteLine($"distance is {distance} Meters and it took {timeMinutes} Minutes, {timeSeconds} seconds or {timeHours} hours or {timeHoursSimple} simple Hours, speed {metersSecond} m/s, {KilometersHour} km/h or {milesHour} mph");

            Console.ReadKey();
        }
    }
}
