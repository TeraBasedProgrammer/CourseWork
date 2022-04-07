using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class ComputerSystem : Microcircuit
    {
        public string FunctionalPurpose { get; set; }
       
        public ComputerSystem() : base()
        {
            FunctionalPurpose = "Undefined";
        }
    }
}
