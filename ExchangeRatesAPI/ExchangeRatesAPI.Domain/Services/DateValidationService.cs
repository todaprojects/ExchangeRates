using System;
using ExchangeRatesAPI.Domain.Interfaces;

namespace ExchangeRatesAPI.Domain.Services
{
    public class DateValidationService : IDateValidationService
    {
        private readonly DateTime _minDate = new DateTime(1993, 6, 25);
        private readonly DateTime _maxDate = new DateTime(2015, 01, 01);

        public bool IsValid(string date)
        {
            var dateTime = Convert.ToDateTime(date);

            return dateTime < _maxDate && dateTime > _minDate;
        }
    }
}