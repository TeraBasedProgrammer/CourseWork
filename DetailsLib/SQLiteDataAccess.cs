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
    //public class SQLiteDataAccess
    //{
    //    public static List<string> GetNecessaryTypes()
    //    {
    //        List<string> typesNames = new List<string>();
    //        List<Type> neccTypes = new List<Type>();
    //        IEnumerable<Type> types = Assembly.GetAssembly(typeof(Detail)).GetTypes().Where(type => type.IsSubclassOf(typeof(Detail)));
    //        foreach (var type in types)
    //        {
    //            if (type.IsSealed)
    //            {
    //                neccTypes.Add(type);

    //                typesNames.Add(type.Name);
    //            }
    //        }
    //        return typesNames;
    //    }
    //    // Сделать  List деталей нужного типа внутри класса самих деталей и преберирать с помощью итератора?????

    //    // СОЗДАТЬ ЛИСТ ОБЪЕКТОВ DETAIL ИЛИ ЛИСТ ЛИСТОВ В КОДЕ XAML.CS И В ЭТОМ КОДЕ СОЗДАТЬ НЕ 38 МЕТОДОВ А 2 С ТИПОМ ДЕТАЛЬ (ТУТ СПОРНО)
    //    public static List<AnalogMicrocircuit> LoadAnalogMC()
    //    {
            
    //        using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
    //        {
    //            IEnumerable<AnalogMicrocircuit> output = cnn.Query<AnalogMicrocircuit>("select * from AnalogMicrocircuits", new DynamicParameters());
    //            return output.ToList();
    //        }
    //    }

    //    public static void SaveAnalogMC(AnalogMicrocircuit amc)
    //    {
    //        using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
    //        {
    //            //Добавить try catch на отлов уникальной модели

    //            cnn.Execute(amc.GetSqlInsertQuery(), amc);
    //        }
    //    }

    //    private static string LoadConnectionString(string id = "ConnectionDefault")
    //    {
    //        return ConfigurationManager.ConnectionStrings[id].ConnectionString;
    //    }
    //}
}
