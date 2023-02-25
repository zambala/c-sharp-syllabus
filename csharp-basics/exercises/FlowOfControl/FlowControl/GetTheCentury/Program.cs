using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Century(1001);
            Century(1385);
            Century(2012);
            Console.ReadKey();  
        }
        public static string Century(int year)
        {
            var temp = year / 100.0;
            if (temp <= 21)
            {
                Console.WriteLine($"{Math.Ceiling(temp)}th century");
                return $"{Math.Ceiling(temp)}th century";
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(temp)}st century");
                return $"{Math.Ceiling(temp)}st century";
            }
        }
    }
}
