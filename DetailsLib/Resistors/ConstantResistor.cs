using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public sealed class ConstantResistor : Resistor
    {
        public const string detailType = "Постоянный резистор";

        public ConstantResistor(string model, string manuf, double price, string intchab, double power, double nominal, double access, string type)
            : base(model, manuf, price, intchab, power, nominal, access)
        {
            Type = type;
        }

        public string Type { get; set; }
         
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nМощность: {Power}Вт\nНоминал: {Nominal}кОм\nДопуск: {Access}%\nИсполнение: {Type}\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "Пост. рез.";
    }
}
