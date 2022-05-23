using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public class Resistor : Detail
    {
        public Resistor() : base()
        {
            Power = 0;
            Nominal = 0;
            Access = 0;
        }
        public Resistor(string model, string manuf, double price, string intchab, double power, double nominal, double access)
            : base(model, manuf, price, intchab)
        {
            Power = power;
            Nominal = nominal;
            Access = access;
        }
        public double Power { get; set; }
        public double Nominal { get; set; }
        
        public double Access { get; set; }    
    }
}
