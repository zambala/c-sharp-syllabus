using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Hierarchy.Exceptions;

namespace Hierarchy.Test
{
    [TestClass]
    public class FoodTest
    {
        private Meat _meat;
        private Vegetable _vegetable;

        [TestInitialize]
        public void Setup()
        {
            _meat = new Meat("Meat", 1);
            _vegetable = new Vegetable("Vegetable", 1);
        }

        [TestMethod]
        public void GetFoodType_Meat_ReturnsCorrectType()
        {
            //Arrange
            var expected = "Meat";

            //Act
            var actual = _meat.GetFoodType();

            //Assert
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void GetFoodType_Vegetable_ReturnsCorrectType()
        {
            //Arrange
            var expected = "Vegetable";

            //Act
            var actual = _vegetable.GetFoodType();

            //Assert
            actual.Should().Be(expected);
        }
    }
}