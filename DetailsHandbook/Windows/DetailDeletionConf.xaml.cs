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
using System.Windows.Shapes;

namespace DetailsHandbook.Windows
{
    /// <summary>
    /// Логика взаимодействия для DetailDeletionConf.xaml
    /// </summary>
    public partial class DetailDeletionConf : Window
    {
        private bool isDeleted;
        private Detail currObj;
        public DetailDeletionConf(Detail currObj)
        {
            InitializeComponent();
            this.currObj = currObj;
        }

        public bool IsDeleted()
        {
            if (isDeleted)
                return true;
            return false;
        }
        private void WindowPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void WindowCloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void WindowHideButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            using(DetailsDbContext db = new DetailsDbContext())
            {
                db.Remove(currObj);
                db.SaveChanges();
            }
            isDeleted = true;
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
