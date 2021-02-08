namespace ExchangeRatesAPI.Domain.Interfaces
{
    public interface IDateChangeService
    {
        string GetComparativeDateTime(string date, int day);
    }
}