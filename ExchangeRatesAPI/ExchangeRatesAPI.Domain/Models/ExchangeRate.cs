using System.Collections.Generic;
using System.Xml.Serialization;

namespace ExchangeRatesAPI.Domain.Models
{
    [XmlRoot("ExchangeRates")]
    public class ExchangeRate
    {
        [XmlElement("item")]
        public List<Item> Items { get; set; } = new List<Item>();
    }
}