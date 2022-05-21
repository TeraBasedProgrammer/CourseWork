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
        private Dictionary<CustomButton, Grid> detailBlockPairs = new();
        public DetailsAddPanel()
        {
            InitializeComponent();
            AddDetailsCheckboxes();
        }

        private void AddDetailsCheckboxes()
        {
            detailBlockPairs.Add(AlternateResistorButton, AlternateResistorAddBlock);
            detailBlockPairs.Add(AnalogMicrocircuitButton, AnalogMicrocircuitAddBlock);
            detailBlockPairs.Add(CeramicCapacitorButton, CeramicCapacitorAddBlock);
            detailBlockPairs.Add(ComputerSystemButton, ComputerSystemAddBlock);
            detailBlockPairs.Add(ConstantResistorButton, ConstantResistorAddBlock);
            detailBlockPairs.Add(ElectrolyticCapacitorButton, ElectrolyticCapacitorAddBlock);
            detailBlockPairs.Add(HighFreqConnectorButton, HighFreqConnectorAddBlock);
            detailBlockPairs.Add(HighFreqDiodeButton, HighFreqDiodeAddBlock);
            detailBlockPairs.Add(InductanceButton, InductanceAddBlock);
            detailBlockPairs.Add(LightDiodeButton, LightDiodeAddBlock);
            detailBlockPairs.Add(LogicMicrocircuitButton, LogicMicrocircuitAddBlock);
            detailBlockPairs.Add(LowFreqConnectorButton, LowFreqConnectorAddBlock);
            detailBlockPairs.Add(MembraneCapacitorButton, MembraneCapacitorAddBlock);
            detailBlockPairs.Add(RectifyingDiodeButton, RectifyingDiodeAddBlock);
            detailBlockPairs.Add(RelayButton, RelayAddBlock);
            detailBlockPairs.Add(SwitcherButton, SwitcherAddBlock);
            detailBlockPairs.Add(ThyristorButton, ThyristorAddBlock);
            detailBlockPairs.Add(TransistorButton, TransistorAddBlock);
            detailBlockPairs.Add(ZenerDiodeButton, ZenerDiodeAddBlock);
        }

        private void ClearDetailPoint()
        {
            foreach (CustomButton button in detailBlockPairs.Keys)
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
            foreach (Grid block in detailBlockPairs.Values)
            {
                if(block.Visibility == Visibility.Visible)
                {
                    block.Visibility = Visibility.Collapsed;
                    break;
                }
            }
            detailBlockPairs.GetValueOrDefault(value).Visibility = Visibility.Visible;
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
