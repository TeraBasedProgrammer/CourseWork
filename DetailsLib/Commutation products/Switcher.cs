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
        public override string GetSqlInsertQuery()
        {
            return "Insert Into Switchers (Model, Manufacturer, Price, Interchangeability, MaxCommVoltage, SwitchType) values (@Model, @Manufacturer, @Price, @Interchangeability, @MaxCommVoltage, @SwitchType)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from Switchers";
        }
    }
}
