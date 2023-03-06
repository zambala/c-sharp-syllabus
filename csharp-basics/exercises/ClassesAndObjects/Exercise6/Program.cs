using System;

namespace Exercise6
{
    internal class DogTest
    {
        static void Main(string[] args)
        {
            Dog dog01 = new Dog("Max", true);
            Dog dog02 = new Dog("Rocky", true);
            Dog dog03 = new Dog("Sparky", true);
            Dog dog04 = new Dog("Buster", true);
            Dog dog05 = new Dog("Sam", true);
            Dog dog06 = new Dog("Lady", false);
            Dog dog07 = new Dog("Molly", false);
            Dog dog08 = new Dog("Coco", false);

            dog01.Mother = dog06;
            dog01.Father = dog02;
            dog02.Mother = dog07;
            dog02.Father = dog05;
            dog04.Mother = dog06;
            dog04.Father = dog03;
            dog08.Mother = dog07;
            dog08.Father = dog04;

            Console.WriteLine(dog08.FathersName());
            Console.WriteLine(dog03.FathersName());

            Console.WriteLine(dog04.HasSameMotherAs(dog01));
        }
    }
}
