using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class Inductance : Detail
    {
        public  int Nominal { get; set; }
        
        public double WorkingCurrent { get; set; }

        public int Access { get; set; }
        public Inductance() : base()
        {
            Nominal = 0;
            WorkingCurrent = 0;
            Access = 0;
        }
    }
}
