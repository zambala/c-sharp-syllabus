using System.Collections.Generic;
using System;

namespace ScooterRental.Interfaces
{
    public interface IRentPriceCalculator
    {
        decimal CalculateIncomeForRentedScooter(DateTime startRent, DateTime? endRent, decimal pricePerMinute);
        decimal CalculateIncomeForCompany(List<RentedScooter> rentedScooters, bool includeNotCompleteRentals);
        decimal CalculateAnnualIncome(List<RentedScooter> rentedScooters, int? year, bool includeNotCompleteRentals);
    }
}
