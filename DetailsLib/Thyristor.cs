

namespace DetailsLib
{
    public sealed class Thyristor : Detail
    {
        public const string detailType = "Тиристор";
        public int DcVoltageInClosedCase { get; set; }

        public double DCurrentInOpenCase { get; set; }

        public Thyristor() : base()
        {
            DcVoltageInClosedCase = 0;
            DCurrentInOpenCase = 0;
        }
        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНапряжение в закрытом сост.: {DcVoltageInClosedCase}В\nТок в открытом сост.: {DCurrentInOpenCase}А\n--------------------------------------------\n";
        }
    }
}
