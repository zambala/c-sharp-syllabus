using System;
using Hierarchy.Exceptions;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("mouse noise?");
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
                FoodEaten +=  0;
                throw new AnimalDoesNotEatThisFoodException();
            }
        }
    }
}
