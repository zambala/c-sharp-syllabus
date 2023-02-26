using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray = {25, 14, 56, 15, 36, 56, 77, 18, 29, 49};

            var indexOfElement36 = -1;
            var indexOfElement29 = -1;

            int find36 = 36;
            int find29 = 29;

            indexOfElement36 = Array.IndexOf(myArray, find36);
            indexOfElement29 = Array.IndexOf(myArray, find29);

            Console.WriteLine("Index position of 36 is: " + indexOfElement36);
            Console.WriteLine("Index position of 29 is: " + indexOfElement29);
        }
    }
}
