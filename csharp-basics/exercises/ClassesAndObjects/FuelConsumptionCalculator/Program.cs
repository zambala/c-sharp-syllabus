using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Car car1 = new Car(0);
            Car car2 = new Car(0);

            Console.Write("Enter Start KM for the first car: ");
            car1._startKilometers = Convert.ToDouble(Console.ReadLine());
            car1 = new Car(car1._startKilometers);

            Console.Write("Enter Start KM for the second car: ");
            car2._startKilometers = Convert.ToDouble(Console.ReadLine());
            car2 = new Car(car2._startKilometers);

            Console.WriteLine();

            for (int i = 0; i < 1; i++)
            {
                Console.Write("Enter End KM for the first car: ");
                car1._endKilometers = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter liters used for 1 car: ");
                car1._liters = Convert.ToDouble(Console.ReadLine());

                car1.FillUp(car1._endKilometers, car1._liters);

                Console.WriteLine();

                Console.Write("Enter End KM for the second car: ");
                car2._startKilometers = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter liters used for 2 car: ");
                car2._liters = Convert.ToDouble(Console.ReadLine());
                car2.FillUp(car2._endKilometers, car2._liters);
            }

            Console.WriteLine();
            Console.WriteLine("Kilometers per liter are " + car1.CalculateConsumption() + " gasHog:" + car1.GasHog());
            Console.WriteLine("Car2 Kilometers per liter are " + car2.CalculateConsumption() + " economyCar:" + car2.EconomyCar());
            Console.ReadKey();
        }
    }
}
