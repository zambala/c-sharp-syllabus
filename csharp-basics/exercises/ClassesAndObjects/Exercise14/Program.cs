using System;

namespace Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(1970, 9, 21);
            Date date2 = new Date(1945, 9, 2);
            Date date3 = new Date(2001, 9, 11);

            Console.WriteLine(date1.WeekdayInDutch());
            Console.WriteLine(date2.WeekdayInDutch());
            Console.WriteLine(date3.WeekdayInDutch());
            Console.ReadKey();
        }
    }
}
