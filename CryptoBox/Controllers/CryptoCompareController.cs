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
    [RoutePrefix("api/v1/CryptoCompare")]
    public class CryptoCompareController : ApiController
    {
        private readonly ICryptoCompareService _cryptoCompareService;
        public CryptoCompareController(ICryptoCompareService cryptoCompareService)
        {
            _cryptoCompareService = cryptoCompareService;
        }

        [Route("histohour/{coinName}"), HttpGet]
        public async Task<IHttpActionResult> GetHistoHour(string coinName)
        {
            var histResult = await _cryptoCompareService.GetHistoHour(coinName);

            return Ok(histResult);
        }
    }
}
