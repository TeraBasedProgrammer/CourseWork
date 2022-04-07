global using DetailsLib;
namespace DataCheckConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnalogMicrocircuit> amcList = new List<AnalogMicrocircuit>();
            amcList = SQLiteDataAccess.LoadAnalogMC();
            foreach (var am in amcList)
            {
                Console.WriteLine(am.ToString());
            }
        }
    }
}
