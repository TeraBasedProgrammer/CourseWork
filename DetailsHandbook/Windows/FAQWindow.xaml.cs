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
    /// Логика взаимодействия для FAQWindow.xaml
    /// </summary>
    public partial class FAQWindow : Window
    {
        public FAQWindow()
        {
            InitializeComponent();
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
    }
}
