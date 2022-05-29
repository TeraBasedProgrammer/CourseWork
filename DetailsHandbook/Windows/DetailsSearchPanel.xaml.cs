using System;
using DetailsHandbook;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DetailsHandbook.Windows
{
    /// <summary>
    /// Логика взаимодействия для DetailsSearchPanel.xaml
    /// </summary>
    public partial class DetailsSearchPanel : Window
    {
        public IDelegate.ButtonRenderHandler GetButtonRender;


        private Dictionary<CustomButton, UserControl> checkBoxGridPairs = new();

        public DetailsSearchPanel()
        {
            InitializeComponent();
            AddDetailsCheckboxes();
            AddDelegateBindings();
        }

        public static List<Detail> SearchResultCollection { get; set; } = new();


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
            checkBoxGridPairs.Add(LightDiodeButton, LightDiodeGrid);
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

        private void AddDelegateBindings()
        {
            AlternateResistorGrid.GetSearchResult += RenderSearchResult;
            AnalogMicrocircuitGrid.GetSearchResult += RenderSearchResult;
            CeramicCapacitorGrid.GetSearchResult += RenderSearchResult;
            ComputerSystemGrid.GetSearchResult += RenderSearchResult;
            ElectrolyticCapacitorGrid.GetSearchResult += RenderSearchResult;
            HighFreqConnectorGrid.GetSearchResult += RenderSearchResult;
            HighFreqDiodeGrid.GetSearchResult += RenderSearchResult;
            InductanceGrid.GetSearchResult += RenderSearchResult;
            LightDiodeGrid.GetSearchResult += RenderSearchResult;
            LogicMicrocircuitGrid.GetSearchResult += RenderSearchResult;
            LowFreqConnectorGrid.GetSearchResult += RenderSearchResult;
            MembraneCapacitorGrid.GetSearchResult += RenderSearchResult;
            RectifyingDiodeGrid.GetSearchResult += RenderSearchResult;
            RelayGrid.GetSearchResult += RenderSearchResult;
            SwitcherGrid.GetSearchResult += RenderSearchResult;
            ThyristorGrid.GetSearchResult += RenderSearchResult;
            TransistorGrid.GetSearchResult += RenderSearchResult;
            ZenerDiodeGrid.GetSearchResult += RenderSearchResult;
            ConstantResistorGrid.GetSearchResult += RenderSearchResult;
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

        private void ShowSearchBlock(CustomButton value)
        {
            foreach (UserControl uc in checkBoxGridPairs.Values)
            {
                if (uc.Visibility == Visibility.Visible)
                {
                    uc.Visibility = Visibility.Collapsed;
                    break;
                }
            }
            checkBoxGridPairs.GetValueOrDefault(value).Visibility = Visibility.Visible;
        }

        private void RenderSearchResult()
        {
            if(((MainWindow)Owner).ReRender == null)
                ((MainWindow)this.Owner).ReRender = RenderSearchResult;
            SearchResultWrapPanel.Children.RemoveRange(0, SearchResultWrapPanel.Children.Count);
            using (var db = new DetailsDbContext())
            {
                List<Detail> tempColl = new();
                tempColl.AddRange(SearchResultCollection);
                foreach (Detail det in tempColl)
                {
                    bool isFound = false;
                    foreach (Detail dataDet in db.GetData())
                    {
                        if (det.Model == dataDet.Model)
                        {
                            isFound = true;
                            break;
                        }
                    }

                    if (!isFound)
                    {
                        SearchResultCollection.Remove(det);
                    }
                }
            }
            //SearchResultCollection.Capacity = SearchResultCollection.Count;
            for(int i = 0; i < SearchResultCollection.Count; i++)
                GetButtonRender(SearchResultWrapPanel, SearchResultCollection[i]);
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
            ShowSearchBlock((CustomButton)sender);
            TitleText.Text = ((TextBlock)((CustomButton)sender).Content).Text.Substring(2);
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
    }
}
