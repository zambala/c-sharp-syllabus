using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using ScooterRental.Exceptions;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ScooterRental.Test
{
    [TestClass]
    public class ScooterServiceTest
    {
        private IScooterService _scooterService;
        private List<Scooter> _inventory;

        [TestInitialize]
        public void Setup()
        {
            _inventory = new List<Scooter>();
            _scooterService = new ScooterService(_inventory);
        }

        [TestMethod]
        public void AddScooter_AddValidScooter_ScooterAdded()
        {
            //Act
            _scooterService.AddScooter("1", 0.2m);

            //Assert
            _inventory.Count.Should().Be(1);
        }     
        
        [TestMethod]
        public void AddScooter_AddScooterTwice_ThrowsDublicateScooterExeption()
        {
            //Act
            _scooterService.AddScooter("1", 0.2m);
            Action act = () => _scooterService.AddScooter("1", 0.2m);

            //Assert
            act.Should().Throw<DuplicateScooterException>().WithMessage("Scooter with ID 1 already exists");
        }

        [TestMethod]
        public void AddScooter_AddScooterWithNegtiveOrZeroPrice_ThrowInvalidPriceException()
        {
            //Act
            Action act = () => _scooterService.AddScooter("1", -0.2m);

            //Assert
            act.Should().Throw<InvalidPriceException>().WithMessage("Given price -0.2 not valid");
        }

        [TestMethod]
        public void AddScooter_AddScooterWithNullOrEmptyId_ThrowInvalideIdException()
        {
            //Act
            Action act = () => _scooterService.AddScooter("", 0.2m);

            //Assert
            act.Should().Throw<InvalidIdException>().WithMessage("Id cannot be null or empty");
        }

        [TestMethod]
        public void RemoveScooter_ScooterExists_ScooterIsRemoved()
        {
            //Act
            _scooterService.AddScooter("1", 0.2m);
            _scooterService.RemoveScooter("1");

            //Assert
            _inventory.Any(scooter => scooter.Id == "1").Should().BeFalse();
            _inventory.Count.Should().Be(0);
        }

        [TestMethod]
        public void RemoveScooter_ScooterDeosntExists_ThrowsScooterDoesntExistException()
        {
            //Act
            Action act = () => _scooterService.RemoveScooter("1");

            //Assert
            act.Should().Throw<ScooterDoesntExistException>().WithMessage("Scooter with Id 1 doest exist");
        }

        [TestMethod]
        public void RemoveScooter_NullOrEmptyIdGiven_ThrowInvalideIdException()
        {
            //Act
            Action act = () => _scooterService.AddScooter("", 0.2m);

            //Assert
            act.Should().Throw<InvalidIdException>().WithMessage("Id cannot be null or empty");
        }

        [TestMethod]
        public void GetScooters_ScooterListIsEmpty_ThrowScooterListIsEmptyExeption()
        {
            //Assert
            Action act = () => _scooterService.GetScooters().Should().HaveCount(0);
            act.Should().Throw<ScooterListIsEmptyExeption>().WithMessage("No scooters available"); 
        }

        [TestMethod]
        public void GetScooters_ScooterList_ReturnScooterList()
        {
            //Arrange
            _inventory.Add(new Scooter("1", 0.2m));
            _inventory.Add(new Scooter("2", 0.2m));

            //Act
            var scooerList = _scooterService.GetScooters();

            //Assert
            scooerList.Should().ContainEquivalentOf(new Scooter("1", 0.2m));
            scooerList.Should().ContainEquivalentOf(new Scooter("2", 0.2m));
            scooerList.Should().HaveCount(2);
            scooerList.Should().OnlyHaveUniqueItems();          
        }

        public void GetScooters_ScooterListCantBeModified()
        {
            //Arrange
            _inventory.Add(new Scooter("1", 0.2m));

            //Act
            var scooerList = _scooterService.GetScooters();
            scooerList.Add(new Scooter("2", 0.2m));
            var scooterList2 = _scooterService.GetScooters();

            //Assert
            scooterList2.Should().HaveCount(1);
        }

        [TestMethod]
        public void GetScootersById_IdDoesntExist_ThrowsScooterDoesntExistException()
        {
            //Act
            Action act = () => _scooterService.GetScooterById("2");

            //Assert
            act.Should().Throw<ScooterDoesntExistException>().WithMessage("Scooter with Id 2 doest exist");
        }

        [TestMethod]
        public void GetScootersById_InvalidId_ThrowInvalidIdExpetion()
        {
            //Arrange
            _scooterService.AddScooter("1", 0.2m); 
            //Act
            Action act = () => _scooterService.GetScooterById("");

            //Assert
            act.Should().Throw<InvalidIdException>().WithMessage("Id cannot be null or empty");
        }

        [TestMethod]
        public void GetScootersById_RetrunsScooter()
        {
            //Arrange
            _scooterService.AddScooter("1", 0.2m);

            //Act
            Scooter scooter1 = _scooterService.GetScooterById("1");

            //Assert
            string idExpected = "1";
            string scooter1Id = scooter1.Id;
            scooter1Id.Should().Be(idExpected);
        }
    }
}
