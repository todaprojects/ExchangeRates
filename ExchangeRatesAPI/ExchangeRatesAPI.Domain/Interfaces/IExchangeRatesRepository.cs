using System.Threading.Tasks;
using ExchangeRatesAPI.Domain.Models;

namespace ExchangeRatesAPI.Domain.Interfaces
{
    public interface IExchangeRatesRepository
    {
        Task<ExchangeRate> GetExchangeRatesAsync(string date);
    }
}