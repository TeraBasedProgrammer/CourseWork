using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class ElectrolyticCapacitor : Capacitor
    {
        private const string detailType = "Электролитический конденсатор";

        public ElectrolyticCapacitor() : base()
        {
            PlateType = "Undefined";
        }

        public ElectrolyticCapacitor(string model, string manuf, double price, string intchab, double nominal, int workVolt, int access, string plateType) :
            base(model, manuf, price, intchab, nominal, workVolt, access)
        {
            PlateType = plateType;
        }

        public string PlateType { get; set; }
        
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНоминал: {Nominal}мкФ\nРабочее напряжение: {WorkingVoltage}В\nДопуск: {Access}%\nТип: {PlateType}\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "ЭК";
    }
}

