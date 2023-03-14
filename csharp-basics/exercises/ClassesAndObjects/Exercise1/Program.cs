using System;
using static Exercise1.Product;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Logitech mouse", 70.00, 14);
            Product product2 = new Product("iPhone 5s", 999.99, 3);
            Product product3 = new Product("Epson EB-U05", 440.46, 1);

            Console.WriteLine(product1.PrintProduct());
            Console.WriteLine(product2.PrintProduct());
            Console.WriteLine(product3.PrintProduct());

            product2.ChangePrice(890.00);
            product2.ChangeSmallerCount(2);
            product2.ChangeBiggerCount(1);

            Console.WriteLine("\nName: " + product2.Name + "\nNew Price: " + product2.PriceAtStart + " EUR\nItems Left: " + product2.AmountAtStart + " items");
        }
    }
}
