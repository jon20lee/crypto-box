using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Interfaces.Models
{
    public class CryptoCompare_HistoHour
    {
        public int time { get; set; }
        public double close { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double open { get; set; }
        public double volumefrom { get; set; }
        public double volumeto { get; set; }
    }
}
