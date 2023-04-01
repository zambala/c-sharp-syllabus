using System;

namespace VendingMachine.Exceptions
{
    public class CoinNotAcceptedException : Exception
    {
        public CoinNotAcceptedException(Money amount) : base($"Coin: {amount} is not accepted") { }
    }
}
