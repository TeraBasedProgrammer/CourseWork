using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class ZenerDiode : Detail
    {
        public double StabilizationVoltage { get; set; }
       
        public int StabilizationCurrent { get; set; }
        
        public ZenerDiode() : base()
        {
            StabilizationVoltage = 0;
            StabilizationCurrent = 0;
        }
        public override string GetSqlInsertQuery()
        {
            return "Insert Into ZenerDiodes (Model, Manufacturer, Price, Interchangeability, StabilizationVoltage, StabilizationCurrent) values (@Model, @Manufacturer, @Price, @Interchangeability, @Nominal, @StabilizationVoltage, @StabilizationCurrent)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from ZenerDiodes";
        }
    }
}
