using System.Xml.Serialization;

namespace ExchangeRatesAPI.Domain.Models
{
    [XmlType("item")]
    public class Item
    {
        [XmlElement("date")]
        public string Date { get; set; }
        
        [XmlElement("currency")]
        public string Currency { get; set; }
        
        [XmlElement("rate")]
        public decimal Rate { get; set; }
    }
}