using System;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] {  92, 6, 73, -77, 81, -90, 99, 8, -85, 34,  };

            Console.WriteLine(String.Join(" ", CountPosSumNeg(input)));
            Console.ReadKey();
        }

        public static int[] CountPosSumNeg(int[] input)
        {
            int sumPos = 0;
            int sumNeg = 0;
            int[] arraySecond = new int[2];

            if (input.Length > 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] > 0)
                    {
                        sumPos++;
                    }
                    else if (input[i] < 0)
                    {
                        sumNeg += input[i];
                    }
                }

                arraySecond[0] = sumPos;
                arraySecond[1] = sumNeg;

                return arraySecond;
            }

            return input;
        }
    }
}