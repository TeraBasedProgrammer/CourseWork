using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class RectifyingDiode : Diode
    {
        public const string detailType = "Выпрямительный диод";
        // Прямой ток, обратное напряжение
        public double ReverseCurrent { get; set; }
        
        public RectifyingDiode() : base()
        {
            ReverseCurrent = 0;
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nМаксимальный ток: {CutoffCurrent}А\nМаксимальное напряжение: {CutoffVoltage}В\nОбратный ток: {ReverseCurrent}мА\n--------------------------------------------\n";
        }
    }
}
