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

        // Температурный коэффициент ёмкости
        public string Tcc { get; set; }
        
        public CeramicCapacitor() : base()
        {
            Tcc = "Undefined";
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНоминал: {Nominal}нФ\nРабочее напряжение: {WorkingVoltage}В\nДопуск: {Access}%\nТКЕ: {Tcc}\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "КК";
        
    }
}
