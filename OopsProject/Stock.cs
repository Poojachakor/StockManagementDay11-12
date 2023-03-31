using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal class Stock
    {
        public string Name { get; set; }
        public int NumShares { get; set; }
        public double Price { get; set; }

        public double GetValue()
        {
            return NumShares * Price;
        }
    }
}
