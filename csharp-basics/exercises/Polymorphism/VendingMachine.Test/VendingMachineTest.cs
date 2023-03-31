using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using VendingMachine.Exceptions;
using System;

namespace VendingMachine.Test
{
    [TestClass]
    public class VendingMachineTest
    {
        private IVendingMachine _machine;
        private Product[] _products;

        [TestInitialize]
        public void Setup()
        {
            _products = new Product[2];
            _machine = new VendingMachine("vender", _products);
        }

        [TestMethod]
        public void InsertCoin_CanInsertCoin()
        {
            //Act
            _machine.InsertCoin(new Money(1,0));

            //Assert
            _machine.Amount.ToString().Should().Be("£1.00");
        }

        [TestMethod]
        public void InsertCoin_WrongCoin_ThrowsCoinNotAcceptedException()
        {
            //Act
            Action act = () => _machine.InsertCoin(new Money(0, 25));

            //Assert
            _machine.Amount.ToString().Should().Be("£0.00");
            act.Should().Throw<CoinNotAcceptedException>().WithMessage("Coin: £0.25 is not accepted" );
        }

        [TestMethod]
        public void ReturnMoney_MoneyIsReturned()
        {
            //Arrange
            _machine.InsertCoin(new Money(1, 0));

            //Act
            var returnAmount = _machine.ReturnMoney();

            //Assert
            Assert.AreEqual(returnAmount.ToString(), "£1.00");
        }

        [TestMethod]
        public void AddProduct_NoNameGiven_ThrowsNameCantBeNullOrEmtyException()
        {
            //Act
            Action act = () => _machine.AddProduct("", new Money(0, 50), 1);

            //Assert
            act.Should().Throw<NameCantBeNullOrEmtyException>().WithMessage("Product should have a name");
        }

        [TestMethod]
        public void AddProduct_ZeroProducts_ThrowsProductCountShouldBeMoreThanZeroException()
        {
            //Act
            Action act = () => _machine.AddProduct("Fanta", new Money(0, 50), 0);

            //Assert
            act.Should().Throw<ProductCountShouldBeMoreThanZeroException>().WithMessage("Atleast one product must be added");
        }

        [TestMethod]
        public void AddProduct_FreeProduct_ThrowsPriceMustBeHigherException()
        {
            //Act
            Action act = () => _machine.AddProduct("Fanta", new Money(0,0), 1);

            //Assert
            act.Should().Throw<PriceMustBeHigherException>().WithMessage("Price must be more than £0.00");
        }

        [TestMethod]
        public void AddProduct_ProductAdded()
        {
            //Arrange
            var expected = new Product("Fanta", new Money(0, 50), 1).ToString();

            //Act
            _machine.AddProduct("Fanta", new Money(0, 50), 1);

            //Assert
            Assert.AreEqual(_products[1].ToString(), expected);
        }

        [TestMethod]
        public void AddProduct_NoEmtySlots_ThrowsNoAvailableSlotsException()
        {
            //Arrange
            _machine.AddProduct("Sprite", new Money(0, 50), 1);
            _machine.AddProduct("Coca-cola", new Money(0, 50), 1);

            //Act
            Action act = () => _machine.AddProduct("Fanta", new Money(0, 50), 1);

            //Assert
            act.Should().Throw<NoAvailableSlotsException>().WithMessage("No slots available");
        }

        [TestMethod]
        public void UpdateProduct_NothingWasChanged_ThrowsProductNotChangedException()
        {
            //Arrange
            _machine.AddProduct("Fanta", new Money(0, 50), 1);

            //Act
            Action act = () => _machine.UpdateProduct(2, "Fanta", new Money(0, 50), 1);

            //Assert
            act.Should().Throw<ProductNotChangedException>().WithMessage("No Changes Added");
        }

        [TestMethod]
        public void UpdateProduct_ChangeName_NameChanged()
        {
            //Arrange
            _machine.AddProduct("Fanta", new Money(0, 50), 1);
            var expected = new Product("Sprite", new Money(0, 50), 1).ToString();

            //Act
            _machine.UpdateProduct(2, "Sprite", new Money(0, 50), 1);

            //Assert
            Assert.AreEqual(_products[1].ToString(), expected);
        }

        [TestMethod]
        public void UpdateProduct_ChangePrice_PriceChanged()
        {
            //Arrange
            _machine.AddProduct("Fanta", new Money(0, 50), 1);
            var expected = new Product("Fanta", new Money(0, 60), 1).ToString();

            //Act
            _machine.UpdateProduct(2, "Fanta", new Money(0, 60), 1);

            //Assert
            Assert.AreEqual(_products[1].ToString(), expected);
        }

        [TestMethod]
        public void UpdateProduct_ChangeAmount_AmountChanged()
        {
            //Arrange
            _machine.AddProduct("Fanta", new Money(0, 50), 1);
            var expected = new Product("Fanta", new Money(0, 50), 2).ToString();

            //Act
            _machine.UpdateProduct(2, "Fanta", new Money(0, 50), 2);

            //Assert
            Assert.AreEqual(_products[1].ToString(), expected);
        }

        [TestMethod]
        public void UpdateProduct_ChangeEveryting_EverthingChanged()
        {
            //Arrange
            _machine.AddProduct("Sprite", new Money(0, 50), 1);
            var expected = new Product("Fanta", new Money(0, 60), 2).ToString();

            //Act
            _machine.UpdateProduct(2, "Fanta", new Money(0, 60), 2);

            //Assert
            Assert.AreEqual(expected, _products[1].ToString());
        }

        [TestMethod]
        public void BuyProduct_ProductBought()
        {
            //Arrange
            _machine.InsertCoin(new Money(1, 0));
            _machine.AddProduct("Sprite", new Money(0, 50), 1);

            //Act
            _machine.BuyProduct(2);

            //Assert
            _products[1].Available.Should().Be(0);
        }

        [TestMethod]
        public void BuyProduct_ProductNotAvailable_throwsProductNotAvailableException()
        {
            //Arrange
            _machine.InsertCoin(new Money(1, 0));
            _machine.AddProduct("Sprite", new Money(0, 50), 1);
            _machine.BuyProduct(2);

            //Act
            Action act = () => _machine.BuyProduct(2);

            //Assert
            act.Should().Throw<ProductNotAvailableException>().WithMessage("Product not available");
        }

        [TestMethod]
        public void BuyProduct_NotEnoughBalance_throwsNotEnoughBalanceException()
        {
            //Arrange
            _machine.InsertCoin(new Money(0, 10));
            _machine.AddProduct("Sprite", new Money(0, 50), 1);

            //Act
            Action act = () => _machine.BuyProduct(2);

            //Assert
            act.Should().Throw<NotEnoughBalanceException>().WithMessage("Not enough balance");
        }

        [TestMethod]
        public void ReturnProduct_NoProductsAvailable_ThrowsNoProductsAvailableException()
        {
            //Act
            Action act = () => _machine.ReturnAvailableProducts();

            //Assert
            act.Should().Throw<NoProductsAvailableException>().WithMessage("No products available");
        }

        [TestMethod]
        public void ReturnProduct_ReturnsListOfProducts()
        {
            //Arrange
            _machine.AddProduct("Sprite", new Money(0, 50), 1);
            _machine.AddProduct("Fanta", new Money(0, 50), 1);
            var expected = "1.Fanta.£0.50|| Available: 1\n2.Sprite.£0.50|| Available: 1";

            //Act
            var actual = _machine.ReturnAvailableProducts();

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}