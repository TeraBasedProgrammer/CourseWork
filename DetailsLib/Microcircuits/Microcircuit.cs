using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class Microcircuit : Detail
    {
        public Microcircuit(string model, string manuf, double price, string intchab, string supVolt, string caseType)
            : base(model, manuf, price, intchab)
        {
            SupplyVoltage = supVolt;
            CaseType = caseType;
        }

        public string SupplyVoltage { get; set; }
        
        public string CaseType { get; set; }
    }
}
