using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBC.Entity
{
    public class Electricity
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public int lastReading { get; set; }
        public int currentReading { get; set; }
        public int units { get; set; }
        public decimal price { get; set; }
    }
}
