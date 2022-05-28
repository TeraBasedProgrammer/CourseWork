using DetailsHandbook.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DetailsHandbook
{
    /// <summary>
    /// Логика взаимодействия для LightDiodeGrid.xaml
    /// </summary>
    public partial class LightDiodeGrid : UserControl, IDelegate
    {
        public IDelegate.SearchResultHandler GetSearchResult;

        private List<TextBox> localTextBoxes = new();

        private List<Detail> searchResultCollection = new();
        public LightDiodeGrid()
        {
            InitializeComponent();
            AddTextBoxes();
            this.DataContext = this;
        }

        public Visibility SearchButtonVisibility { get; set; }

        public Visibility AddButtonVisibility { get; set; }

        private void AddTextBoxes()
        {
            localTextBoxes.Add(ModelTextBox);
            localTextBoxes.Add(ManufTextBox);
            localTextBoxes.Add(PriceTextBox);
            localTextBoxes.Add(IntchabTextBox);
            localTextBoxes.Add(CutoffCurrTextBox);
            localTextBoxes.Add(CutoffVoltTextBox);
            localTextBoxes.Add(LightPowTextBox);
        }

        private void DetailAddButton_Click(object sender, RoutedEventArgs e)
        {
            int[] allInputIsCorrect = { 1, 1, 1, 1, 1 };
            double detailPrice = 0;
            double detailCutoffCurr = 0;
            int detailCutoffVolt = 0;
            double detailLightPower = 0;
            if (!CheckMethods.IsFilled(localTextBoxes))
            {
                CustomMessageBox cmb = new CustomMessageBox("Заполните все поля!");
                cmb.ShowDialog();
                return;
            }
            else if (CheckMethods.HasManyCharacters(ref localTextBoxes))
            {
                CustomMessageBox cmb = new CustomMessageBox("Вы ввели недопустимое кол-во символов в поле ввода");
                cmb.ShowDialog();
                return;
            }
            else
            {
                if (!CheckMethods.CheckModel(ModelTextBox.Text))
                {
                    ModelTextBox.Text = "";
                    allInputIsCorrect[0] = 0;
                }
                if (!CheckMethods.CheckDoubleInput(PriceTextBox.Text, ref detailPrice))
                {
                    PriceTextBox.Text = "";
                    allInputIsCorrect[1] = 0;
                }
                if (!CheckMethods.CheckDoubleInput(CutoffCurrTextBox.Text, ref detailCutoffCurr))
                {
                    CutoffCurrTextBox.Text = "";
                    allInputIsCorrect[2] = 0;
                }
                if (!CheckMethods.CheckIntInput(CutoffVoltTextBox.Text, ref detailCutoffVolt))
                {
                    CutoffVoltTextBox.Text = "";
                    allInputIsCorrect[3] = 0;
                }
                if (!CheckMethods.CheckDoubleInput(LightPowTextBox.Text, ref detailLightPower))
                {
                    LightPowTextBox.Text = "";
                    allInputIsCorrect[4] = 0;
                }
            }

            if (allInputIsCorrect.Sum() == allInputIsCorrect.Length)
            {
                using (DetailsDbContext db = new DetailsDbContext())
                {
                    LightDiode ld = new(ModelTextBox.Text,
                        ManufTextBox.Text,
                        detailPrice,
                        IntchabTextBox.Text,
                        detailCutoffCurr,
                        detailCutoffVolt,
                        detailLightPower);
                    db.LightDiodes.Add(ld);
                    db.SaveChanges();
                }
                CheckMethods.TextBoxClear(localTextBoxes);
                CustomMessageBox cmb = new CustomMessageBox("Деталь успешно добавлена!");
                cmb.ShowDialog();
            }
        }

        private void SearchDetailButtom_Click(object sender, RoutedEventArgs e)
        {
            searchResultCollection.Clear();
            using (var db = new DetailsDbContext())
            {
                foreach (Detail det in db.GetData())
                {
                    if (det is LightDiode ld)
                    {
                        if (ld.Model.IndexOf(ModelTextBox.Text) > -1
                            && ld.Manufacturer.IndexOf(ManufTextBox.Text) > -1
                            && ld.Price.ToString().IndexOf(PriceTextBox.Text) > -1
                            && ld.Interchangeability.IndexOf(IntchabTextBox.Text) > -1
                            && ld.CutoffCurrent.ToString().IndexOf(CutoffCurrTextBox.Text) > -1
                            && ld.CutoffVoltage.ToString().IndexOf(CutoffVoltTextBox.Text) > -1
                            && ld.LightPower.ToString().IndexOf(LightPowTextBox.Text) > -1)
                            searchResultCollection.Add(ld);
                    }
                }
            }

            GetSearchResult(searchResultCollection);
        }
    }
}
