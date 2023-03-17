using System;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);

            Console.WriteLine("Before swap: \n");
            Console.WriteLine("(" + p1._x + ", " + p1._y + ")");
            Console.WriteLine("(" + p2._x + ", " + p2._y + ")");

            Point.SwapPoints(ref p1, ref p2);

            Console.WriteLine("\nAfter swap:\n");
            Console.WriteLine("(" + p1._x + ", " + p1._y + ")");
            Console.WriteLine("(" + p2._x + ", " + p2._y + ")");
            Console.ReadKey();
        }
    }
}
