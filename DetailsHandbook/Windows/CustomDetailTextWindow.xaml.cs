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
    /// Логика взаимодействия для CustomDetailTextWindow.xaml
    /// </summary>
    public partial class CustomDetailTextWindow : Window
    {
        private Detail currentObject;
        public CustomDetailTextWindow(string info, Detail dt)
        {
            InitializeComponent();
            MessageBoxText.Text = info;
            this.SizeToContent = SizeToContent.WidthAndHeight;
            currentObject = dt;
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

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DetailDeletionConf ddc = new(currentObject);
            ddc.Owner = this;
            ddc.ShowDialog();
            if (ddc.DialogResult == true && ddc.IsDeleted() == true)
            {
                this.DialogResult = true;
            }
        }

    }
}
