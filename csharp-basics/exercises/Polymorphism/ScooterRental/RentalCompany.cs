using ScooterRental.Validators;
using ScooterRental.Exceptions;
using ScooterRental.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        public string Name { get; }

        private List<RentedScooter> _rentedScooterList;

        private IScooterService _scooterService;

        private readonly IRentPriceCalculator _calculateRent;

        public RentalCompany(string name, List<RentedScooter> rentedScooterList, IScooterService scooterService, IRentPriceCalculator calculateRent)
        {
            Name = name;
            _rentedScooterList = rentedScooterList;
            _scooterService = scooterService;
            _calculateRent = calculateRent;
        }

        public void StartRent(string id)
        {
            Validators.Validator.IdValidator(id);

            var scooter = _scooterService.GetScooterById(id);

            if (scooter == null)
            {
                throw new ScooterDoesntExistException(id);
            }

            if (_rentedScooterList.Any(s => s.Id == id))
            {
                throw new ScooterAlreadyRentedException(id);
            }

            scooter.IsRented = true;
            _rentedScooterList.Add(new RentedScooter(scooter.Id, DateTime.UtcNow, scooter.PricePerMinute));
        }

        public decimal EndRent(string id)
        {
            Validators.Validator.IdValidator(id);

            var scooter = _scooterService.GetScooterById(id);

            if (scooter == null)
            {
                throw new ScooterDoesntExistException(id);
            }

            var rentedScooter = _rentedScooterList.FirstOrDefault(s => s.Id == id && !s.EndTime.HasValue);
            rentedScooter.EndTime = DateTime.UtcNow;
            scooter.IsRented = false;

            var price = _calculateRent.CalculateIncomeForRentedScooter(rentedScooter.StartTime, rentedScooter.EndTime, rentedScooter.PricePerMinute);

            return price;
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            return _calculateRent.CalculateAnnualIncome(_rentedScooterList, year, includeNotCompletedRentals);
        }
    }
}
