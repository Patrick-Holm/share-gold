using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldDiggerWebApi.Models
{
    public class PriciousMetals
    {
        public PriciousMetals()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public double PriceInUSD { get; set; }

        public double PriceInDKK { get; set; }
    }
}
