using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Animal
    {
        public string AnimalName { get; }
        public string AnimalType { get; }
        public double AnimalWeight { get; }
        public int FoodEaten { get; protected set; }

        protected Animal(string animalName, string animalType, double animalWeight)
        {
            AnimalName = animalName;
            AnimalType = animalType;
            AnimalWeight = animalWeight;
        }

        public abstract void MakeSound();

        public abstract void Eat(Food food);

        public abstract void AnimalInfo();

        public override string ToString()
        {
            return $"{AnimalType} {AnimalName} weight: {AnimalWeight:F2} ate {FoodEaten} food\n";
        }
    }
}
