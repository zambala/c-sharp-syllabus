using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental.Exceptions
{
    public class ScooterDoesntExistException : Exception
    {
        public ScooterDoesntExistException(string id) : base($"Scooter with Id {id} doest exist") { }
    }
}
