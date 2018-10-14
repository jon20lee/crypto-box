using CryptoBox.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Interfaces.Interfaces.Repositories
{
    public interface ICryptoCompareRepository
    {
        Task<IEnumerable<CryptoCompare_HistoHour>> GetHistoHour(string coinName);
    }
}
