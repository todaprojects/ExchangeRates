using ExchangeRatesAPI.Domain.Models;

namespace ExchangeRatesAPI.Domain.Interfaces
{
    public interface IXmlToObjectService
    {
        ExchangeRate ParseXmlToObject(string responseBody);
    }
}