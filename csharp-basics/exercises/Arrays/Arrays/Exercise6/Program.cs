using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sum = 0;
            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());
            int i;
            int[] arr = new int[2]; // 5 size array

            // Accepting value from user 
            for (i = minNumber; i <= maxNumber; i++)
            {
                Console.Write("\nEnter your number:\t");
                //Storing value in an array
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\n");
            //Printing the value on console
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("you entered {0}", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
