using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class AnalogMicrocircuit : Microcircuit
    {
        public const string detailType = "Аналоговая микросхема";
        public string FunctionalPurpose { get; set; }

        public AnalogMicrocircuit() : base()
        {
            FunctionalPurpose = "Undefined";
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНапряжение питания: {SupplyVoltage}\nТип корпуса: {CaseType}\nФунк. назначение: {FunctionalPurpose}\n--------------------------------------------\n";
        }

    }
}

