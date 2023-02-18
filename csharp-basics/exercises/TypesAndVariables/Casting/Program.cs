using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Console.ReadKey();
        }

        static void First()
        {
            string a = "1";
            int b = 2;
            int c = 3;
            double d = 4.00;
            int e = 5;

            //fixme - should be 15 :|
            int sum = int.Parse(a) + b + c + (int)d + e;
            Console.WriteLine(sum);
        }

        static void Second()
        {
            string a = "1";
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;

            //fixme - should be 15.5 :| 
            float sum = float.Parse(a) + (float)b + (float)c + (float)d + e;
            Console.WriteLine(sum);
        }
    }
}
