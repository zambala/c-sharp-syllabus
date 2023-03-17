using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Product
    {
        public string Name;
        public double PriceAtStart;
        public int AmountAtStart;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            Name = name;
            PriceAtStart = priceAtStart;
            AmountAtStart = amountAtStart;
        }

        public string PrintProduct()
        {
            return Name + ", price " + String.Format("{0:0.00} EUR", PriceAtStart) + ", available " + AmountAtStart + " items.";
        }

        public void ChangePrice(double newPrice)
        {
            PriceAtStart = newPrice;
        }

        public int ChangeSmallerCount(int newCount)
        {
            return AmountAtStart -= newCount;
        }

        public int ChangeBiggerCount(int newCount)
        {
            return AmountAtStart += newCount;
        }
    }
}
