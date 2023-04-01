using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; }

        protected Mammal(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight)
        {
            LivingRegion = livingRegion;
        }

        public override void AnimalInfo()
        {
            Console.WriteLine($"{AnimalType} {AnimalName} {AnimalWeight} {LivingRegion}");
        }

        public override string ToString()
        {
            return $"{AnimalType} {AnimalName} Weight: {AnimalWeight:F2} lives at: {LivingRegion} ate {FoodEaten} food\n";
        }
    }
}
