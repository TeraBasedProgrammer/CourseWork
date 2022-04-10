using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class LowFreqConnector : CommProduct
    {      
        public string ConnectorType { get; set; }
        
        
        public LowFreqConnector() : base()
        {
            ConnectorType = "Undefined";
        }
        public override string GetSqlInsertQuery()
        {
            return "Insert Into LowFreqConnectors (Model, Manufacturer, Price, Interchangeability, MaxCommVoltage, ConnectorType) values (@Model, @Manufacturer, @Price, @Interchangeability, @MaxCommVoltage, @ConnectorType)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from LowFreqConnectors";
        }
    }
}
