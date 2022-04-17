using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class LogicMicrocircuit : Microcircuit
    {
        public const string detailType = "Логическая микросхема";
        public string LogicOrganization { get; set; }

        public LogicMicrocircuit() : base()
        {
            LogicOrganization = "Undefined";
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНапряжение питания: {SupplyVoltage}\nТип корпуса: {CaseType}\nЛогическая организация: {LogicOrganization}\n--------------------------------------------\n";
        }
    }
}
