using CryptoBox.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Interfaces.Interfaces.Services
{
    public interface ICryptoCoinMarketCapService
    {
        Task<CoinMarketCap_Quote> GetQuoteAsync(string coinName);
        Task<IEnumerable<CoinMarketCap_Coin>> GetCryptoCoinsMap();
    }
}
