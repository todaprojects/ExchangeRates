using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeRatesAPI.Domain.Interfaces;
using ExchangeRatesAPI.Domain.Models;

namespace ExchangeRatesAPI.Application
{
    public class ExchangeRateApplication : IExchangeRateApplication
    {
        private readonly IExchangeRatesRepository _exchangeRatesRepository;
        private readonly IDateValidationService _dateValidationService;
        private readonly IExchangeRateService _exchangeRateService;

        public ExchangeRateApplication(IExchangeRatesRepository exchangeRatesRepository,
            IDateValidationService dateValidationService,
            IExchangeRateService exchangeRateService)
        {
            _exchangeRatesRepository = exchangeRatesRepository;
            _dateValidationService = dateValidationService;
            _exchangeRateService = exchangeRateService;
        }

        public async Task<IEnumerable<ItemDto>> GetExchangeRatesAsync(string date)
        {
            if (!_dateValidationService.IsValid(date)) return null;

            var exchangeRatesRequested = await _exchangeRatesRepository.GetExchangeRatesAsync(date);

            var exchangeRatesComparative =
                await _exchangeRatesRepository.GetExchangeRatesAsync(_exchangeRateService.GetComparativeDate(date));

            return _exchangeRateService.GetExchangeRateChanges(exchangeRatesRequested, exchangeRatesComparative);
        }
    }
}