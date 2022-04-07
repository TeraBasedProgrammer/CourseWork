using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class Capacitor : Detail
    {
        public double Nominal { get; set; }
        
        public int WorkingVoltage { get; set; }
       
        public Capacitor() : base() 
        {
            Nominal = 0;
            WorkingVoltage = 0;
        }
    }
}
