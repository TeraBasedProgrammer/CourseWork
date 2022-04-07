using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class HighFreqConnector : CommProduct
    {
        public int WaveResistance { get; set; }
       
        public HighFreqConnector() : base()
        {
            WaveResistance = 0;
        }
    }
}
