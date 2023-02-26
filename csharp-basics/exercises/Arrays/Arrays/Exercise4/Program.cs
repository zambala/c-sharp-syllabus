using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            var find = 1245;

            if (myArray.Contains(find))
            {
                Console.WriteLine("Contains!");
            }
            else
            {
                Console.WriteLine("Does not contain");
            }
        }
    }
}
