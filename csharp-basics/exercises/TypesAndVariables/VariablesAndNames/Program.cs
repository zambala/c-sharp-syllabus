using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars;
            int drivers;
            int passengers;
            int carsNotDriven;
            int carsDriven;

            double seatsInCar;
            double carpoolCapacity;
            double averagePassengersPerCar;

            cars = 100;
            drivers = 28;
            passengers = 90;
            seatsInCar = 4.00;

            carsNotDriven = cars - drivers;
            carsDriven = cars - carsNotDriven;
            carpoolCapacity = carsDriven * (seatsInCar - 1);
            averagePassengersPerCar = carpoolCapacity / carsDriven;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}