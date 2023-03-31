using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        private static void Main(string[] args)
        {
            var cat = new Cat("Kitty", "grey", 1.1, "Home", "Persian");
            var tiger = new Tiger("Typcho", "Tiger", 167.5, "Asia");
            var mouse = new Mouse("steward", "Mouse", 0.25444, "Home");
            var zebra = new Zebra("Zeee", "Zebra", 30, "Africa");
            var animals = new List<Animal>
            {
                cat, mouse, tiger, zebra,
            };

            var veg = new Vegetable("Vegetable", 1);
            var meat = new Meat("Meat", 1);

            foreach (var animal in animals)
            {
                animal.AnimalInfo();
                animal.MakeSound();
                animal.Eat(veg);
                animal.Eat(meat);
                Console.WriteLine(animal);
            }

            Console.ReadKey();
        }
    }
}