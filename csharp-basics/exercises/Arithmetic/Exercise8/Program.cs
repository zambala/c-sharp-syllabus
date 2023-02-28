using System;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("employee 1: ");
            CalculatePay(7.50, 35);
            Console.Write("employee 2: ");
            CalculatePay(8.20, 47);
            Console.Write("employee 3: ");
            CalculatePay(10.00, 73);
            Console.ReadKey();
        }

        public static double CalculatePay(double pay, double hours)
        {
            double minimumWage = 8.00;
            double maxHours = 60;
            double totalSalary = 0;

            if (pay < minimumWage || hours > maxHours)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                if (hours > 40)
                {
                    totalSalary = pay * 40 + 1.5 * pay * (hours - 40);
                }
                else
                {
                    totalSalary = pay * hours;
                }
                Console.WriteLine("Your total salary is " + totalSalary);
            }

            return totalSalary;
        }
    }
}