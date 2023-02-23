using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's menu choice.
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = GetMenu();
            }
        }

        public static bool GetMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CalculateCircleArea();
                    return true;
                case "2":
                    CalculateRectangleArea();
                    return true;
                case "3":
                    CalculateTriangleArea();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }

        public static void CalculateCircleArea()
        {
            decimal radius = 0;

            Console.WriteLine("What is the circle's radius? ");
            radius = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            Console.WriteLine("Enter length? ");
            length = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter width? ");
            width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            Console.WriteLine("Enter length of the triangle's base? ");
            ground = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter triangle's height? ");
            height = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
        }
    }
}
