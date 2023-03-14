using System;

namespace Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|Ingredient   | Price\n" +
                              " --------------------\n" +
                              "|Strawberries |£1.50\n" +
                              "|Banana       |£0.50\n" +
                              "|Mango        |£2.50\n" +
                              "|Blueberries  |£1.00\n" +
                              "|Raspberries  |£1.00\n" +
                              "|Apple        |£1.75\n" +
                              "|Pineapple    |£3.50\n" +
                              "Choice is yours\n");

            var fruitList = Console.ReadLine();

            Smoothie s1 = new Smoothie(fruitList.Split(" "));

            Console.WriteLine(String.Join(", ", s1.Ingredients));
            Console.WriteLine($"Cost for ingredient: £{Math.Round(s1.GetCost(), 2)}");
            Console.WriteLine($"Total price for smoothie: £{s1.GetPrice()}");
            Console.WriteLine(s1.GetName());
            Console.ReadKey();
        }
    }
}
