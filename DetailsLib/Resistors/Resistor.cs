using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public class Resistor : Detail
    {   
        public double Nominal { get; set; }
        
        public double Access { get; set; }
       
        public Resistor() : base()
        {
            Nominal = 0;
            Access = 0;
        }
    }
}
