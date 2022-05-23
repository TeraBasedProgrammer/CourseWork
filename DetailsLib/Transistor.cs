using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class Transistor : Detail 
    {
        private const string detailType = "Транзистор";

        public Transistor() : base()
        {
            Type = "Undefined";
            Power = "Undefined";
            CutoffFreq = 0;
            HighOrLowFreq = "Undefined";
        }
        public Transistor(string model, string manuf, double price, string intchab, string type, string power, int cutoffFreq, string highOrLowFreq)
            : base(model, manuf, price, intchab)
        {
            Type = type;
            Power = power;
            CutoffFreq = cutoffFreq;
            HighOrLowFreq = highOrLowFreq;
        }

        public string Type { get; set; }
        
        public string Power { get; set; }
       
        public int CutoffFreq { get; set; }
      
        public string HighOrLowFreq { get; set; }
        

        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nТип: {Type}\nМощность: {Power}\nГраничная частота: {CutoffFreq}МГц\nНЧ / ВЧ: {HighOrLowFreq}\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "Транз.";
    }
}
