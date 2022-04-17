global using DetailsLib;
global using System.Reflection;
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
    public partial class MainWindow : Window
    {
        public void ShowData()
        {      
            using(var db = new DetailsDbContext())
            {
                foreach(var detail in db.GetData())
                {
                    dataText.Text += detail.ToString();
                }
            }
        }
        private void RefreshDataButton_Click(object sender, RoutedEventArgs e)
        {
            dataText.Text = "";
            ShowData();
        }
        public MainWindow()
        {
            InitializeComponent();
            ShowData();
        }

        private void AddDetailButton_Click(object sender, RoutedEventArgs e)
        {
            using(var db = new DetailsDbContext())
            {
                //AnalogMicrocircuit mc = new AnalogMicrocircuit();
                //mc.Model = modelInfo.Text;
                //mc.Manufacturer = manufInfo.Text;
                //mc.Price = Convert.ToDouble(priceInfo.Text); 
                //mc.Interchangeability = intchabInfo.Text;
                //mc.SupplyVoltage = supVoltInfo.Text;
                //mc.CaseType = caseTypeInfo.Text;
                //mc.FunctionalPurpose = funcPurpInfo.Text;
                //db.AnalogMicrocircuits.Add(mc);
                //db.SaveChanges();
                MessageBox.Show("Аналоговая микросхема добавлена");
            }
            
        }
    }
}
