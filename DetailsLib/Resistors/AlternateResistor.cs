using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public class AlternateResistor : Resistor
    {
        public string SpinType { get; set; }
       
        public AlternateResistor() : base()
        {
            SpinType = "Undefined";
        }
    }
}
