using CryptoBox.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Interfaces.Interfaces.Repositories
{
    public interface ICryptoQuotesRepository
    {
        Task<CoinMarketCap_Quote> GetQuote(string coinName);
        Task<IEnumerable<CoinMarketCap_Coin>> GetCryptoCoinsMap();
    }
}
