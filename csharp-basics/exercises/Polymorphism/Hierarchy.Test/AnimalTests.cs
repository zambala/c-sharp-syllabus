using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Hierarchy.Exceptions;
using System;

namespace Hierarchy.Test
{
    [TestClass]
    public class AnimalTests
    {
        private Cat _cat;
        private Tiger _tiger;
        private Zebra _zebra;
        private Mouse _mouse;
        private Meat _meat;
        private Vegetable _vegetable;

        [TestInitialize]
        public void Setup()
        {
            _cat = new Cat("catt", "Cat", 1.1, "Home", "Persian");
            _tiger = new Tiger("Typcho", "Tiger", 167.5, "Asia");
            _zebra = new Zebra("Zeee", "Zebra", 30, "Africa");
            _mouse = new Mouse("steward", "Mouse", 0.25444, "Home");
            _meat = new Meat("Meat", 1);
            _vegetable = new Vegetable("Vegetable", 1);
        }

        [TestMethod]
        public void Feed_FeedCat_MeatAndVegetable_CatEatsBoth()
        {
            //Act
            _cat.Eat(_meat);
            _cat.Eat(_vegetable);

            //Assert
            _cat.FoodEaten.Should().Be(2);
        }

        [TestMethod]
        public void Feed_FeedTiger_Meat_TigerEatsMeat()
        {
            //Act
            _tiger.Eat(_meat);

            //Assert
            _tiger.FoodEaten.Should().Be(1);
        }

        [TestMethod]
        public void Feed_FeedTiger_Vegetable_ThrowsAnimalDoesNotEatThisFoodException()
        {
            //Act
            Action act = () => _tiger.Eat(_vegetable);

            //Assert
            _tiger.FoodEaten.Should().Be(0);
            act.Should().Throw<AnimalDoesNotEatThisFoodException>().WithMessage("Animal Does Not Eat This Food");
        }

        [TestMethod]
        public void Feed_FeedZebra_Vegetable_ZebraEatsVegetables()
        {
            //Act
            _zebra.Eat(_vegetable);

            //Assert
            _zebra.FoodEaten.Should().Be(1);
        }

        [TestMethod]
        public void Feed_FeedZebra_Meat_ThrowsAnimalDoesNotEatThisFoodException()
        {
            //Act
            Action act = () => _zebra.Eat(_meat);

            //Assert
            _zebra.FoodEaten.Should().Be(0);
            act.Should().Throw<AnimalDoesNotEatThisFoodException>().WithMessage("Animal Does Not Eat This Food");
        }

        [TestMethod]
        public void Feed_FeedMouse_Vegetable_MouseEatsVegetables()
        {
            //Act
            _mouse.Eat(_vegetable);

            //Assert
            _mouse.FoodEaten.Should().Be(1);
        }

        [TestMethod]
        public void Feed_FeedMouse_Meat_ThrowsAnimalDoesNotEatThisFoodException()
        {
            //Act
            Action act = () => _mouse.Eat(_meat);

            //Assert
            _mouse.FoodEaten.Should().Be(0);
            act.Should().Throw<AnimalDoesNotEatThisFoodException>().WithMessage("Animal Does Not Eat This Food");
        }
    }
}