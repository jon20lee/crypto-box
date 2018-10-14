using CryptoBox.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Interfaces.Interfaces.Services
{
    public interface ICryptoCompareService
    {
        Task<IEnumerable<CryptoCompare_HistoHour>> GetHistoHour(string coinName);
    }
}
