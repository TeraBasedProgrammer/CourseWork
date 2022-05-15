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
        public int WaveResistance { get; set; }
       
        public HighFreqConnector() : base()
        {
            WaveResistance = 0;
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nКоммутируемое напряжение: {MaxCommVoltage}В\nВолновое сопротивление: {WaveResistance}\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "ВЧ разъём";
    }
}
