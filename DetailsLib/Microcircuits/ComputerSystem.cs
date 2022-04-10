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
        public override string GetSqlInsertQuery()
        {
            return "Insert Into ComputerSystems (Model, Manufacturer, Price, Interchangeability, SupplyVoltage, CaseType, FunctionalPurpose) values (@Model, @Manufacturer, @Price, @Interchangeability, @SupplyVoltage, @CaseType, @FunctionalPurpose)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from ComputerSystems";
        }
    }
}
