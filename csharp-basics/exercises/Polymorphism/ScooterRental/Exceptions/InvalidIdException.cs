﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental.Exceptions
{
    public class InvalidIdException : Exception
    {
        public InvalidIdException() : base("Id cannot be null or empty") { }
    }
}
