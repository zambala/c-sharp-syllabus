using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental.Exceptions
{
    public class ScooterAlreadyRentedException : Exception
    {
        public ScooterAlreadyRentedException(string id) : base($"Scooter With {id} already rented") { }
    }
}
