using CryptoBox.Interfaces.Interfaces.Repositories;
using CryptoBox.Interfaces.Interfaces.Services;
using CryptoBox.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Core.Services
{
    public class CryptoCoinMarketCapService : ICryptoCoinMarketCapService
    {
        private readonly ICryptoQuotesRepository _cryptoQuotesRepository;

        public CryptoCoinMarketCapService(ICryptoQuotesRepository cryptoQuotesRepository)
        {
            _cryptoQuotesRepository = cryptoQuotesRepository; 
        }

        public async Task<CoinMarketCap_Quote> GetQuoteAsync(string coinName)
        {
            return await _cryptoQuotesRepository.GetQuote(coinName);
        }

        public async Task<IEnumerable<CoinMarketCap_Coin>> GetCryptoCoinsMap()
        {
            return await _cryptoQuotesRepository.GetCryptoCoinsMap();
        }
    }
}
