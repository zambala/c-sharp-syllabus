using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringHashSet = new HashSet<string>();

            stringHashSet.Add("aaaa");
            stringHashSet.Add("bbbb");
            stringHashSet.Add("cccc");
            stringHashSet.Add("dddd");
            stringHashSet.Add("eeee");

            foreach (var str in stringHashSet)
            {
                Console.WriteLine(str);
            }

            stringHashSet.Clear();

            Console.WriteLine("Trying to add the same value 5 times...");
            stringHashSet.Add("same");
            stringHashSet.Add("same");
            stringHashSet.Add("same");
            stringHashSet.Add("same");
            stringHashSet.Add("same");

            Console.WriteLine("The HashSet now contains:");

            foreach (var entry in stringHashSet)
            {
                Console.WriteLine(entry);
            }

            Console.ReadKey();
        }
    }
}
