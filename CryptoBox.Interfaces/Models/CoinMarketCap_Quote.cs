using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Interfaces.Models
{
    public class CoinMarketCap_Quote
    {
        /*  Example CMC Payload
            {
	            "id": 1,
	            "name": "Bitcoin",
	            "symbol": "BTC",
	            "slug": "bitcoin",
	            "circulating_supply": 17199862,
	            "total_supply": 17199862,
	            "max_supply": 21000000,
	            "date_added": "2013-04-28T00:00:00.000Z",
	            "num_market_pairs": 331,
	            "cmc_rank": 1,
	            "last_updated": "2018-08-09T21:56:28.000Z",
	            "quote": {
		            "USD": {
			            "price": 6602.60701122,
			            "volume_24h": 4314444687.5194,
			            "percent_change_1h": 0.988615,
			            "percent_change_24h": 4.37185,
			            "percent_change_7d": -12.1352,
			            "market_cap": 113563929433.21645,
			            "last_updated": "2018-08-09T21:56:28.000Z"
		            }
	            }
            }
        */

        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string slug { get; set; }
        public int circulating_supply { get; set; }
        public int total_supply { get; set; }
        public int max_supply { get; set; }
        public DateTime date_added { get; set; }
        public int num_market_pairs { get; set; }
        public int cmc_rank { get; set; }
        public DateTime last_updated { get; set; }
        public Quote quote { get; set; }

        public class USD
        {
            public double price { get; set; }
            public double volume_24h { get; set; }
            public double percent_change_1h { get; set; }
            public double percent_change_24h { get; set; }
            public double percent_change_7d { get; set; }
            public double market_cap { get; set; }
            public DateTime last_updated { get; set; }
        }

        public class Quote
        {
            public USD USD { get; set; }
        }

    }
}
