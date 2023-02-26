using System;
using System.Drawing;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = RandomUtils.generateArray(10);

            var arrayCopy = new int[10];
            values.CopyTo(arrayCopy, 0);

            values[values.Length - 1] = -7;

            Console.WriteLine(string.Join(",", values));
            Console.WriteLine(string.Join(",", arrayCopy));
        }
        public static class RandomUtils
        {
            public static int[] generateArray(int count)
            {
                Random random = new Random();
                int[] values = new int[count];

                for (int i = 0; i < count; ++i)
                    values[i] = random.Next(1, 100);

                return values;
            }
        }
    }
}
