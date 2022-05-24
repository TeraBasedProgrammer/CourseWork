using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class LogicMicrocircuit : Microcircuit
    {
        private const string detailType = "Логическая микросхема";

        public LogicMicrocircuit() : base()
        {
            LogicOrganization = "Undefined";
        }

        public LogicMicrocircuit(string model, string manuf, double price, string intchab, string supVolt, string caseType, string logicOrg)
            : base(model, manuf, price, intchab, supVolt, caseType)
        {
            LogicOrganization = logicOrg;
        }

        public string LogicOrganization { get; set; }

        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНапряжение питания: {SupplyVoltage}\nТип корпуса: {CaseType}\nЛогическая организация: {LogicOrganization}\n";
        }

        public override string GetShortDetailType() => "ЛМ";
    }
}
