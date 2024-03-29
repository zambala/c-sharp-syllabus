﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            var userInput = "name";

            while (userInput.Length >= 0)
            {
                if (userInput.Length > 0)
                {
                    Console.Write("Write a name: ");
                    userInput = Console.ReadLine();
                    names.Add(userInput);
                }
                else
                {
                    var newList = names.Distinct().ToList();
                    Console.WriteLine("Unique name list contains: " + String.Join(" ", newList));
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
}
