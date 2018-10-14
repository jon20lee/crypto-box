using CryptoBox.Interfaces.Interfaces.Repositories;
using CryptoBox.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace CryptoBox.Core.Repositories
{
    public class CryptoQuotesRepository : ICryptoQuotesRepository
    {
        public async Task<CoinMarketCap_Quote> GetQuote(string coinName) => await Task.Run(() =>
        {
            var queryString = $"?symbol={coinName}&convert=USD";

            var client = new RestClient(ConfigurationManager.AppSettings["CoinMarketCapHost"]);
            var request = new RestRequest(ConfigurationManager.AppSettings["CoinMarketCap_QuotesLatest_Resource"] + queryString, Method.GET);
            request.AddHeader(ConfigurationManager.AppSettings["CoinMarketCap_ApiKey_HeaderName"], ConfigurationManager.AppSettings["CoinMarketCap_ApiKey"]);
            var queryResult = client.Execute(request);
            dynamic json = JObject.Parse(queryResult.Content);
              
            CoinMarketCap_Quote quote = JsonConvert.DeserializeObject<CoinMarketCap_Quote>(json?.data?[coinName].ToString() ?? "" );

            return quote;
        });

        public async Task<IEnumerable<CoinMarketCap_Coin>> GetCryptoCoinsMap() => await Task.Run(() =>
        {
            var client = new RestClient(ConfigurationManager.AppSettings["CoinMarketCapHost"]);
            var request = new RestRequest(ConfigurationManager.AppSettings["CoinMarketCap_AllCoinsMap_Resource"], Method.GET);
            request.AddHeader(ConfigurationManager.AppSettings["CoinMarketCap_ApiKey_HeaderName"], ConfigurationManager.AppSettings["CoinMarketCap_ApiKey"]);
            var queryResult = client.Execute(request);
            dynamic json = JObject.Parse(queryResult.Content);

            IEnumerable<CoinMarketCap_Coin> quote = JsonConvert.DeserializeObject<IEnumerable<CoinMarketCap_Coin>>(json?.data?.ToString() ?? "");

            return quote;
        });
    }
}
