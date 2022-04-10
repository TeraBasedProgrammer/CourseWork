

namespace DetailsLib
{
    public class Thyristor : Detail
    {
        public int DcVoltageInClosedCase { get; set; }

        public double DCurrentInOpenCase { get; set; }

        public Thyristor() : base()
        {
            DcVoltageInClosedCase = 0;
            DCurrentInOpenCase = 0;
        }
        public override string GetSqlInsertQuery()
        {
            return "Insert Into Thyristors (Model, Manufacturer, Price, Interchangeability, DcVoltageInClosedCase, DCurrentInOpenCase) values (@Model, @Manufacturer, @Price, @Interchangeability, @Nominal, @DcVoltageInClosedCase, @DCurrentInOpenCase)";
        }
        public override string GetSqlLoadQuery()
        {
            return "select * from Thyristors";
        }
    }
}
