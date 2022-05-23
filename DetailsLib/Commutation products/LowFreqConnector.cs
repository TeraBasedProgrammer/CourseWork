using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class LowFreqConnector : CommProduct
    {
        private const string detailType = "НЧ разъём";

        public LowFreqConnector(string model, string manuf, double price, string intchab, int maxCommVolt, string connType) :
            base(model, manuf, price, intchab, maxCommVolt)
        {
            ConnectorType = connType;
        }

        public string ConnectorType { get; set; }
       
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nКоммутируемое напряжение: {MaxCommVoltage}В\nТип: {ConnectorType}\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "НЧ разъём";
    }
}
