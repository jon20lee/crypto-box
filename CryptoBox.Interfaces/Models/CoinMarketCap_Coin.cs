using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Interfaces.Models
{
    public class CoinMarketCap_Coin
    {
        /*  Example CMC Payload
            {
                "id": 1,
                "name": "Bitcoin",
                "symbol": "BTC",
                "slug": "bitcoin",
                "is_active": true,
                "first_historical_data": "2013-04-28T18:47:21.000Z",
                "last_historical_data": "2018-06-02T22:51:28.209Z"
            }
         */

        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string slug { get; set; }
        public bool is_active { get; set; }
        public DateTime? first_historical_data { get; set; }
        public DateTime? last_historical_data { get; set; }
    }
}
