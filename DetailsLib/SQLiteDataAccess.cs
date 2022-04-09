using System;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;

namespace DetailsLib
{
    public class SQLiteDataAccess
    {
        public static List<AnalogMicrocircuit> LoadAnalogMC()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AnalogMicrocircuit>("select * from AnalogMicrocircuits", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveAnalogMC(AnalogMicrocircuit amc)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //Добавить try catch на отлов уникальной модели

                cnn.Execute(amc.GetSqlInsertQuery(), amc);
            }
        }

        private static string LoadConnectionString(string id = "ConnectionDefault")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
