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

            Console.WriteLine(CheckForDuplicate(stringHashSet));
            Console.ReadKey();
        }

        public static bool CheckForDuplicate(HashSet<string> set)
        {
            return set.Count != set.Distinct().Count();
        }
    }
}
