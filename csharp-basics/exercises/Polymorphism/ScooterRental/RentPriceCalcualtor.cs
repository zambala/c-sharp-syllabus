using ScooterRental.Interfaces;
using ScooterRental.Exceptions;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ScooterRental
{
    public class RentPriceCalcualtor : IRentPriceCalculator
    {
        private static decimal ReturnDailyLimitOrPricePerDay(decimal pricePerDay, decimal limit)
        {
            if (pricePerDay >= limit)
            {
                return limit;
            }
            else
            {
                return pricePerDay;
            }
        }

        public decimal CalculateIncomeForRentedScooter(DateTime startRent, DateTime? endRent, decimal pricePerMinute)
        {
            var maxPrice = 20m;
            var price = 0m;

            if (startRent.Date == endRent.Value.Date)
            {
                TimeSpan timeSpan = endRent.Value - startRent;
                var tempPrice = (decimal)timeSpan.TotalMinutes * pricePerMinute;

                price = ReturnDailyLimitOrPricePerDay(tempPrice, maxPrice);
            }

            if (startRent.Date != endRent.Value.Date)
            {
                var totalDays = (endRent.Value.Date - startRent.Date).TotalDays;
                var firstDayPrice = (1440 - (decimal)startRent.TimeOfDay.TotalMinutes) * pricePerMinute;
                var lastDayPrice = (1440 - (decimal)endRent.Value.TimeOfDay.TotalMinutes) * pricePerMinute;

                for (int i = 0; i <= totalDays; i++)
                {
                    if (i == 0)
                    {
                        price += ReturnDailyLimitOrPricePerDay(firstDayPrice, maxPrice);
                    }
                    else if (i == totalDays)
                    {
                        price += ReturnDailyLimitOrPricePerDay(lastDayPrice, maxPrice);
                    }
                    else
                    {
                        price += maxPrice;
                    }
                }
            }

            return Math.Round(price, 2);
        }

        public decimal CalculateIncomeForCompany(List<RentedScooter> rentedScooters, bool includeNotCompleteRentals)
        {
            decimal result = 0;

            if (includeNotCompleteRentals == false)
            {
                result = rentedScooters.Where(s => s.EndTime.HasValue).Sum(s => CalculateIncomeForRentedScooter(s.StartTime, s.EndTime, s.PricePerMinute));
            }
            else
            {
                foreach (var rented in rentedScooters)
                {
                    if (!rented.EndTime.HasValue)
                    {
                        rented.EndTime = DateTime.UtcNow;
                    }
                    result += CalculateIncomeForRentedScooter(rented.StartTime, rented.EndTime, rented.PricePerMinute);
                }
            }
            return Math.Round(result, 2);
        }

        public decimal CalculateAnnualIncome(List<RentedScooter> rentedScooters, int? year, bool includeNotCompleteRentals)
        {
            var result = 0m;

            if (year == null || year == ' ')
            {
                if (rentedScooters.Count < 1)
                {
                    throw new NoScootersRentedException();
                }
                result = CalculateIncomeForCompany(rentedScooters, includeNotCompleteRentals);
            }

            else
            {
                var rentalsFilteredByYear = rentedScooters.FindAll(s => s.StartTime.Year == year);

                if (rentalsFilteredByYear.Count < 1)
                {
                    throw new NoScootersRentedException();
                }

                result = CalculateIncomeForCompany(rentalsFilteredByYear, includeNotCompleteRentals);
            }

            return Math.Round(result, 2);
        }
    }
}
