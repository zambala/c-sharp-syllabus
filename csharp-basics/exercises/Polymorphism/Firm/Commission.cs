using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    internal class Commission : Hourly
    {
        private double _totalSales;
        private double _comissionRate;
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _comissionRate = commissionRate;
            _totalSales = 0;
        }

        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            var payment = base.Pay() + _comissionRate * _totalSales;
            _totalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nSales: " + _totalSales;
            return result;
        }
    }
}
