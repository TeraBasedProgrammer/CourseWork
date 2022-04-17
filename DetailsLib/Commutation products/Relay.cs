using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class Relay : CommProduct
    {
        public const string detailType = "Реле";
        public int WindingWorkVoltage { get; set; }
         
        public Relay() : base()
        {
            WindingWorkVoltage = 0;
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nКоммутируемое напряжение: {MaxCommVoltage}В\nНапряжение обмотки: {WindingWorkVoltage}В\n--------------------------------------------\n";
        }
    }
}
