using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    public class Smoothie
    {
        private string[] _ingredients;

        private decimal ProductPrice(string fruit)
        {
            Dictionary<string, decimal> PriceList = new Dictionary<string, decimal>();

            PriceList.Add("Strawberries", (decimal)1.50);
            PriceList.Add("Banana", (decimal)0.50);
            PriceList.Add("Mango", (decimal)2.50);
            PriceList.Add("Blueberries", (decimal)1.00);
            PriceList.Add("Raspberries", (decimal)1.00);
            PriceList.Add("Apple", (decimal)1.75);
            PriceList.Add("Pineapples", (decimal)3.50);

            if (!PriceList.TryGetValue(fruit, out decimal value))
            {
                return 0;
            }

            return value;
        }

        public string[] Ingredients
        {
            get => _ingredients;
            set => _ingredients = value;
        }

        public decimal GetPrice()
        {
            return Math.Round(GetCost() * (decimal)1.5 + GetCost(), 2);
        }

        public decimal GetCost()
        {
            decimal ingredientPrice = 0;

            foreach (var ingredient in _ingredients)
            {
                ingredientPrice += ProductPrice(ingredient);
            }

            return ingredientPrice;
        }

        public string GetName()
        {
            string[] filteredIngredients = filterFruitNames(_ingredients);

            if (filteredIngredients.Length == 1)
            {
                return filteredIngredients[0] + " Smoothie";
            }

            return String.Join(" ", filteredIngredients) + " Fusion";
        }

        private string[] filterFruitNames(string[] ingredients)
        {
            _ingredients = ingredients;
            List<string> fruits = new List<string>();

            foreach (var item in ingredients)
            {

                if (item.Contains("ies"))
                {
                    fruits.Add(item.Substring(0, item.Length - 3) + 'y');
                }
                else
                {
                    fruits.Add(item);
                }
            }

            return fruits.ToArray();
        }

        public Smoothie(string[] ingredients)
        {
            _ingredients = ingredients;
        }

    }
}
