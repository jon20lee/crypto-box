using CryptoBox.Interfaces.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CryptoBox.Controllers.Api
{
    [RoutePrefix("api/v1/stats")]
    public class StatisticsController : ApiController
    {
        private readonly IStatisticsService _statisticsService;
        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }

        [Route("movingaverage"), HttpGet]
        public async Task<IHttpActionResult> GetMovingAverage(string coinName, int windowSize)
        {
            var sma = await _statisticsService.GetSimpleMovingAverage(coinName, windowSize);

            return Ok(sma);
        }

    }
}
