using ExchangeRatesAPI.Domain.Interfaces;
using ExchangeRatesAPI.Domain.Services;
using ExchangeRatesAPI.Infrastructure.Data;
using ExchangeRatesAPI.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ExchangeRatesAPI.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddScoped<ISoapServerData, SoapServerData>();
            services.AddScoped<IExchangeRatesRepository, ExchangeRatesRepository>();
            services.AddScoped<IXmlToObjectService, XmlToObjectParsingService>();
            services.AddScoped<IExchangeRateService, ExchangeRateChangeService>();
            services.AddScoped<IDateValidationService, DateValidationService>();
            services.AddScoped<IDateChangeService, DateChangeService>();
            
            services.AddScoped<IExchangeRateApplication, ExchangeRateApplication>();
           
            return services;
        }
    }
}