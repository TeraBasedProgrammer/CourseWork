using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class LightDiode : Diode
    {
        public int LightPower { get; set; }
       
        public LightDiode() : base()
        {
             LightPower = 0;
        }
    }
}
