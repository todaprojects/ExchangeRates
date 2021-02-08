using System.Threading.Tasks;

namespace ExchangeRatesAPI.Domain.Interfaces
{
    public interface ISoapServerData
    {
        Task<string> GetExchangeRatesByDateAsync(string date);
    }
}