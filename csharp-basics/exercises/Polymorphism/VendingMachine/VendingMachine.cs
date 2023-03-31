using System;
using System.Collections.Generic;
using System.Linq;
using VendingMachine.Exceptions;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        public string Manufacturer { get; }
        public bool HasProducts => Array.Exists(Products, product => product.Available > 0);
        public Money Amount { get; set; }
        public Product[] Products { get; set; }
        public string[] AcceptedCoins = { "£0.10", "£0.20", "£0.50", "£1.00", "£2.00" };

        public VendingMachine(string manufacturer,  Product[] products)
        {
            Manufacturer = manufacturer;
            Products = products;
        }

        public VendingMachine(string manufacturer)
        {
            Manufacturer = manufacturer;
        }

        public Money InsertCoin(Money amount)
        {
            if (AcceptedCoins.Contains(amount.ToString()))
            {
                Amount = Amount.Add(amount);
                return amount;
            }
            else
            {
                throw new CoinNotAcceptedException(amount);
            }
        }
        
        public Money ReturnMoney()
        {
            var product = new Product();
            var returnAmount = Amount.Subtract(product.Price);

            Console.WriteLine($"{returnAmount} returned");
            return returnAmount;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            bool hasemptySlots = false;
            int index = 0;

            if (String.IsNullOrEmpty(name))
            {
                throw new NameCantBeNullOrEmtyException();
            }

            if (count <= 0)
            {
                throw new ProductCountShouldBeMoreThanZeroException();
            }

            if (price.NumericValue() < 0.10m)
            {
                throw new PriceMustBeHigherException(price);
            }

            for (int i = 0; i < Products.Length; i++)
            {
                if (String.IsNullOrEmpty(Products[i].Name))
                {
                    hasemptySlots = true;
                    index = i;
                }
            }

            if (hasemptySlots)
            {
                Products[index] = new Product(name, price, count);
                return true;
            }
            else
            {
                throw new NoAvailableSlotsException();
            }
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            int i = productNumber - 1;
            bool updated = false;
 
            if (name == Products[i].Name && price.Value.NumericValue() == Products[i].Price.NumericValue() && amount == Products[i].Available)
            {
                throw new ProductNotChangedException();
            }

            if (String.IsNullOrEmpty(name))
            {
                throw new NameCantBeNullOrEmtyException();
            }

            if (price.Value.NumericValue() < 0.10m)
            {
                throw new PriceMustBeHigherException(price.Value);
            }

            if (Products[i].Available != amount)
            {
                Products[i].Available = amount;
                updated = true;
            }

            if (Products[i].Name != name)
            {
                Products[i].Name = name;
                updated = true;
            }

            if (price.HasValue)
            {
                Products[i].Price = price.Value;
                updated = true;
            }

            return updated;
        }

        public bool BuyProduct(int index)
        {
            var product = Products[index -1];
            var price = Products[index -1].Price.NumericValue();
            var balance = Amount.NumericValue();
            var bought = false;

            if (product.Available < 1)
            {
                throw new ProductNotAvailableException();
            }

            if (price > balance)
            {
                throw new NotEnoughBalanceException();
            }
            
            if (balance >= price)
            {
                UpdateProduct(index, product.Name, product.Price, product.Available - 1);
                Amount = Amount.Subtract(product.Price);
                Console.WriteLine($"Thanks for purchasing {product.Name}");
                ReturnMoney();
                bought = true;
            }

            return bought;
        }

        public string ReturnAvailableProducts()
        {
            if (!HasProducts)
            {
                throw new NoProductsAvailableException();
            }

            var list = new List<string>();

            for (int i = 0; i < Products.Length; i++)
            {
                list.Add($"{i+1}.{Products[i]}");
            }

            return String.Join("\n", list);
        }
    }
}
