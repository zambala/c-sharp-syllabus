using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            int energyDrinkers = CalculateEnergyDrinkers(NumberedSurveyed);
            double preferCitrus = CalculatePreferCitrus(NumberedSurveyed);

            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("Approximately " + energyDrinkers + " bought at least one energy drink");
            Console.WriteLine(preferCitrus + " of those " + "prefer citrus flavored energy drinks.");
        }

        public static int CalculateEnergyDrinkers(int numberSurveyed)
        {
            int energyDrinkers = (int)(numberSurveyed * PurchasedEnergyDrinks);
            return energyDrinkers;
        }

        public static double CalculatePreferCitrus(int numberSurveyed)
        {
            int preferCitrus = (int)(numberSurveyed * PurchasedEnergyDrinks * PreferCitrusDrinks);
            return preferCitrus;
        }
    }
}
