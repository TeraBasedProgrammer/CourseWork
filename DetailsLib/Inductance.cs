using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class Inductance : Detail
    {
        private const string detailType = "Индуктивность";

        public Inductance(string model, string manuf, double price, string intchab, int nominal, double workCurr, int access)
            : base(model, manuf, price, intchab)
        {
            Nominal = nominal;
            WorkingCurrent = workCurr;
            Access = access;
        }

        public  int Nominal { get; set; }
        
        public double WorkingCurrent { get; set; }

        public int Access { get; set; }
        

        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНоминал: {Nominal}мкГн\nРабочий ток: {WorkingCurrent}А\nДопуск: {Access}%\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "Инд.";
    }
}
