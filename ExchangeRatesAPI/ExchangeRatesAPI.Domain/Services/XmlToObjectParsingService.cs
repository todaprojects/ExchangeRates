using ExchangeRatesAPI.Domain.Factories;
using ExchangeRatesAPI.Domain.Interfaces;
using ExchangeRatesAPI.Domain.Models;
using XmlSerializerFactory = ExchangeRatesAPI.Domain.Factories.XmlSerializerFactory;

namespace ExchangeRatesAPI.Domain.Services
{
    public class XmlToObjectParsingService : IXmlToObjectService
    {
        public ExchangeRate ParseXmlToObject(string responseBody)
        {
            var stringReader = StringReaderFactory.GetInstance(responseBody);

            var xmlSerializer = XmlSerializerFactory.GetInstance();
            
            return (ExchangeRate) xmlSerializer.Deserialize(stringReader);
        }
    }
}