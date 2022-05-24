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
    /// Логика взаимодействия для ComputerSystemGrid.xaml
    /// </summary>
    public partial class ComputerSystemGrid : UserControl
    {
        List<TextBox> localTextBoxes = new();
        public ComputerSystemGrid()
        {
            InitializeComponent();
            AddTextBoxes();
        }

        private void AddTextBoxes()
        {
            localTextBoxes.Add(ModelTextBox);
            localTextBoxes.Add(ManufTextBox);
            localTextBoxes.Add(PriceTextBox);
            localTextBoxes.Add(IntchabTextBox);
            localTextBoxes.Add(SuppVoltTextBox);
            localTextBoxes.Add(CaseTypeTextBox);
            localTextBoxes.Add(FuncPurpTextBox);
        }

        private void DetailAddButton_Click(object sender, RoutedEventArgs e)
        {
            int[] allInputIsCorrect = { 1, 1 };
            double detailPrice = 0;
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
            }

            if (allInputIsCorrect.Sum() == allInputIsCorrect.Length)
            {
                using (DetailsDbContext db = new DetailsDbContext())
                {
                    ComputerSystem am = new ComputerSystem(ModelTextBox.Text,
                        ManufTextBox.Text,
                        detailPrice,
                        IntchabTextBox.Text,
                        SuppVoltTextBox.Text,
                        CaseTypeTextBox.Text,
                        FuncPurpTextBox.Text);
                    db.ComputerSystems.Add(am);
                    db.SaveChanges();
                }
                CheckMethods.TextBoxClear(localTextBoxes);
                CustomMessageBox cmb = new CustomMessageBox("Деталь успешно добавлена!");
                cmb.ShowDialog();
            }
        }
    }
}
