using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            int[] minMax = Enumerable.Range(minNumber, maxNumber - minNumber + 1).ToArray();
            Console.WriteLine("New Array is " + string.Join(",", minMax));

            for (int i = 0; i < minMax.Length; i++)
            {
                sum += minMax[i];
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
