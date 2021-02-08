using System.Threading.Tasks;
using ExchangeRates;
using ExchangeRatesAPI.Domain.Interfaces;
using static ExchangeRates.ExchangeRatesSoapClient;

namespace ExchangeRatesAPI.Infrastructure.Data
{
    public class SoapServerData : ISoapServerData
    {
        private readonly ExchangeRatesSoapClient _soapClient =
            new ExchangeRatesSoapClient(EndpointConfiguration.ExchangeRatesSoap);

        public async Task<string> GetExchangeRatesByDateAsync(string date)
        {
            return await _soapClient.getExchangeRatesByDate_XmlStringAsync(date);
        }
    }
}