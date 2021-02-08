using System.Collections.Generic;
using System.Threading.Tasks;
using ExchangeRatesAPI.Domain.Interfaces;
using ExchangeRatesAPI.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeRatesAPI.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExchangeRatesController : Controller
    {
        private readonly IExchangeRateApplication _exchangeRateApplication;

        public ExchangeRatesController(IExchangeRateApplication exchangeRateApplication,
            IDateValidationService dateValidationService)
        {
            _exchangeRateApplication = exchangeRateApplication;
        }

        [HttpGet("{date}")]
        public async Task<IEnumerable<ItemDto>> GetData(string date)
        {
            if (date != "null")
            {
                return await _exchangeRateApplication.GetExchangeRatesAsync(date);
            }

            return null;
        }
    }
}