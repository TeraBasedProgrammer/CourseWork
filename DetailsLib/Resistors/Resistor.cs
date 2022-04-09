using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public class Resistor : Detail
    {
        public double Power { get; set; }
        public double Nominal { get; set; }
        
        public double Access { get; set; }
       
        public Resistor() : base()
        {
            Power = 0;
            Nominal = 0;
            Access = 0;
        }
        public override string GetSqlInsertQuery()
        {
            return base.GetSqlInsertQuery();
        }
        public override string GetSqlLoadQuery()
        {
            return base.GetSqlLoadQuery();
        }
    }
}
