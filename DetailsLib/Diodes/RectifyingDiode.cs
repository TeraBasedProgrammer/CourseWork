using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class RectifyingDiode : Diode
    {
        public int ReverseCurrent { get; set; }
        
        public RectifyingDiode() : base()
        {
            ReverseCurrent = 0;
        }
    }
}
