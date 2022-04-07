using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class ElectrolyticCapacitor : Capacitor
    {
        public string PlateType { get; set; }
        public ElectrolyticCapacitor() : base()
        {
            PlateType = "Undefined";
        }
    }
}
