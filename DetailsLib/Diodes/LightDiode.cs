using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class LightDiode : Diode
    {
        public const string detailType = "Светодиод";
        public double LightPower { get; set; }
       
        public LightDiode() : base()
        {
             LightPower = 0;
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nМаксимальный ток: {CutoffCurrent}А\nМаксимальное напряжение: {CutoffVoltage}В\nЯркость свечения: {LightPower}мкКд\n--------------------------------------------\n";
        }
    }
}
