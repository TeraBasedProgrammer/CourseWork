

namespace DetailsLib
{
    public class Diode : Detail
    {
        public double CutoffCurrent { get; set; }
        
        public int CutoffVoltage { get; set; }
        
        public Diode() : base()
        {
            CutoffCurrent = 0;
            CutoffVoltage = 0;
        }
        public override string GetSqlInsertQuery()
        {
            return base.GetSqlInsertQuery();
        }
        public override string GetSqlLoadQuery()
        {
            return base.GetSqlLoadQuery();
        }
    }
}
