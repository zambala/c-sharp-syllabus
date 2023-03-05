using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Product
    {
        public string name;
        public double _priceAtStart;
        public int amountAtStart;

        public Product(string Name, double PriceAtStart, int AmountAtStart)
        {
            name = Name;
            _priceAtStart = PriceAtStart;
            amountAtStart = AmountAtStart;
        }

        public string PrintProduct()
        {
            return name + ", price " + String.Format("{0:0.00} EUR", _priceAtStart) + ", available " + amountAtStart + " items.";
        }

        public void ChangePrice(double newPrice)
        {
            _priceAtStart = newPrice;
        }

        public int ChangeSmallerCount(int newCount)
        {
            return amountAtStart -= newCount;
        }

        public int ChangeBiggerCount(int newCount)
        {
            return amountAtStart += newCount;
        }
    }
}
