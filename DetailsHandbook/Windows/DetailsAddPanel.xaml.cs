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
    /// Логика взаимодействия для DetailsAddPanel.xaml
    /// </summary>
    public partial class DetailsAddPanel : Window
    {
        private Dictionary<CustomButton, UserControl>  checkBoxGridPairs = new();
        public DetailsAddPanel()
        {
            InitializeComponent();
            AddDetailsCheckboxes();
        }

        private void AddDetailsCheckboxes()
        {
            checkBoxGridPairs.Add(AlternateResistorButton, AlternateResistorGrid);
            checkBoxGridPairs.Add(AnalogMicrocircuitButton, AnalogMicrocircuitGrid);
            checkBoxGridPairs.Add(CeramicCapacitorButton, CeramicCapacitorGrid);
            checkBoxGridPairs.Add(ComputerSystemButton, ComputerSystemGrid);
            checkBoxGridPairs.Add(ConstantResistorButton, ConstantResistorGrid);
            checkBoxGridPairs.Add(ElectrolyticCapacitorButton, ElectrolyticCapacitorGrid);
            checkBoxGridPairs.Add(HighFreqConnectorButton, HighFreqConnectorGrid);
            checkBoxGridPairs.Add(HighFreqDiodeButton, HighFreqDiodeGrid);
            checkBoxGridPairs.Add(InductanceButton, InductanceGrid);
            checkBoxGridPairs.Add(LightDiodeButton,LightDiodeGrid);
            checkBoxGridPairs.Add(LogicMicrocircuitButton, LogicMicrocircuitGrid);
            checkBoxGridPairs.Add(LowFreqConnectorButton, LowFreqConnectorGrid); 
            checkBoxGridPairs.Add(MembraneCapacitorButton, MembraneCapacitorGrid);
            checkBoxGridPairs.Add(RectifyingDiodeButton, RectifyingDiodeGrid);
            checkBoxGridPairs.Add(RelayButton, RelayGrid);
            checkBoxGridPairs.Add(SwitcherButton, SwitcherGrid);
            checkBoxGridPairs.Add(ThyristorButton, ThyristorGrid);
            checkBoxGridPairs.Add(TransistorButton, TransistorGrid);
            checkBoxGridPairs.Add(ZenerDiodeButton, ZenerDiodeGrid);
        }

        private void ClearDetailPoint()
        {
            foreach (CustomButton button in checkBoxGridPairs.Keys)
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

        private void ShowAddBlock(CustomButton value)
        {
            foreach(UserControl uc in checkBoxGridPairs.Values)
            {
                if (uc.Visibility == Visibility.Visible)
                {
                    uc.Visibility = Visibility.Collapsed;
                    break;
                }
            }
            checkBoxGridPairs.GetValueOrDefault(value).Visibility = Visibility.Visible;
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

        private void DetailsCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (DetailsBar.Visibility == Visibility.Hidden)
                DetailsBar.Visibility = Visibility.Visible;
            else
                DetailsBar.Visibility = Visibility.Hidden;
        }

        private void DetailCheckBoxButton_Click(object sender, RoutedEventArgs e)
        {
            ClearDetailPoint();
            CustomButton tempButton = (CustomButton)sender;
            TextBlock tempTextBlock = (TextBlock)tempButton.Content;
            tempTextBlock.Text = "• " + tempTextBlock.Text;
            sender = tempButton;
            ShowAddBlock((CustomButton)sender);
            TitleText.Text = ((TextBlock)((CustomButton)sender).Content).Text.Substring(2);
        }
    }
}
