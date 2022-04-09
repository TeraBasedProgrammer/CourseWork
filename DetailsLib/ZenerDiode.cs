using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class ZenerDiode : Detail
    {
        public double StabilizationVoltage { get; set; }
       
        public int StabilizationCurrent { get; set; }
        
        public ZenerDiode() : base()
        {
            StabilizationVoltage = 0;
            StabilizationCurrent = 0;
        }
        
    }
}
