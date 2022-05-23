

namespace DetailsLib
{
    public sealed class Thyristor : Detail
    {
        private const string detailType = "Индуктивность";

        public Thyristor(string model, string manuf, double price, string intchab, int volt, double curr)
           : base(model, manuf, price, intchab)
        {
            DcVoltageInClosedCase = volt;
            DCurrentInOpenCase = curr;
        }

        public int DcVoltageInClosedCase { get; set; }

        public double DCurrentInOpenCase { get; set; }


        public override string ToString()
        {
            return $"Тип детали: {detailType}\n\nМодель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}$\nВзаимозаменяемость: {Interchangeability}\nНапряжение в закрытом сост.: {DcVoltageInClosedCase}В\nТок в открытом сост.: {DCurrentInOpenCase}А\n--------------------------------------------\n";
        }

        public override string GetShortDetailType() => "Тир.";
    }
}
