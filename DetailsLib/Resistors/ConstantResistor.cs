using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public class ConstantResistor : Resistor
    {
        public string Type { get; set; }
        
        public ConstantResistor() : base()
        {
            Type = "Undefined";
        }
    }
}
