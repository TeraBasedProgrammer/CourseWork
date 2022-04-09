using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsLib
{
    public class CommProduct : Detail
    {
        public int MaxCommVoltage { get; set; }
        
        public CommProduct() : base()
        {
            MaxCommVoltage = 0;
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
