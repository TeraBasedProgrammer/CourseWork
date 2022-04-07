using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class Relay : CommProduct
    {
        public int WindingWorkVoltage { get; set; }
         
        public Relay() : base()
        {
            WindingWorkVoltage = 0;
        }
    }
}
