using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Test.Models
{
    internal class Product
    {
        public double Price { get; set; }

        public decimal Count { get; set; }

        public decimal Coast()
        {
            return Convert.ToDecimal(Price) * Count;
        }
    }
}
