using System.Xml.Serialization;
using ExchangeRatesAPI.Domain.Models;

namespace ExchangeRatesAPI.Domain.Factories
{
    public static class XmlSerializerFactory
    {
        private static XmlSerializer _xmlSerializerInstance;

        public static XmlSerializer GetInstance()
        {
            return _xmlSerializerInstance ??=
                new XmlSerializer(typeof(ExchangeRate));
        }
    }
}