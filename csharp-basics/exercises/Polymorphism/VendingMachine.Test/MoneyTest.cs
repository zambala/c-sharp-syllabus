using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace VendingMachine.Test
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void Money_ReturnCorrectFormat()
        {
            //Arrange
            Money _money = new Money(1, 0);

            //Assert
            Assert.AreEqual(_money.ToString(), "£1.00");
        }

        [TestMethod]
        public void Money_AddMoney()
        {
            //Arrange
            Money _money = new Money(1, 0);

            //Act
            _money.Add(new Money(0, 50));

            //Assert
            Assert.AreEqual(_money.ToString(), "£1.50");
        }

        [TestMethod]
        public void Money_SubtractMoney()
        {
            //Arrange
            Money _money = new Money(1, 0);

            //Act
            _money.Subtract(new Money(0, 50));

            //Assert
            Assert.AreEqual(_money.ToString(), "£0.50");
        }

        [TestMethod]
        public void Money_ReturnNumericValue()
        {
            //Arrange
            Money _money = new Money(1, 50);

            //Act
            var num = _money.NumericValue();

            //Assert
            Assert.AreEqual(num, 1.50m);
        }
    }
}
