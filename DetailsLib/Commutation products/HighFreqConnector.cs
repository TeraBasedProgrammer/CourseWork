using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class HighFreqConnector : CommProduct
    {
        public int WaveResistance { get; set; }
       
        public HighFreqConnector() : base()
        {
            WaveResistance = 0;
        }
        public override string GetSqlInsertQuery()
        {
            return "Insert Into HighFreqConnectors (Model, Manufacturer, Price, Interchangeability, MaxCommVoltage, WaveResistance) values (@Model, @Manufacturer, @Price, @Interchangeability, @MaxCommVoltage, @WaveResistance)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from HighFreqConnectors";
        }
    }
}
