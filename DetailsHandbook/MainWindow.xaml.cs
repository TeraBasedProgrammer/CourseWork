global using DetailsLib;
global using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata;
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
            MessageBox.Show("Нихуя не добавлено, но кнопка работает");
        }
    }
}
