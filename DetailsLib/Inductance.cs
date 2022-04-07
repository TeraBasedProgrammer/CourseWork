using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class Inductance : Detail
    {
        public double Nominal { get; set; }
        
        public int WorkingCurrent { get; set; }
        public Inductance() : base()
        {
            Nominal = 0;
            WorkingCurrent = 0;
        }
    }
}
