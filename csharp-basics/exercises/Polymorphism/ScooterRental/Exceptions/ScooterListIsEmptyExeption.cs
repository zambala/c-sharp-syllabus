﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental.Exceptions
{
    public class ScooterListIsEmptyExeption : Exception
    {
        public ScooterListIsEmptyExeption() : base("No scooters available") { }
    }
}
