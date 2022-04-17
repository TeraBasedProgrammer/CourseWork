using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public sealed class ConstantResistor : Resistor
    {
        public const string detailType = "Постоянный резистор";
        public string Type { get; set; }
        
        public ConstantResistor() : base()
        {
            Type = "Undefined";
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nМощность: {Power}Вт\nНоминал: {Nominal}кОм\nДопуск: {Access}%\nИсполнение: {Type}\n--------------------------------------------\n";
        }
    }
}
