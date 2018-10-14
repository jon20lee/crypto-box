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
    public class CryptoCompareService : ICryptoCompareService
    {
        private readonly ICryptoCompareRepository _cryptoCompareRepository;
        public CryptoCompareService(ICryptoCompareRepository cryptoCompareRepository)
        {
            _cryptoCompareRepository = cryptoCompareRepository;
        }

        public async Task<IEnumerable<CryptoCompare_HistoHour>> GetHistoHour(string coinName)
        {
            return await _cryptoCompareRepository.GetHistoHour(coinName);
        }
    }
}
