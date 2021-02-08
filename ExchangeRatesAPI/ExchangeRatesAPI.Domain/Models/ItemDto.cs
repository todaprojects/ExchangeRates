namespace ExchangeRatesAPI.Domain.Models
{
    public class ItemDto
    {
        public string Currency { get; set; }
        
        public decimal Rate { get; set; }
    }
}