using ScooterRental.Exceptions;
using ScooterRental.Validators;
using ScooterRental.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ScooterRental
{
    public class ScooterService : IScooterService
    {
        private List<Scooter> _scooters;

        public ScooterService(List<Scooter> inventory)
        {
            _scooters = inventory;
        }

        public void AddScooter(string id, decimal pricePerMinute)
        {
            Validator.IdValidator(id);

            if (pricePerMinute <= 0)
            {
                throw new InvalidPriceException(pricePerMinute);
            }

            if (_scooters.Any(scooter => scooter.Id == id))
            {
                throw new DuplicateScooterException(id);
            }

            _scooters.Add(new Scooter(id, pricePerMinute));
        }

        public void RemoveScooter(string id)
        {
            var scooter = _scooters.FirstOrDefault(scooter => scooter.Id == id);

            Validator.IdValidator(id);

            if (scooter == null)
            {
                throw new ScooterDoesntExistException(id);
            }

            _scooters.Remove(scooter);
        }

        public IList<Scooter> GetScooters()
        {
            if (_scooters.Count.Equals(0))
            {
                throw new ScooterListIsEmptyExeption();
            }

            return _scooters.ToList();
        }

        public Scooter GetScooterById(string scooterId)
        {
            var scooter = _scooters.FirstOrDefault(scooter => scooter.Id == scooterId);

            Validator.IdValidator(scooterId);

            if (scooter == null)
            {
                throw new ScooterDoesntExistException(scooterId);
            }

            return scooter;
        }

        IList<Scooter> IScooterService.GetScooters()
        {
            throw new System.NotImplementedException();
        }
    }
}
