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
        public override string GetSqlInsertQuery()
        {
            return "Insert Into MembraneCapacitors (Model, Manufacturer, Price, Interchangeability, Nominal, WorkingVoltage, Access, PlateType) values (@Model, @Manufacturer, @Price, @Interchangeability, @Nominal, @WorkingVoltage, @Access, @PlateType)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from MembraneCapacitors";
        }
    }
}
