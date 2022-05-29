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
    /// Логика взаимодействия для ThyristorGrid.xaml
    /// </summary>
    public partial class ThyristorGrid : UserControl, IDelegate
    {
        public IDelegate.SearchResultHandler GetSearchResult;

        private List<TextBox> localTextBoxes = new();

        public ThyristorGrid()
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
            localTextBoxes.Add(VoltTextBox);
            localTextBoxes.Add(CurrTextBox);
        }

        private void DetailAddButton_Click(object sender, RoutedEventArgs e)
        {
            int[] allInputIsCorrect = { 1, 1, 1, 1};
            double detailPrice = 0;
            int detailVolt = 0;
            double detailCurr = 0;
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
                if (!CheckMethods.CheckIntInput(VoltTextBox.Text, ref detailVolt))
                {
                    VoltTextBox.Text = "";
                    allInputIsCorrect[2] = 0;
                }
                if (!CheckMethods.CheckDoubleInput(CurrTextBox.Text, ref detailCurr))
                {
                    CurrTextBox.Text = "";
                    allInputIsCorrect[3] = 0;
                }
            }

            if (allInputIsCorrect.Sum() == allInputIsCorrect.Length)
            {
                using (DetailsDbContext db = new DetailsDbContext())
                {
                    Thyristor tr = new(ModelTextBox.Text,
                        ManufTextBox.Text,
                        detailPrice,
                        IntchabTextBox.Text,
                        detailVolt,
                        detailCurr);
                    db.Thyristors.Add(tr);
                    db.SaveChanges();
                }
                CheckMethods.TextBoxClear(localTextBoxes);
                CustomMessageBox cmb = new CustomMessageBox("Деталь успешно добавлена!");
                cmb.ShowDialog();
            }
        }

        private void SearchDetailButtom_Click(object sender, RoutedEventArgs e)
        {
            DetailsSearchPanel.SearchResultCollection = new();
            using (var db = new DetailsDbContext())
            {
                foreach (Detail det in db.GetData())
                {
                    if (det is Thyristor tr)
                    {
                        if (tr.Model.IndexOf(ModelTextBox.Text) > -1
                            && tr.Manufacturer.IndexOf(ManufTextBox.Text) > -1
                            && tr.Price.ToString().IndexOf(PriceTextBox.Text) > -1
                            && tr.Interchangeability.IndexOf(IntchabTextBox.Text) > -1
                            && tr.DcVoltageInClosedCase.ToString().IndexOf(VoltTextBox.Text) > -1
                            && tr.DCurrentInOpenCase.ToString().IndexOf(CurrTextBox.Text) > -1)
                            DetailsSearchPanel.SearchResultCollection.Add(tr);
                    }
                }
            }

            GetSearchResult();
        }
    }
}
