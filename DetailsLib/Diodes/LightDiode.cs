using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class LightDiode : Diode
    {
        private const string detailType = "Светодиод";

        public LightDiode() : base()
        {
            LightPower = 0;
        }

        public LightDiode(string model, string manuf, double price, string intchab, double cutoffCurr, int cutoffVolt, double lightPow)
            : base(model, manuf, price, intchab, cutoffCurr, cutoffVolt)
        {
            LightPower = lightPow;
        }

        public double LightPower { get; set; }
       
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nМаксимальный ток: {CutoffCurrent}А\nМаксимальное напряжение: {CutoffVoltage}В\nЯркость свечения: {LightPower}мкКд\n";
        }

        public override string GetShortDetailType() => "Светодиод";
    }
}
