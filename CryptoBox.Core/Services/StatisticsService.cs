using CryptoBox.Interfaces.Interfaces.Services;
using CryptoBox.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Core.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly ICryptoCompareService _cryptoCompareService;
        public StatisticsService(ICryptoCompareService cryptoCompareService)
        {
            _cryptoCompareService = cryptoCompareService;
        }

        public async Task<double> GetSimpleMovingAverage(string coinName, int windowSize)
        {
            //first lets gather data set from crypo compare api

            var coinHistoData = await _cryptoCompareService.GetHistoHour(coinName);

            //now select the number of data points based on window size
            var closeVals = coinHistoData.Select(x => Convert.ToDecimal(x.close)).ToArray();

            var sma = GetSMA(windowSize, closeVals);


            return 0.00;
        }

        private decimal[] GetSMA(int period, decimal[] data)
        {
            var buffer = new decimal[period];
            var output = new decimal[data.Length];
            var current_index = 0;
            for (int i = 0; i < data.Length; i++)
            {
                buffer[current_index] = data[i] / period;
                decimal ma = 0.0M;
                for (int j = 0; j < period; j++)
                {
                    ma += buffer[j];
                }
                output[i] = ma;
                current_index = (current_index + 1) % period;
            }
            return output;
        }
    }
}
