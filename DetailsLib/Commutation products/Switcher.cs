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
        public string SwitchType { get; set; }
        
        public Switcher() : base()
        {
            SwitchType = "Undefined";
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nКоммутируемое напряжение: {MaxCommVoltage}В\nТип: {SwitchType}\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "Тумблер";
    }
}
