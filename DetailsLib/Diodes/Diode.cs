

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
    }
}
