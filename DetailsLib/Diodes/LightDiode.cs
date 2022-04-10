using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class LightDiode : Diode
    {
        public double LightPower { get; set; }
       
        public LightDiode() : base()
        {
             LightPower = 0;
        }
        public override string GetSqlInsertQuery()
        {
            return "Insert Into LightDiodes (Model, Manufacturer, Price, Interchangeability, CutoffCurrent, CutoffVoltage, LightPower) values (@Model, @Manufacturer, @Price, @Interchangeability, @CutoffCurrent, @CutoffVoltage, @LightPower)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from LightDiodes";
        }
    }
}
