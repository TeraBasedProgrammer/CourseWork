using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class Transistor : Detail 
    {
        public string Type { get; set; }
        
        public string Power { get; set; }
       
        public int CutoffFreq { get; set; }
      
        public string HighOrLowFreq { get; set; }
        
        public Transistor() : base()
        {
            Type = "Undefined";
            Power = "Undefined";
            CutoffFreq = 0;
            HighOrLowFreq = "Undefined";
        }
    }
}
