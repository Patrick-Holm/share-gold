using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldDiggerWebApi.Models
{
    public class DollarRate
    {
        public DollarRate()
        {
        }

        public int Id { get; set; }

        public double RateOfExhange { get; set; }

        public DateTime RateDate { get; set; }
    }
}
