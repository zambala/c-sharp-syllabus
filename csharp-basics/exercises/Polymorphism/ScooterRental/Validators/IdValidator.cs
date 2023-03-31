using System.Collections.Generic;
using System;
using ScooterRental.Exceptions;
using System.Linq;

namespace ScooterRental.Validators
{
    public static class Validator
    {
        private static List<Scooter> _scooters = new List<Scooter>();

        public static void IdValidator(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                throw new InvalidIdException();
            }
        }

        public static void ScooterExistsValidator(string scooterId)
        {
            var scooter = _scooters.FirstOrDefault(scooter => scooter.Id == scooterId);

            if (scooter == null)
            {
                throw new ScooterDoesntExistException(scooterId);
            }
        }
    }
}
