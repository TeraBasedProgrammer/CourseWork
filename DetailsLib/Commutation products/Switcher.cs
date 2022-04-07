using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class Switcher : CommProduct
    {
        public string SwitchType { get; set; }
        
        public Switcher() : base()
        {
            SwitchType = "Undefined";
        }
    }
}
