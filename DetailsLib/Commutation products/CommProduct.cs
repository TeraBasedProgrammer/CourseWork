using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class CommProduct : Detail
    {
        public int MaxCommVoltage { get; set; }
        
        public CommProduct() : base()
        {
            MaxCommVoltage = 0;
        }
    }
}
