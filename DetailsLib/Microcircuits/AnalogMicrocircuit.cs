using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class AnalogMicrocircuit : Microcircuit
    {
        public string FunctionalPurpose { get; set; }

        public AnalogMicrocircuit() : base()
        {
            FunctionalPurpose = "Undefined";
        }
        public AnalogMicrocircuit(string model, string manuf, double price, string intchab, string supVolt, string caseType, string funcPurp)
            : base(model, manuf, price, intchab, supVolt, caseType)
        {
            FunctionalPurpose = funcPurp;
        }
        public override string ToString()
        {
            return $"Модель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}\nВзаимозаменяемость: {Interchangeability}\nНапряжение питания: {SupplyVoltage}\nТип корпуса: {CaseType}\nФунк. назначение: {FunctionalPurpose}\n--------------------------------------\n";
        }
    }
}

