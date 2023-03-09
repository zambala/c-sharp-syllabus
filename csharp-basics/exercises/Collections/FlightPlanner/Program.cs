using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";

        private static void Main(string[] args)
        {
            string[] readText = File.ReadAllLines(Path);
            Dictionary<string, string> flightDictionary = ArrayToDictionary(readText);

            List<string> CityList = new List<string>();

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine(ReturnDepartures(flightDictionary));

                Console.Write("\nDeparture city: ");
                input = Console.ReadLine();


                if (flightDictionary.ContainsKey(input))
                {
                    CityList.Add(input);
                    Console.WriteLine("\nNext city to fly to:");
                    Console.WriteLine($"Choose from: {flightDictionary[input]}");

                    var nextCity = Console.ReadLine();
                    CityList.Add(nextCity);

                    do
                    {
                        Console.WriteLine("\nNext city to fly to:");
                        Console.WriteLine($"Choose from: {flightDictionary[nextCity]}");
                        nextCity = Console.ReadLine();
                        CityList.Add(nextCity);
                    }
                    while (nextCity != input);

                    Console.WriteLine("\nYou made a roundtrip:");

                    foreach (var destination in CityList)
                    {
                        Console.WriteLine(destination);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            else if (input == "#")
            {
                Console.WriteLine("GoodBye");
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }

            Console.ReadKey();
        }

        public static string ReturnDepartures(Dictionary<string, string> flightDictionary)
        {
            string departures = "";

            foreach (var flight in flightDictionary)
            {
                departures += "Departure: " + flight.Key + ".\n";
            }

            return departures;
        }

        public static Dictionary<string, string> ArrayToDictionary(string[] flights)
        {
            Dictionary<string, string> flightDictionary = new Dictionary<string, string>();

            foreach (var flight in flights)
            {
                string[] flightArray = flight.Replace(" -> ", "-").Split('-');

                for (int i = 0; i < flightArray.Length; i++)
                {
                    string elementTrim = flightArray[i].Trim();
                    flightArray[i] = elementTrim;
                }

                if (!flightDictionary.ContainsKey(flightArray[0]))
                {
                    flightDictionary.Add(flightArray[0], flightArray[1]);
                }
                else
                {
                    flightDictionary[flightArray[0]] += $",{flightArray[1]}";
                }
            }

            return flightDictionary;
        }
    }
}
