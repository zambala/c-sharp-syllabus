using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Point
    {
        public int _x;
        public int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public static void SwapPoints(ref Point p1, ref Point p2)
        {
            (p1, p2) = (p2, p1);
        }
    }
}
