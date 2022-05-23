using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class HighFreqConnector : CommProduct
    {
        private const string detailType = "ВЧ разъём";

        public HighFreqConnector(string model, string manuf, double price, string intchab, int maxCommVolt, int waveRes) :
            base(model, manuf, price, intchab, maxCommVolt)
        {
            WaveResistance = waveRes;
        }

        public int WaveResistance { get; set; }
   
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nКоммутируемое напряжение: {MaxCommVoltage}В\nВолновое сопротивление: {WaveResistance}\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "ВЧ разъём";
    }
}
