global using DetailsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DetailsHandbook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<AnalogMicrocircuit> amcList = new List<AnalogMicrocircuit>();
        public void LoadAnalogMicrocircuits()
        {
          amcList = SQLiteDataAccess.LoadAnalogMC();
          foreach(var am in amcList)
          {
                dataText.Text += am.ToString();
          }
        }
        private void RefreshDataButton_Click(object sender, RoutedEventArgs e)
        {
            dataText.Text = "";
            LoadAnalogMicrocircuits();
        }
        public MainWindow()
        {
            InitializeComponent();
            LoadAnalogMicrocircuits();
        }

        private void AddDetailButton_Click(object sender, RoutedEventArgs e)
        {
            string model = modelInfo.Text;
            string manuf = manufInfo.Text;
            double price = Convert.ToDouble(priceInfo.Text);
            string intchab = intchabInfo.Text;
            string supVolt = supVoltInfo.Text;
            string caseType = caseTypeInfo.Text;
            string funcPurp = funcPurpInfo.Text;
            var amc = new AnalogMicrocircuit(model, manuf, price, intchab, supVolt, caseType, funcPurp);
            
            SQLiteDataAccess.SaveAnalogMC(amc);
        }
    }
}
