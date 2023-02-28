using System;
using System.Collections;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34, };
            CountPosSumNeg([92, 6, 73, -77, 81, -90, 99, 8, -85, 34]);
        }

        public int[] CountPosSumNeg(int[] input)
        {
            int length = input.Length;
            int[] arraySecond = new int[2];
            var sumPos = 0;
            var sumNeg = 0;

            for (int i = 0; i < length; i++) 
            {
                if (input[i] > 0)
                {
                    sumPos += input[i];
                }
                else
                {
                    sumNeg += input[i];
                }
                return arraySecond;
            }
            return arraySecond;
        }
    }
}
