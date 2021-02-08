using System.Collections.Generic;
using ExchangeRatesAPI.Domain.Models;

namespace ExchangeRatesAPI.Domain.Interfaces
{
    public interface IExchangeRateService
    {
        string GetComparativeDate(string date);

        IEnumerable<ItemDto> GetExchangeRateChanges(ExchangeRate exchangeRatesRequested,
            ExchangeRate exchangeRatesComparative);
    }
}