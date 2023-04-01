using System;

namespace VendingMachine
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var products = new Product[10];
            var vending = new VendingMachine("vender", products);

            vending.AddProduct("Coca-Cola", new Money(0, 50), 3);
            vending.AddProduct("Sprite", new Money(0, 50), 3);
            vending.AddProduct("Pepsi", new Money(0, 50), 3);
            vending.AddProduct("7Up", new Money(0, 50), 3);
            vending.AddProduct("Fanta", new Money(0, 50), 3);
            vending.AddProduct("Dr.Pepper", new Money(0, 50), 3);

            Console.WriteLine(vending.ReturnAvailableProducts());

            vending.InsertCoin(new Money(2, 0));
            Console.WriteLine(vending.Amount);
            vending.BuyProduct(8);
            vending.BuyProduct(6);
            Console.ReadKey();
        }
    }
}
