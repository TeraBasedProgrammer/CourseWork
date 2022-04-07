using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class MembraneCapacitor : Capacitor
    {
        public string PlateType { get; set; }
        
        public MembraneCapacitor() : base()
        {
            PlateType = "Undefined";
        }
    }
}
