using System.Collections.Generic;
using System.Linq;
using ExchangeRatesAPI.Domain.Interfaces;
using ExchangeRatesAPI.Domain.Models;

namespace ExchangeRatesAPI.Domain.Services
{
    public class ExchangeRateChangeService : IExchangeRateService
    {
        private const int PreviousDay = -1;
        private readonly IDateChangeService _dateChangeService;

        public ExchangeRateChangeService(IDateChangeService dateChangeService)
        {
            _dateChangeService = dateChangeService;
        }

        public string GetComparativeDate(string date)
        {
            return _dateChangeService.GetComparativeDateTime(date, PreviousDay);
        }

        public IEnumerable<ItemDto> GetExchangeRateChanges(ExchangeRate exchangeRatesRequested,
            ExchangeRate exchangeRatesComparative)
        {
            var items = new List<ItemDto>();

            foreach (var item in exchangeRatesRequested.Items)
            {
                var comparativeItem = exchangeRatesComparative.Items.Find(i => i.Currency == item.Currency);
                if (comparativeItem != null)
                {
                    items.Add(new ItemDto()
                    {
                        Currency = item.Currency,
                        Rate = item.Rate - comparativeItem.Rate
                    });
                }
            }

            return items.OrderByDescending(i => i.Rate);
        }
    }
}