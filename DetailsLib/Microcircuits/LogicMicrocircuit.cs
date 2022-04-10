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
        public override string GetSqlInsertQuery()
        {
            return "Insert Into LogicMicrocircuits (Model, Manufacturer, Price, Interchangeability, SupplyVoltage, CaseType, LogicOrganization) values (@Model, @Manufacturer, @Price, @Interchangeability, @SupplyVoltage, @CaseType, @LogicOrganization)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from LogicMicrocircuits";
        }
    }
}
