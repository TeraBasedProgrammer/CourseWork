using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class Relay : CommProduct
    {
        public int WindingWorkVoltage { get; set; }
         
        public Relay() : base()
        {
            WindingWorkVoltage = 0;
        }
        public override string GetSqlInsertQuery()
        {
            return "Insert Into Relays (Model, Manufacturer, Price, Interchangeability, MaxCommVoltage, WindingWorkVoltage) values (@Model, @Manufacturer, @Price, @Interchangeability, @MaxCommVoltage, @WindingWorkVoltage)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from Relays";
        }
    }
}
