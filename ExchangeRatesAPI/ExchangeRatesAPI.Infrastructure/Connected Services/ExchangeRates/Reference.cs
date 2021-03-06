﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExchangeRates
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.lb.lt/ExchangeRates", ConfigurationName="ExchangeRates.ExchangeRatesSoap")]
    public interface ExchangeRatesSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getListOfCurrencies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getListOfCurrenciesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getCurrentExchangeRate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<decimal> getCurrentExchangeRateAsync(string Currency);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<decimal> getExchangeRateAsync(string Currency, string Date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesByDate_XmlString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> getExchangeRatesByDate_XmlStringAsync(string Date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesByCurrency_XmlString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> getExchangeRatesByCurrency_XmlStringAsync(string Currency, string DateLow, string DateHigh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesByDate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getExchangeRatesByDateAsync(string Date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesXmlSchema", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> getExchangeRatesXmlSchemaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeRatesByCurrency", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getExchangeRatesByCurrencyAsync(string Currency, string DateLow, string DateHigh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.lb.lt/ExchangeRates/getExchangeAvgRate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getExchangeAvgRateAsync(string Currency, string DateLow, string DateHigh);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ExchangeRatesSoapChannel : ExchangeRates.ExchangeRatesSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ExchangeRatesSoapClient : System.ServiceModel.ClientBase<ExchangeRates.ExchangeRatesSoap>, ExchangeRates.ExchangeRatesSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ExchangeRatesSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(ExchangeRatesSoapClient.GetBindingForEndpoint(endpointConfiguration), ExchangeRatesSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExchangeRatesSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ExchangeRatesSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExchangeRatesSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ExchangeRatesSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExchangeRatesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getListOfCurrenciesAsync()
        {
            return base.Channel.getListOfCurrenciesAsync();
        }
        
        public System.Threading.Tasks.Task<decimal> getCurrentExchangeRateAsync(string Currency)
        {
            return base.Channel.getCurrentExchangeRateAsync(Currency);
        }
        
        public System.Threading.Tasks.Task<decimal> getExchangeRateAsync(string Currency, string Date)
        {
            return base.Channel.getExchangeRateAsync(Currency, Date);
        }
        
        public System.Threading.Tasks.Task<string> getExchangeRatesByDate_XmlStringAsync(string Date)
        {
            return base.Channel.getExchangeRatesByDate_XmlStringAsync(Date);
        }
        
        public System.Threading.Tasks.Task<string> getExchangeRatesByCurrency_XmlStringAsync(string Currency, string DateLow, string DateHigh)
        {
            return base.Channel.getExchangeRatesByCurrency_XmlStringAsync(Currency, DateLow, DateHigh);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getExchangeRatesByDateAsync(string Date)
        {
            return base.Channel.getExchangeRatesByDateAsync(Date);
        }
        
        public System.Threading.Tasks.Task<string> getExchangeRatesXmlSchemaAsync()
        {
            return base.Channel.getExchangeRatesXmlSchemaAsync();
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getExchangeRatesByCurrencyAsync(string Currency, string DateLow, string DateHigh)
        {
            return base.Channel.getExchangeRatesByCurrencyAsync(Currency, DateLow, DateHigh);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getExchangeAvgRateAsync(string Currency, string DateLow, string DateHigh)
        {
            return base.Channel.getExchangeAvgRateAsync(Currency, DateLow, DateHigh);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ExchangeRatesSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ExchangeRatesSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ExchangeRatesSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://www.lb.lt/webservices/exchangerates/exchangerates.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.ExchangeRatesSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://www.lb.lt/webservices/exchangerates/exchangerates.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            ExchangeRatesSoap,
            
            ExchangeRatesSoap12,
        }
    }
}
