using System;

namespace Exercise6
{
    internal class DogTest
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Max", "male", "Lady", "Rocky");
            Dog dog2 = new Dog("Rocky", "male", "Molly", "Sam");
            Dog dog3 = new Dog("Sparky", "male");
            Dog dog4 = new Dog("Buster", "male", "Lady", "Sparky");
            Dog dog5 = new Dog("Sam", "male");
            Dog dog6 = new Dog("Lady", "female");
            Dog dog7 = new Dog("Molly", "female");
            Dog dog8 = new Dog("Coco", "female", "Molly", "Buster");

            Console.WriteLine(dog8.FathersName());
            Console.WriteLine(dog3.FathersName());

            Console.WriteLine(dog4.HasSameMotherAs(dog1));
        }
    }
}
