using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class LogicMicrocircuit : Microcircuit
    {
        public string LogicOrganization { get; set; }

        public LogicMicrocircuit() : base()
        {
            LogicOrganization = "Undefined";
        }
    }
}
