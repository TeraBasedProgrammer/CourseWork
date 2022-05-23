using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class RectifyingDiode : Diode
    {
        private const string detailType = "Выпрямительный диод";

        public RectifyingDiode() : base()
        {
            ReverseCurrent = 0;
        }

        public RectifyingDiode(string model, string manuf, double price, string intchab, double cutoffCurr, int cutoffVolt, double revCurr)
           : base(model, manuf, price, intchab, cutoffCurr, cutoffVolt)
        {
            ReverseCurrent = revCurr;
        }


        // Прямой ток, обратное напряжение
        public double ReverseCurrent { get; set; }
        
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nМаксимальный ток: {CutoffCurrent}А\nМаксимальное напряжение: {CutoffVoltage}В\nОбратный ток: {ReverseCurrent}мА\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "Выпр. диод";
    }
}
