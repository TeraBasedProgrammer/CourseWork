﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class Microcircuit : Detail
    {
        public string SupplyVoltage { get; set; }
        
        public string CaseType { get; set; }
        
        public Microcircuit() : base()
        {
            SupplyVoltage = "Undefined";
            CaseType = "Undefined";
        }
    }
}
