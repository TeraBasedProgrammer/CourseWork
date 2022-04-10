using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class RectifyingDiode : Diode
    {
        // Прямой ток, обратное напряжение
        public double ReverseCurrent { get; set; }
        
        public RectifyingDiode() : base()
        {
            ReverseCurrent = 0;
        }
        public override string GetSqlInsertQuery()
        {
            return "Insert Into RectifyingDiodes (Model, Manufacturer, Price, Interchangeability, CutoffCurrent, CutoffVoltage, ReverseCurrent) values (@Model, @Manufacturer, @Price, @Interchangeability, @CutoffCurrent, @CutoffVoltage, @ReverseCurrent)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from RectifyingDiodes";
        }
    }
}
