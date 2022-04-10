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
        public override string GetSqlInsertQuery()
        {
            return "Insert Into ElectrolyticCapacitors (Model, Manufacturer, Price, Interchangeability, Nominal, WorkingVoltage, Access, PlateType) values (@Model, @Manufacturer, @Price, @Interchangeability, @Nominal, @WorkingVoltage, @Access, @PlateType)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from ElectrolyticCapacitors";
        }
    }
}
