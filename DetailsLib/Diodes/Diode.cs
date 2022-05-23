﻿

namespace DetailsLib
{
    public class Diode : Detail
    {
        public Diode(string model, string manuf, double price, string intchab, double cutoffCurr, int cutoffVolt)
            : base(model, manuf, price, intchab)
        {
            CutoffCurrent = cutoffCurr;
            CutoffCurrent = cutoffVolt;
        }

        public double CutoffCurrent { get; set; }
        
        public int CutoffVoltage { get; set; }
    }
}
