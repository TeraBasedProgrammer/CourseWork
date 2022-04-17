using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class ElectrolyticCapacitor : Capacitor
    {
        public const string detailType = "Электролитический конденсатор";
        public string PlateType { get; set; }
        public ElectrolyticCapacitor() : base()
        {
            PlateType = "Undefined";
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНоминал: {Nominal}мкФ\nРабочее напряжение: {WorkingVoltage}В\nДопуск: {Access}%\nТип: {PlateType}\n--------------------------------------------\n";
        }
    }
}

