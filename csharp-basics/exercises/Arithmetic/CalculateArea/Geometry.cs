using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static decimal AreaOfCircle(decimal radius)
        {
            decimal areaTriangle = (decimal)Math.PI * radius * radius;
            return areaTriangle;
        }

        public static decimal AreaOfRectangle(decimal length, decimal width)
        {
            decimal areaRectangle = length * width;
            return areaRectangle;
        }

        public static decimal AreaOfTriangle(decimal ground, decimal height)
        {
            decimal areaTriangle = ground * height * (decimal)0.5;
            return areaTriangle;
        }
    }
}
