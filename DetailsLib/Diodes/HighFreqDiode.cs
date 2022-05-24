using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class HighFreqDiode : Diode
    {
        private const string detailType = "ВЧ диод";

        public HighFreqDiode() : base()
        {
            CutoffFreq = 0;
        }

        public HighFreqDiode(string model, string manuf, double price, string intchab, double cutoffCurr, int cutoffVolt, int cutoffFreq)
            : base(model, manuf, price, intchab, cutoffCurr, cutoffVolt)
        {
            CutoffFreq = cutoffFreq;
        }

        public int CutoffFreq { get; set; }     
  
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nМаксимальный ток: {CutoffCurrent}А\nМаксимальное напряжение: {CutoffVoltage}В\nГраничная частота: {CutoffFreq}МГц\n";
        }

        public override string GetShortDetailType() => "ВЧ диод";
    }
}
