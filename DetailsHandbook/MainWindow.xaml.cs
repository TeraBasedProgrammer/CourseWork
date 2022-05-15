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
using System.Collections.Generic;
using System;

namespace DetailsHandbook
{
    public partial class MainWindow : Window
    {
        private Dictionary<Button, Detail> buttonObjectPairs = new();
        public MainWindow()
        {
            InitializeComponent();
            Render();
        }
       
        private void Render()
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

            var b = new Button();
            b.Style = (Style)Resources["DetailButtonStyle"];

            b.Click += DetailButtonClick;
            b.Content = buttonContent;
            buttonObjectPairs.Add(b, detail);
            wp.Children.Add(b);
        }

        private void DetailButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(buttonObjectPairs.GetValueOrDefault((Button)sender).ToString());
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            if (FiltersBar.Visibility == Visibility.Hidden)
                FiltersBar.Visibility = Visibility.Visible;
            else
                FiltersBar.Visibility = Visibility.Hidden;
        }
    }
}
