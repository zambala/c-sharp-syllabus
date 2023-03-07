using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            //todo - replace array with an List and print out the results

            List<string> list = new List<string>(array);

            foreach (string car in list)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            //todo - replace array with a HashSet and print out the results

            HashSet<string> hashSet = new HashSet<string>(array);
            foreach (string car in hashSet)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results
        }
    }
}
