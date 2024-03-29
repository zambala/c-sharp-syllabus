﻿using System;

namespace VendingMachine
{
    public struct Money
    {
        public int Euros { get; set; }
        public int Cents { get; set; }
        public Money(int euros, int cents)
        {
            Euros = euros;
            Cents = cents;
        }

        public Money Add(Money amount)
        {
            return new Money(Euros + amount.Euros, Cents + amount.Cents);
        }

        public Money Subtract(Money amount)
        {
            return new Money(Euros - amount.Euros, Cents - amount.Cents);
        }

        public override string ToString()
        {
            return String.Format("{0:C}", Euros + Cents * 0.01);
        }

        public decimal GetNumericValueInCents()
        {
            return Euros * 100 + Cents;
        }
    }
}
