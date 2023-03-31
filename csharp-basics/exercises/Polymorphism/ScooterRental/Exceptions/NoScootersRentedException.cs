using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental.Exceptions
{
    public class NoScootersRentedException : Exception
    {
        public NoScootersRentedException() : base("No scooters were rented") { }
    }
}
