using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class ZenerDiode : Detail
    {
        private const string detailType = "Стабилитрон";

        public ZenerDiode() : base()
        {
            StabilizationVoltage = 0;
            StabilizationCurrent = 0;
        }
        public ZenerDiode(string model, string manuf, double price, string intchab, double stabVolt, int stabCurr)
            : base(model, manuf, price, intchab)
        {
            StabilizationVoltage = stabVolt;
            StabilizationCurrent = stabCurr;
        }

        public double StabilizationVoltage { get; set; }
       
        public int StabilizationCurrent { get; set; }
        

        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНапряжение стабилизации: {StabilizationVoltage}В\nТок стабилизации: {StabilizationCurrent}мА\n";
        }

        public override string GetShortDetailType() => "Стаб.";
    }
}
