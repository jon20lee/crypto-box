using CryptoBox.Interfaces.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CryptoBox.Controllers
{
    [RoutePrefix("api/v1/coinmarketcap")]
    public class CoinMarketCapController : ApiController
    {
        private readonly ICryptoCoinMarketCapService _cryptoCoinMarketCapService;
        public CoinMarketCapController(ICryptoCoinMarketCapService cryptoCoinMarketCapService)
        {
            _cryptoCoinMarketCapService = cryptoCoinMarketCapService;
        }

        /// <summary>
        /// Gets a quote from Coin Market Cap for the given coin name
        /// </summary>
        /// <param name="coinName">The name of the crypto coin</param>
        /// <returns>Quote data for the given crypto coin name</returns>
        [Route("quotes/{coinName}")]
        public async Task<IHttpActionResult> GetQuotesAsync(string coinName)
        {
            var result = await _cryptoCoinMarketCapService.GetQuoteAsync(coinName);
            if (result == null) { return BadRequest("No quote data found for the given coin name"); }

            return Ok(result);
        }

        /// <summary>
        /// Gets an entire list of all active coins and their meta data on Coin market cap
        /// </summary>
        /// <returns>Coin meta data for all coins</returns>
        [Route("coins")]
        public async Task<IHttpActionResult> GetAllCoinsMeta(string coinName)
        {
            var allCoins = await _cryptoCoinMarketCapService.GetCryptoCoinsMap();

            if (allCoins == null) { return BadRequest("No coin data found"); }

            return Ok(allCoins);
        }
    }
}
