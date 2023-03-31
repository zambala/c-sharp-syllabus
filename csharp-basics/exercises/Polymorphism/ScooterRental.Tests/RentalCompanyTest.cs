using System.Collections.Generic;
using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScooterRental.Exceptions;
using ScooterRental.Interfaces;

namespace ScooterRental.Tests
{
    [TestClass]
    public class RentalCompanyTest
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
        public void StartRent_StartScooterRent_ScooterIsRented()
        {
            //Act
            _company.StartRent("1");

            //Asserts
            _scooterService.GetScooterById("1").IsRented.Should().BeTrue();
        }

        [TestMethod]
        public void StartRent_InvalidId_ThrowInvalidIdExpetion()
        {
            //Act
            Action act = () => _company.StartRent("");

            //Assert
            act.Should().Throw<InvalidIdException>().WithMessage("Id cannot be null or empty");
        }

        [TestMethod]
        public void StartRent_ScooterDeosntExists_ThrowsScooterDoesntExistException()
        {
            //Act
            Action act = () => _company.StartRent("4");

            //Assert
            act.Should().Throw<ScooterDoesntExistException>().WithMessage("Scooter with Id 4 doest exist");
        }

        [TestMethod]
        public void StartRent_ScooterAlreadyRented_ThrowsScooterAlreadyRentedException()
        {
            var scooter = _scooterService.GetScooterById("1");
            var rentedScooter = new RentedScooter("1", DateTime.UtcNow, 0.2m);
            scooter.IsRented = true;

            //Act
            _rentedScooters.Add(rentedScooter);
            Action act = () => _company.StartRent("1");

            //Assert
            act.Should().Throw<ScooterAlreadyRentedException>().WithMessage("Scooter With 1 already rented");
        }

        [TestMethod]
        public void EndRent_EndScooterRent_ScooterIsReturned()
        {
            //Arange
            var scooter = _scooterService.GetScooterById("1");
            var rentedScooter = new RentedScooter("1", DateTime.UtcNow, 0.2m);
            scooter.IsRented = true;

            //Act
            _rentedScooters.Add(rentedScooter);
            _company.EndRent("1");

            //Assert
            scooter.IsRented.Should().BeFalse();
            rentedScooter.EndTime.HasValue.Should().BeTrue();
        }

        [TestMethod]
        public void EndRent_InvalidId_ThrowInvalidIdExpetion()
        {
            //Act
            Action act = () => _company.EndRent("");

            //Assert
            act.Should().Throw<InvalidIdException>().WithMessage("Id cannot be null or empty");
        }

        [TestMethod]
        public void EndRent_ScooterDeosntExists_ThrowsScooterDoesntExistException()
        {
            //Act
            Action act = () => _company.EndRent("4");

            //Assert
            act.Should().Throw<ScooterDoesntExistException>().WithMessage("Scooter with Id 4 doest exist");
        }

        [TestMethod]
        public void EndRent_EndScooterRent_SameDayReturn()
        {
            //Arange
            var scooter = _scooterService.GetScooterById("1");
            var rentedScooter = new RentedScooter("1", DateTime.UtcNow.AddMinutes(-10), 0.2m);
            _rentedScooters.Add(rentedScooter);

            //Act
            var result = _company.EndRent("1");

            //Assert
            scooter.IsRented.Should().BeFalse();
            rentedScooter.EndTime.HasValue.Should().BeTrue();
            result.Should().Be(2);
        }

        [TestMethod]
        public void EndRent_EndScooterRent_24hReturn()
        {
            //Arange
            var scooter = _scooterService.GetScooterById("1");
            var rentedScooter = new RentedScooter("1", DateTime.UtcNow.AddDays(-1), 0.2m);
            _rentedScooters.Add(rentedScooter);

            //Act
            var result = _company.EndRent("1");

            //Assert
            scooter.IsRented.Should().BeFalse();
            rentedScooter.EndTime.HasValue.Should().BeTrue();
            result.Should().Be(40);
        }

        [TestMethod]
        public void EndRent_EndScooterRent_15DayReturn()
        {
            //Arange
            var scooter = _scooterService.GetScooterById("1");
            var rentedScooter = new RentedScooter("1", DateTime.UtcNow.AddDays(-15), 0.2m);
            _rentedScooters.Add(rentedScooter);

            //Act
            var result = _company.EndRent("1");

            //Assert
            scooter.IsRented.Should().BeFalse();
            rentedScooter.EndTime.HasValue.Should().BeTrue();
            result.Should().Be(320);
        }

        [TestMethod]
        public void CalculateIncome_CalculateAnnualIncome()
        {
            //Arange
            var scooter1 = _scooterService.GetScooterById("1");
            var scooter2 = _scooterService.GetScooterById("2");

            scooter1.IsRented = true;
            scooter2.IsRented = true;

            var rentedScooter1 = new RentedScooter("1", DateTime.UtcNow.AddDays(-15), 0.2m);
            var rentedScooter2 = new RentedScooter("2", DateTime.UtcNow.AddMinutes(-10), 0.2m);


            _rentedScooters.Add(rentedScooter1);
            _rentedScooters.Add(rentedScooter2);

            _company.EndRent("2");

            //Act
            var result = _company.CalculateIncome(2022, true);

            //Assert
            result.Should().Be(322);
        }
    }
}
