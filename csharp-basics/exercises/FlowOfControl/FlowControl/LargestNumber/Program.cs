using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            int input3 = int.Parse(Console.ReadLine());

            if (input1 > input2 && input1 > input3)
                   Console.Write("Number one is the largest!");
            
            else if(input2 > input1 && input2 > input3 )
                  Console.Write("Number two is the largest!"); 
            else
                Console.Write("Number three is the largest!");
        }
    }
}

