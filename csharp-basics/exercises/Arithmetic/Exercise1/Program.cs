using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test1();

        }

        public static bool Test1()
        {
            Console.WriteLine("Enter a Number!");
            int numb1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another Number!");
            int numb2 = int.Parse(Console.ReadLine());

            if (numb1 == 15 || numb2 == 15 || numb1 + numb2 == 15 || numb1 - numb2 == 15 || numb2 - numb1 == 15)
            {
                Console.WriteLine("Result is True");
                return true;
            }
            else
            {
                Console.WriteLine("Result is False");
                return false;
            }
        }
    }
}
