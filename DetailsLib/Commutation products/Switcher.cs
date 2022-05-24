using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class Switcher : CommProduct
    {
        private const string detailType = "Тумблер";

        public Switcher() : base()
        {
            SwitchType = "Undefined";
        }

        public Switcher(string model, string manuf, double price, string intchab, int maxCommVolt, string switchType) :
            base(model, manuf, price, intchab, maxCommVolt)
        {
            SwitchType = switchType;
        }

        public string SwitchType { get; set; }
        
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nКоммутируемое напряжение: {MaxCommVoltage}В\nТип: {SwitchType}\n";
        }

        public override string GetShortDetailType() => "Тумблер";
    }
}
