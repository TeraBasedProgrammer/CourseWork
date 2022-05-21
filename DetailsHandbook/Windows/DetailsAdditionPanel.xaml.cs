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
    /// Логика взаимодействия для DetailsAdditionPanel.xaml
    /// </summary>
    public partial class DetailsAdditionPanel : Window
    {
        //private Dictionary<CustomButton, Func<Window>> detailsWindowsPairs = new();
        //public DetailsAdditionPanel()
        //{
        //    InitializeComponent();
        //    AddPairs();
        //}

        //private void AddPairs()
        //{
        //    detailsWindowsPairs.Add(CapacitorAddButton, () => new CapasitorsAddPanel());
        //    detailsWindowsPairs.Add(CommProductAddButton, () => new CommProductsAddPanel());
        //    detailsWindowsPairs.Add(DiodeAddButton, () => new DiodesAddPanel());
        //    detailsWindowsPairs.Add(MicrocircuitAddButton, () => new MicrocircuitsAddPanel());
        //    detailsWindowsPairs.Add(ResistorAddButton, () => new ResistorsAddPanel());
        //    detailsWindowsPairs.Add(InductanceAddButton, () => new InductanceAddWindow());
        //    detailsWindowsPairs.Add(ThyristorAddButton, () => new ThyristorAddWindow());
        //    detailsWindowsPairs.Add(TransistorAddButton, () => new TransistorAddWindow());
        //    detailsWindowsPairs.Add(ZenerDiodeAddButton, () => new ZenerDiodeAddWindow());
        //}
        //private void WindowPanel_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    if (e.LeftButton == MouseButtonState.Pressed)
        //        DragMove();
        //}
        //private void WindowCloseButton_Click(object sender, RoutedEventArgs e)
        //{
        //    this.DialogResult = true;
        //}

        //private void WindowHideButton_Click(object sender, RoutedEventArgs e)
        //{
        //    this.WindowState = WindowState.Minimized;
        //}
        //private void AddDetailButton_Click(object sender, RoutedEventArgs e)
        //{
        //    detailsWindowsPairs.GetValueOrDefault((CustomButton)sender)?.Invoke().ShowDialog();
        //}
    }
}
