using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class RectifyingDiode : Diode
    {
        // Прямой ток, обратное напряжение
        public double ReverseCurrent { get; set; }
        
        public RectifyingDiode() : base()
        {
            ReverseCurrent = 0;
        }
    }
}
