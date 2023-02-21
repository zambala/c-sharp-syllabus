using System;

namespace Product1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int product;
            int i;

            
            product = 1;

            for (i = 1; i <= 10; i++)
            {
                
                product = product * i;
            }

            Console.WriteLine("Product is " + product);
            Console.ReadKey();
        }
    }
}
