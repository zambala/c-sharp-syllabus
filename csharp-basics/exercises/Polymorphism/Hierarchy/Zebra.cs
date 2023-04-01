using System;
using Hierarchy.Exceptions;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        
        public Zebra(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("zebra noise?");
        }

        public override void Eat(Food food)
        {
            if (food.GetFoodType() == "Vegetable")
            {
                FoodEaten += food.FoodQuantity;
                Console.WriteLine($"{food.GetFoodType()} {FoodEaten}");
            }
            else
            {
                throw new AnimalDoesNotEatThisFoodException();
            }
        }
    }
}
