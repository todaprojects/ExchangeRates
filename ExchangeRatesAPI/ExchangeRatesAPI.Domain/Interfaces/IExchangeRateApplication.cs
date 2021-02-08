using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeRatesAPI.Domain.Models;

namespace ExchangeRatesAPI.Domain.Interfaces
{
    public interface IExchangeRateApplication
    {
        Task<IEnumerable<ItemDto>> GetExchangeRatesAsync(string date);
    }
}