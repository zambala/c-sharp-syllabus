using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Body Mass Index (BMI) Calculation");

            Console.WriteLine("Enter a weight (kg):");
            var weight = Convert.ToDouble(Console.ReadLine()) * 2.20462262185;

            Console.WriteLine("Enter a height (m):");
            var height = Convert.ToDouble(Console.ReadLine()) * 39.37;

            double bmi = weight * 703 / (height * height);

            string weightStatus;

            if (bmi < 18.5)
            {
                weightStatus = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                weightStatus = "Healthy Weight";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                weightStatus = "Overweight";
            }
            else
            {
                weightStatus = "Obesity";
            }
            Console.WriteLine($"BMI: {bmi:0.#}");
            Console.WriteLine($"Weight status:{weightStatus}");
        }
    }
}
