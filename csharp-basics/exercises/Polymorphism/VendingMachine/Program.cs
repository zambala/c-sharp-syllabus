using System;

namespace VendingMachine
{
    internal static class Program
    {
        private static readonly VendingMachine VendingBlast = new("VendingBlast", 10);

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"Your brand new {VendingBlast.Products.Length} slot vending machine is ready.");
            Console.WriteLine("1 - prefill the first 5 slots, 2 - prefill all 10 slots, 3 - do everything manually");
            var selection = GetSelection(1, 3);

            if (selection is 1 or 2)
            {
                VendingBlast.AddProduct("Coca-Cola", new Money(0, 70), 5);
                VendingBlast.AddProduct("Sprite", new Money(0, 80), 4);
                VendingBlast.AddProduct("Fanta", new Money(0, 60), 3);
                VendingBlast.AddProduct("Pepsi", new Money(0, 70), 2);
                VendingBlast.AddProduct("Coca-Cola VIP edition", new Money(5, 0), 1);
            }

            if (selection == 2)
            {
                VendingBlast.AddProduct("Kvass", new Money(0, 50), 5);
                VendingBlast.AddProduct("Dr Pepper", new Money(0, 60), 3);
                VendingBlast.AddProduct("Mountain Dew", new Money(0, 70), 2);
                VendingBlast.AddProduct("Diet Coke", new Money(0, 80), 4);
                VendingBlast.AddProduct("Diet Pepsi", new Money(0, 80), 1);
            }

            Console.WriteLine(VendingBlast.GetAllProducts());
            Console.WriteLine("Setup complete, press any key to start");
            Console.ReadKey();
            Console.Clear();

            var waitingForInput = true;

            while (waitingForInput)
            {
                ShowMainMenu();
            }
        }

        static void ShowMainMenu()
        {
            Console.WriteLine("Available products:");
            Console.WriteLine(VendingBlast.GetAvailableProducts());
            Console.WriteLine($"Balance: {VendingBlast.Amount}");
            Console.WriteLine("1 - insert coin, 2 - buy, 3 - return coins\n" +
                              "4 - add a product(employee), 5 - update a slot(employee)");
            var selection = GetSelection(1, 5);
            Console.Clear();

            switch (selection)
            {
                case 1:
                    CoinMenu();
                    break;
                case 2:
                    PurchaseMenu();
                    break;
                case 3:
                    VendingBlast.ReturnMoney();
                    break;
                case 4:
                    AddProductMenu();
                    break;
                case 5:
                    UpdateProductMenu();
                    break;
            }
        }

        static void CoinMenu()
        {
            Console.WriteLine($"Balance: {VendingBlast.Amount}");
            Console.WriteLine("Enter x,xx to insert a coin");
            Console.WriteLine($"Accepted coins - {string.Join(" | ", VendingBlast.AcceptedMoney)}");

            var coin = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
            Console.Clear();
            var returned = VendingBlast.InsertCoin(new Money(coin[0], coin[1]));

            if (!returned.Equals(new Money()))
            {
                Console.WriteLine($"{returned} returned");
            }
        }

        static void PurchaseMenu()
        {
            Console.WriteLine(VendingBlast.GetAvailableProducts());
            Console.WriteLine($"Balance: {VendingBlast.Amount}");
            Console.WriteLine("Enter product number:");
            var selection = int.Parse(Console.ReadLine());
            Console.Clear();

            if (VendingBlast.BuyProduct(selection))
            {
                VendingBlast.ReturnMoney();
            }
        }

        static void AddProductMenu()
        {
            Console.Clear();
            Console.WriteLine("Slot status:");
            Console.WriteLine(VendingBlast.GetAllProducts());

            if (Array.FindIndex(VendingBlast.Products, product => product.Name == null) != -1)
            {
                Console.WriteLine("No free, unlabeled slots.");
                Console.WriteLine("1 - return to main menu, 2 - update a slot");
                var selection = GetSelection(1, 2);
                Console.Clear();

                if (selection == 1)
                {
                    ShowMainMenu();
                    return;
                }

                UpdateProductMenu();
            }

            Console.WriteLine("Enter product name, price(x,xx) and count separated by space");
            var productInfo = Console.ReadLine().Split(" ");
            var name = productInfo[0];
            var priceArr = Array.ConvertAll(productInfo[1].Split(','), int.Parse);
            var price = new Money(priceArr[0], priceArr[1]);
            var count = int.Parse(productInfo[2]);
            Console.Clear();
            VendingBlast.AddProduct(name, price, count);
        }

        static void UpdateProductMenu()
        {
            Console.WriteLine(VendingBlast.GetAllProducts());
            Console.WriteLine($"Enter 1 - {VendingBlast.Products.Length} to select a product");
            var productNumber = GetSelection(1, VendingBlast.Products.Length);
            Console.Clear();
            Console.WriteLine($"Selected {VendingBlast.Products[productNumber - 1]}");
            Console.WriteLine("Enter name, price(x,xx) and count separated by space");
            var productInfo = Console.ReadLine().Split(" ");
            var name = productInfo[0];
            var priceArr = Array.ConvertAll(productInfo[1].Split(','), int.Parse);
            var price = new Money(priceArr[0], priceArr[1]);
            var count = int.Parse(productInfo[2]);
            VendingBlast.UpdateProduct(productNumber, name, price, count);


            Console.Clear();
        }

        static int GetSelection(int min, int max)
        {
            if (int.TryParse(Console.ReadLine(), out var input) && input >= min && input <= max)
            {
                return input;
            }

            Console.WriteLine("Invalid selection, try again:");
            input = GetSelection(min, max);
            return input;
        }
    }
}
