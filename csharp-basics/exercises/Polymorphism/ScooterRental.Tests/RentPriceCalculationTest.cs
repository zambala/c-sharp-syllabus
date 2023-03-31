using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScooterRental.Exceptions;
using ScooterRental.Interfaces;

namespace ScooterRental.Tests
{
    [TestClass]
    public class RentPriceCalculationTest
    {
        private IScooterService _scooterService;
        private IRentalCompany _company;
        private IRentPriceCalculator _priceCalculator;
        private List<Scooter> _inventory;
        private List<RentedScooter> _rentedScooters;

        [TestInitialize]
        public void Setup()
        {
            _inventory = new List<Scooter>();
            _scooterService = new ScooterService(_inventory);
            _rentedScooters = new List<RentedScooter>();
            _priceCalculator = new RentPriceCalcualtor();
            _company = new RentalCompany("CompanyName", _rentedScooters, _scooterService, _priceCalculator);
            _scooterService.AddScooter("1", 0.2m);
            _scooterService.AddScooter("2", 0.2m);
            _scooterService.AddScooter("3", 0.2m);
        }

        [TestMethod]
        public void CalculateIncomeForCompany_NotIncludingUnfinishedRentals()
        {
            //arrange
            var rentedScooter = new RentedScooter("1", DateTime.UtcNow.AddMinutes(-10), 0.2m);
            var rentedScooter2 = new RentedScooter("2", DateTime.UtcNow.AddMinutes(-10), 0.2m);
            var rentedScooter3 = new RentedScooter("3", DateTime.UtcNow.AddMinutes(-10), 0.2m);

            _rentedScooters.Add(rentedScooter);
            _rentedScooters.Add(rentedScooter2);
            _rentedScooters.Add(rentedScooter3);

            _company.EndRent("1");
            _company.EndRent("2");

            //act
            var result = _priceCalculator.CalculateIncomeForCompany(_rentedScooters, false);

            //assert
            result.Should().Be(4);
        }

        [TestMethod]
        public void CalculateIncomeForCompany_IncludingUnfinishedRentals()
        {
            //arrange
            var rentedScooter = new RentedScooter("1", DateTime.UtcNow.AddMinutes(-10), 0.2m);
            var rentedScooter2 = new RentedScooter("2", DateTime.UtcNow.AddMinutes(-10), 0.2m);
            var rentedScooter3 = new RentedScooter("3", DateTime.UtcNow.AddMinutes(-10), 0.2m);

            _rentedScooters.Add(rentedScooter);
            _rentedScooters.Add(rentedScooter2);
            _rentedScooters.Add(rentedScooter3);

            _company.EndRent("1");
            _company.EndRent("2");

            //act
            var result = _priceCalculator.CalculateIncomeForCompany(_rentedScooters, true);

            //assert
            result.Should().Be(6);
        }

        [TestMethod]
        public void CalculateAnnualIncomey_NotIncludingUnfinishedRentals()
        {
            //arrange
            var rentedScooter = new RentedScooter("1", DateTime.UtcNow.AddMinutes(-10), 0.2m);
            var rentedScooter2 = new RentedScooter("2", DateTime.UtcNow.AddMinutes(-10), 0.2m);
            var rentedScooter3 = new RentedScooter("3", DateTime.UtcNow.AddYears(-1), 0.2m);

            _rentedScooters.Add(rentedScooter);
            _rentedScooters.Add(rentedScooter2);
            _rentedScooters.Add(rentedScooter3);

            _company.EndRent("1");
            _company.EndRent("2");

            //act
            var result = _priceCalculator.CalculateAnnualIncome(_rentedScooters, 2022, false);

            //assert
            result.Should().Be(4);
        }

        [TestMethod]
        public void CalculateAnnualIncomey_IncludingUnfinishedRentals()
        {
            //arrange
            var rentedScooter = new RentedScooter("1", DateTime.UtcNow.AddMinutes(-10), 0.2m);
            var rentedScooter2 = new RentedScooter("2", DateTime.UtcNow.AddMinutes(-10), 0.2m);
            var rentedScooter3 = new RentedScooter("3", DateTime.UtcNow.AddYears(-1), 0.2m);

            _rentedScooters.Add(rentedScooter);
            _rentedScooters.Add(rentedScooter2);
            _rentedScooters.Add(rentedScooter3);

            _company.EndRent("1");
            _company.EndRent("2");

            //act
            var result = _priceCalculator.CalculateAnnualIncome(_rentedScooters, 2022, true);

            //assert
            result.Should().Be(4);
        }

        [TestMethod]
        public void CalculateAnnualIncomey_NotIncludingUnfinishedRentals_YearIsNull()
        {
            //arrange
            var rentedScooter = new RentedScooter("1", DateTime.UtcNow.AddMinutes(-10), 0.2m);
            var rentedScooter2 = new RentedScooter("2", DateTime.UtcNow.AddMinutes(-10), 0.2m);
            var rentedScooter3 = new RentedScooter("3", DateTime.UtcNow.AddYears(-1), 0.2m);
            rentedScooter3.EndTime = DateTime.UtcNow.AddMonths(-11).AddDays(-20);

            _rentedScooters.Add(rentedScooter);
            _rentedScooters.Add(rentedScooter2);
            _rentedScooters.Add(rentedScooter3);

            _company.EndRent("1");
            _company.EndRent("2");

            //act
            var result = _priceCalculator.CalculateAnnualIncome(_rentedScooters, null, false);

            //assert
            result.Should().Be(244);
        }

        [TestMethod]
        public void CalculateAnnualIncomey_NotIncludingUnfinishedRentals_ThrowsNoScootersREntedException()
        {
            //arrange
            var rentedScooter = new RentedScooter("3", DateTime.UtcNow.AddYears(-1), 0.2m);
            _rentedScooters.Add(rentedScooter);

            //act
            Action act = () => _priceCalculator.CalculateAnnualIncome(_rentedScooters, 2022, false);

            //assert
            act.Should().Throw<NoScootersRentedException>().WithMessage("No scooters were rented");
        }

        [TestMethod]
        public void CalculateAnnualIncomey_IncludingUnfinishedRentals_ThrowsNoScootersREntedException()
        {
            //arrange
            var rentedScooter3 = new RentedScooter("3", DateTime.UtcNow.AddYears(-1), 0.2m);
            rentedScooter3.EndTime = DateTime.UtcNow.AddMonths(-11).AddDays(-20);
            _rentedScooters.Add(rentedScooter3);

            //act
            Action act = () => _priceCalculator.CalculateAnnualIncome(_rentedScooters, 2022, false);

            //assert
            act.Should().Throw<NoScootersRentedException>().WithMessage("No scooters were rented");
        }
    }
}
