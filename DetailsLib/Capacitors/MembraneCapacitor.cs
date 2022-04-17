using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class MembraneCapacitor : Capacitor
    {
        public const string detailType = "Плёночный конденсатор";
        public string PlateType { get; set; }
        
        public MembraneCapacitor() : base()
        {
            PlateType = "Undefined";
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНоминал: {Nominal}мкФ\nРабочее напряжение: {WorkingVoltage}В\nДопуск: {Access}%\n Тип: {PlateType}\n--------------------------------------------\n";
        }
    }
}

