global using DetailsLib;
global using System.Reflection;
using DetailsHandbook.Windows;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System;

namespace DetailsHandbook
{
    // При закрытии окна добавления детали снова вызывать Render. Как? А хуй знает, потом ро
    public partial class MainWindow : Window
    {
        private Dictionary<CustomButton, Detail> buttonObjectPairs = new();
        private Dictionary<CustomButton, WrapPanel> filterPanelPairs = new();
        
        public MainWindow()
        {
            InitializeComponent();
            AddFilters(); 
            Render();
        }

        private void AddFilters()
        {
            WrapPanel plug = new WrapPanel();
            filterPanelPairs.Add(NoneFilterCheckBox, plug);
            filterPanelPairs.Add(CapasitorsCheckBox, capasitorsWrapPannel);
            filterPanelPairs.Add(CommProductsCheckBox, commProductsWrapPannel);
            filterPanelPairs.Add(DiodesCheckBox, diodesWrapPannel);
            filterPanelPairs.Add(MicrocircuitsCheckBox, microcircuitsWrapPannel);
            filterPanelPairs.Add(ResistorsCheckBox, resistorsWrapPannel);
            filterPanelPairs.Add(InductancesCheckBox, inductancesWrapPannel);
            filterPanelPairs.Add(ThyristorsCheckBox, thyristorsWrapPannel);
            filterPanelPairs.Add(TransistorsCheckBox, transistorsWrapPannel);
            filterPanelPairs.Add(ZenerDiodesCheckBox, zenerDiodesWrapPannel);
        }

        private void FilterOut(CustomButton value)
        {
            foreach (WrapPanel wp in filterPanelPairs.Values)
            {
                wp.Visibility = Visibility.Collapsed;
            }
            filterPanelPairs.GetValueOrDefault(value).Visibility = Visibility.Visible;
        }
        
        private void ClearFilterPoint()
        {
            foreach (CustomButton button in filterPanelPairs.Keys)
            {
                TextBlock temp = (TextBlock)button.Content;
                if (temp.Text.Contains("• "))
                {
                    temp.Text = temp.Text.Substring(2);
                    button.Content = temp;
                    break;
                }
            }
        }
        public void Render()
        {
            using(var db = new DetailsDbContext())
            {
                foreach(Detail detail in db.GetData())
                { 
                    WrapPanel currWp = detail is Capacitor ? capasitorsWrapPannel :
                         detail is CommProduct ? commProductsWrapPannel :
                         detail is Diode ? diodesWrapPannel :
                         detail is Microcircuit ? microcircuitsWrapPannel :
                         detail is Resistor ? resistorsWrapPannel :
                         detail is Inductance ? inductancesWrapPannel :
                         detail is Thyristor ? thyristorsWrapPannel :
                         detail is Transistor ? transistorsWrapPannel :
                         zenerDiodesWrapPannel;
                    ButtonRender(currWp, detail);
                }
            }
        }

        public void ClearPage()
        {
            foreach (WrapPanel wp in filterPanelPairs.Values)
            {
                wp.Children.RemoveRange(1, wp.Children.Count);
            }
        }
        private void ButtonRender(WrapPanel wp, Detail detail)
        {
            var buttonContent = new StackPanel();
            var buttonTypeText = new TextBlock();
            var buttonModelText = new TextBlock();

            buttonTypeText.Text = $"Тип: {detail.GetShortDetailType()}";
            buttonTypeText.Style = (Style)Resources["DetailButtonText"];
            buttonModelText.Text = $"{detail.Model}";
            buttonModelText.Style = (Style)Resources["DetailButtonText"];
            buttonContent.Children.Add(buttonTypeText);
            buttonContent.Children.Add(buttonModelText);

            var b = new CustomButton();
            b.Style = (Style)Resources["DetailButtonStyle"];

            b.Click += DetailButtonClick;
            b.Content = buttonContent;
            buttonObjectPairs.Add(b, detail);
            wp.Children.Add(b);
        }

        private void WindowPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void WindowCloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void WindowHideButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private void DetailButtonClick(object sender, RoutedEventArgs e)
        {
            Detail tempObject = buttonObjectPairs.GetValueOrDefault((CustomButton)sender);
            var messageBox = new CustomDetailTextWindow(tempObject.ToString(), tempObject);
            messageBox.Owner = this;
            messageBox.ShowDialog();
            if (messageBox.DialogResult == true)
            {
                ClearPage();
                Render();
            }
        }

        private void AddDetailButton_Click(object sender, RoutedEventArgs e)
        {
            var dap = new DetailsAddPanel();
            dap.Owner = this;
            dap.ShowDialog();
            if (dap.DialogResult == true)
            {
                ClearPage();
                Render();
            }
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            if (FiltersBar.Visibility == Visibility.Hidden)
                FiltersBar.Visibility = Visibility.Visible;
            else
                FiltersBar.Visibility = Visibility.Hidden;
        }

        private void NoneFilterChexBox_Click(object sender, RoutedEventArgs e)
        {
            foreach(WrapPanel wp in filterPanelPairs.Values)
            {
                wp.Visibility = Visibility.Visible;
            }
            ClearFilterPoint();
            TextBlock tempTextBlock = (TextBlock)NoneFilterCheckBox.Content;
            tempTextBlock.Text = "• " + tempTextBlock.Text;
            NoneFilterCheckBox.Content = tempTextBlock;
        }
        private void FilterCheckBoxes_Click(object sender, RoutedEventArgs e)
        {
            ClearFilterPoint();
            CustomButton tempButton = (CustomButton)sender;
            TextBlock tempTextBlock = (TextBlock)tempButton.Content;
            tempTextBlock.Text = "• " + tempTextBlock.Text;
            sender = tempButton;
            FilterOut((CustomButton)sender);
        }
    }
}
