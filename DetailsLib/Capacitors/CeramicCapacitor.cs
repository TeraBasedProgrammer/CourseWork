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
        public override string GetSqlInsertQuery()
        {
            return "Insert Into CeramicCapacitors (Model, Manufacturer, Price, Interchangeability, Nominal, WorkingVoltage, Access, Tcc) values (@Model, @Manufacturer, @Price, @Interchangeability, @Nominal, @WorkingVoltage, @Access, @Tcc)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from CeramicCapacitors";
        }
    }
}
