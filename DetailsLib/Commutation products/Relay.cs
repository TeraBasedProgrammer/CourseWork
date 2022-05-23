using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class Relay : CommProduct
    {
        private const string detailType = "Реле";

        public Relay(string model, string manuf, double price, string intchab, int maxCommVolt, int windWorkVolt) :
            base(model, manuf, price, intchab, maxCommVolt)
        {
            WindingWorkVoltage = windWorkVolt;
        }


        public int WindingWorkVoltage { get; set; }
         
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nКоммутируемое напряжение: {MaxCommVoltage}В\nНапряжение обмотки: {WindingWorkVoltage}В\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "Реле";
    }
}
