using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class CommProduct : Detail
    {
        public CommProduct() : base()
        {
            MaxCommVoltage = 0;
        }
        public CommProduct(string model, string manuf, double price, string intchab, int maxCommVolt) :
            base(model, manuf, price, intchab)
        {
            MaxCommVoltage = maxCommVolt;
        }
        public int MaxCommVoltage { get; set; }
    }
}
