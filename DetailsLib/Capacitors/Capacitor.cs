using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class Capacitor : Detail
    {
        public Capacitor(string model, string manuf, double price, string intchab, double nominal, int workVolt, int access) : base(model, manuf, price, intchab)
        {
            Nominal = nominal;
            WorkingVoltage = workVolt;
            Access = access;
        }

        public double Nominal { get; set; }
        
        public int WorkingVoltage { get; set; }

        public int Access { get; set; }
       
    }
}
