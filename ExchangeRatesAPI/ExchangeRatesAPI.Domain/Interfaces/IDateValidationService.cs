namespace ExchangeRatesAPI.Domain.Interfaces
{
    public interface IDateValidationService
    {
        bool IsValid(string date);
    }
}