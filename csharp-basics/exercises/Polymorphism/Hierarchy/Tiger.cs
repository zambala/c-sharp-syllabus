using System;
using Hierarchy.Exceptions;

namespace Hierarchy
{
    public class Tiger : Feline
    {
        public Tiger(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetFoodType() == "Meat")
            {
                FoodEaten += food.FoodQuantity;
                Console.WriteLine($"{food.GetFoodType()} {FoodEaten}");
            }
            else
            {
                throw new AnimalDoesNotEatThisFoodException();
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar");
        }
    }
}
