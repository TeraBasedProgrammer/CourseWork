using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class CeramicCapacitor : Capacitor
    {
        // Температурный коэффициент ёмкости
        public string Tcc { get; set; }
        
        public CeramicCapacitor() : base()
        {
            Tcc = "Undefined";
        }
    }
}
