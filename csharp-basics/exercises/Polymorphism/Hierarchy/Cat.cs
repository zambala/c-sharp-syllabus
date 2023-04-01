using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Cat : Feline
    {
        public string CatBreed { get; }

        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string catBreed)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
            CatBreed = catBreed;
        }

        public override void Eat(Food food)
        {
            FoodEaten += food.FoodQuantity;
            Console.WriteLine($"{food.GetFoodType()} {FoodEaten}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public override void AnimalInfo()
        {
            Console.WriteLine($"{AnimalType} {AnimalName} {AnimalWeight} {LivingRegion} {CatBreed}");
        }

        public override string ToString()
        {
            return $"{AnimalType} {AnimalName}, {CatBreed},weight: {AnimalWeight:F2} lives at: {LivingRegion} ate {FoodEaten} food\n";
        }
    }
}
