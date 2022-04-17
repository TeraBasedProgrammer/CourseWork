using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public sealed class LowFreqConnector : CommProduct
    {
        public const string detailType = "НЧ разъём";
        public string ConnectorType { get; set; }
        
        
        public LowFreqConnector() : base()
        {
            ConnectorType = "Undefined";
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nКоммутируемое напряжение: {MaxCommVoltage}В\nТип: {ConnectorType}\n--------------------------------------------\n";
        }

    }
}
