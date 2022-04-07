

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
    }
}
