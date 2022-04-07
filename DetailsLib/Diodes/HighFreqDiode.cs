using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class HighFreqDiode : Diode
    {
        public int CutoffFreq { get; set; }
        
        public HighFreqDiode() : base()
        {
            CutoffFreq = 0;
        }
    }
}
