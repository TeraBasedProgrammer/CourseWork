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
    /// Логика взаимодействия для AnalogMicrocircuitGrid.xaml
    /// </summary>
    public partial class AnalogMicrocircuitGrid : UserControl
    {
        List<TextBox> localTextBoxes = new();
        public AnalogMicrocircuitGrid()
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
            int[] allInputIsCorrect = { 1, 1};
            double detailPrice = 0;
            if (!CheckMethods.IsFilled(localTextBoxes))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            else if (CheckMethods.HasManyCharacters(ref localTextBoxes))
            {
                MessageBox.Show("Вы ввели недопустимое кол-во символов в поле ввода");
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
                //using (DetailsDbContext db = new DetailsDbContext())
                //{
                //    AnalogMicrocircuit am = new AnalogMicrocircuit(ModelTextBox.Text, 
                //        ManufTextBox.Text, 
                //        detailPrice, 
                //        IntchabTextBox.Text, 
                //        SuppVoltTextBox.Text, 
                //        CaseTypeTextBox.Text, 
                //        FuncPurpTextBox.Text);
                //    db.AnalogMicrocircuits.Add(am);
                //    db.SaveChanges();
                //}
                CheckMethods.TextBoxClear(localTextBoxes);
                MessageBox.Show("Деталь успешно добавлена!");
            }
        }
    }
}
