using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class ZenerDiode : Detail
    {
        public const string detailType = "Стабилитрон";
        public double StabilizationVoltage { get; set; }
       
        public int StabilizationCurrent { get; set; }
        
        public ZenerDiode() : base()
        {
            StabilizationVoltage = 0;
            StabilizationCurrent = 0;
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНапряжение стабилизации: {StabilizationVoltage}В\nТок стабилизации: {StabilizationCurrent}мА\n--------------------------------------------\n";
        }
    }
}
