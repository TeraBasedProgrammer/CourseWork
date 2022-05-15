﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class ComputerSystem : Microcircuit
    {
        private const string detailType = "Схема вычислительной системы";
        public string FunctionalPurpose { get; set; }
       
        public ComputerSystem() : base()
        {
            FunctionalPurpose = "Undefined";
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНапряжение питания: {SupplyVoltage}\nТип корпуса: {CaseType}\nФунк. назначение: {FunctionalPurpose}\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "СВС";
    }
}
