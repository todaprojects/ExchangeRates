using System;
using ExchangeRatesAPI.Domain.Interfaces;

namespace ExchangeRatesAPI.Domain.Services
{
    public class DateChangeService : IDateChangeService
    {
        public string GetComparativeDateTime(string date, int day)
        {
            var dateTime = Convert.ToDateTime(date);
            return $"{dateTime.AddDays(day):yyyy.MM.dd}";
        }
    }
}