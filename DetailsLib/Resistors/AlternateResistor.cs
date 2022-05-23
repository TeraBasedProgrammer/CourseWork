using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public sealed class AlternateResistor : Resistor
    {
        public const string detailType = "Переменный резистор";

        public AlternateResistor() : base()
        {
            SpinType = "Undefined";
        }

        public AlternateResistor(string model, string manuf, double price, string intchab, double power, double nominal, double access, string spinType)
            : base(model, manuf, price, intchab, power, nominal, access)
        {
            SpinType = spinType;
        }

        public string SpinType { get; set; }
          
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nМощность: {Power}Вт\nНоминал: {Nominal}кОм\nДопуск: {Access}%\nИсполнение: {SpinType}\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "Пер. рез.";
    }
}