using CryptoBox.Interfaces.Interfaces.Repositories;
using CryptoBox.Interfaces.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Core.Repositories
{
    public class CryptoCompareRepository : ICryptoCompareRepository
    {

        public async Task<IEnumerable<CryptoCompare_HistoHour>> GetHistoHour(string coinName) => await Task.Run(() =>
        {
            var queryString = $"?fsym={coinName}&tsym=USD&limit=60&aggregate=3&e=CCCAGG";

            var client = new RestClient(ConfigurationManager.AppSettings["CryptoCompareHost"]);
            var request = new RestRequest(ConfigurationManager.AppSettings["CryptoCompare_HistoHour_Resource"] + queryString, Method.GET);

            var queryResult = client.Execute(request);
            dynamic json = JObject.Parse(queryResult.Content);

            IEnumerable<CryptoCompare_HistoHour> quote = JsonConvert.DeserializeObject<IEnumerable<CryptoCompare_HistoHour>>(json?.Data?.ToString() ?? "");

            return quote;
        });
        
    }
}
