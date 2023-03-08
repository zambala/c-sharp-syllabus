using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var carList = new List<string>();

            string[] valuesAdded =
            {
                "Audi", "BMW", "Ferrari", "Ford", "Mercedes", "Opel", "Honda", "Kamaz", "Bugatti", "Volvo"
            };

            carList.AddRange(valuesAdded);

            Console.WriteLine(string.Join(",", carList));
            Console.WriteLine();

            carList.Insert(4, "Mazda");

            Console.WriteLine(string.Join(",", carList));
            Console.WriteLine();

            carList[carList.Count - 1] = "RollsRoyce";

            Console.WriteLine(string.Join(",", carList));
            Console.WriteLine();

            Console.WriteLine("List in alphabetical order : \n");
            carList.Sort();

            Console.WriteLine(string.Join(",", carList));
            Console.WriteLine();

            Console.WriteLine("Does my list contain a \"Foobar\"?: " + carList.Contains("Foobar"));
            Console.WriteLine("\n");

            foreach (var car in carList)
            {
                Console.Write(car + " ");
            }

            Console.WriteLine("\n");
        }
    }
}
