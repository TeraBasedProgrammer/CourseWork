global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class CeramicCapacitor : Capacitor
    {
        private const string detailType = "Керамический конденсатор";

        public CeramicCapacitor() : base()
        {
            Tcc = "Undefined";
        }

        public CeramicCapacitor(string model, string manuf, double price, string intchab, double nominal, int workVolt, int access, string tcc) :
            base(model, manuf, price, intchab, nominal, workVolt, access)
        {
            Tcc = tcc;
        }


        // Температурный коэффициент ёмкости
        public string Tcc { get; set; }
          
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНоминал: {Nominal}нФ\nРабочее напряжение: {WorkingVoltage}В\nДопуск: {Access}%\nТКЕ: {Tcc}\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "КК";
        
    }
}
