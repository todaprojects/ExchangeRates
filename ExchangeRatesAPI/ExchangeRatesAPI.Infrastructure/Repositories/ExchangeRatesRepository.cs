using System.Threading.Tasks;
using ExchangeRatesAPI.Domain.Interfaces;
using ExchangeRatesAPI.Domain.Models;

namespace ExchangeRatesAPI.Infrastructure.Repositories
{
    public class ExchangeRatesRepository : IExchangeRatesRepository
    {
        private readonly ISoapServerData _soapServerData;
        private readonly IXmlToObjectService _xmlToObjectService;

        public ExchangeRatesRepository(ISoapServerData soapServerData, IXmlToObjectService xmlToObjectService)
        {
            _soapServerData = soapServerData;
            _xmlToObjectService = xmlToObjectService;
        }

        public async Task<ExchangeRate> GetExchangeRatesAsync(string date)
        {
            var xmlString = await _soapServerData.GetExchangeRatesByDateAsync(date);

            return _xmlToObjectService.ParseXmlToObject(xmlString);
        }
    }
}