// See https://aka.ms/new-console-template for more information
//ToDo: Write a query that returns names of days
//https://docs.microsoft.com/en-us/dotnet/api/system.dayofweek?view=net-6.0
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DaysNames
{
    internal class Program
    {
        enum DaysOfWeek { Monday, Tuesday, Wednesday, Thurday, Friday, Saturday, Sunday };
        static void Main(string[] args)
        {
            var daysNames = Enum.GetValues(typeof(DaysOfWeek)).Cast<DaysOfWeek>();

            foreach (var day in daysNames)
            {
                Console.Write($"{day} ");
            }

            Console.ReadKey();
        }
    }
}