using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Interfaces.Interfaces.Services
{
    public interface IStatisticsService
    {
        Task<double> GetSimpleMovingAverage(string coinName, int windowSize);
    }
}
