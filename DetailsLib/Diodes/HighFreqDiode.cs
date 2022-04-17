using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class HighFreqDiode : Diode
    {
        public const string detailType = "ВЧ диод";
        public int CutoffFreq { get; set; }
        
        public HighFreqDiode() : base()
        {
            CutoffFreq = 0;
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nМаксимальный ток: {CutoffCurrent}А\nМаксимальное напряжение: {CutoffVoltage}В\nГраничная частота: {CutoffFreq}МГц\n--------------------------------------------\n";
        }
    }
}
