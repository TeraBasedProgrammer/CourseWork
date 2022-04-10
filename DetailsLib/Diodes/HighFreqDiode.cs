using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class HighFreqDiode : Diode
    {
        public int CutoffFreq { get; set; }
        
        public HighFreqDiode() : base()
        {
            CutoffFreq = 0;
        }
        public override string GetSqlInsertQuery()
        {
            return "Insert Into HighFreqDiodes (Model, Manufacturer, Price, Interchangeability, CutoffCurrent, CutoffVoltage, CutoffFreq) values (@Model, @Manufacturer, @Price, @Interchangeability, @CutoffCurrent, @CutoffVoltage, @CutoffFreq)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from HighFreqDiodes";
        }
    }
}
