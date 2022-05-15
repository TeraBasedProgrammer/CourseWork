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
        public  int Nominal { get; set; }
        
        public double WorkingCurrent { get; set; }

        public int Access { get; set; }
        public Inductance() : base()
        {
            Nominal = 0;
            WorkingCurrent = 0;
            Access = 0;
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНоминал: {Nominal}мкГн\nРабочий ток: {WorkingCurrent}А\nДопуск: {Access}%\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "Инд.";
    }
}
