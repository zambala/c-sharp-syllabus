using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> list = new List<string>(array);

            foreach (string car in list)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            HashSet<string> hashSet = new HashSet<string>(array);

            foreach (string car in hashSet)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            Console.WriteLine("Origination:\n");
            
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("Audi", "Germany");
            dictionary.Add("BMW", "Germany");
            dictionary.Add("Honda", "Japan");
            dictionary.Add("Mercedes", "Germany");
            dictionary.Add("VolksWagen", "Germany");
            dictionary.Add("Tesla", "USA");

            foreach (var car in dictionary)
            {
                Console.WriteLine($"{car.Key} -> {car.Value}");
            }
        }
    }
}
