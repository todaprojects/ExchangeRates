using System.IO;

namespace ExchangeRatesAPI.Domain.Factories
{
    public static class StringReaderFactory
    {
        public static StringReader GetInstance(string responseBody)
        {
            return new StringReader(responseBody);
        }
    }
}