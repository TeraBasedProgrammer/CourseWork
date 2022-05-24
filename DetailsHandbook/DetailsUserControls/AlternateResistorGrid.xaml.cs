﻿using System;
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
    /// Логика взаимодействия для AlternateResistorGrid.xaml
    /// </summary>
    public partial class AlternateResistorGrid : UserControl
    {
        List<TextBox> localTextBoxes = new();
        
        public AlternateResistorGrid()
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
            localTextBoxes.Add(PowerTextBox);
            localTextBoxes.Add(NominalTextBox);
            localTextBoxes.Add(AccessTextBox);
            localTextBoxes.Add(SpinTypeTextBox);
        }

        private void DetailAddButton_Click(object sender, RoutedEventArgs e)
        {
            int[] allInputIsCorrect = {1,1,1,1,1};
            double detailPrice = 0;
            double detailPower = 0;
            double detailNominal = 0;
            double detailAccess = 0;
            if (!CheckMethods.IsFilled(localTextBoxes))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            else if(CheckMethods.HasManyCharacters(ref localTextBoxes))
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
                if (!CheckMethods.CheckDoubleInput(PowerTextBox.Text, ref detailPower))
                {
                    PowerTextBox.Text = "";
                    allInputIsCorrect[2] = 0;
                }
                if (!CheckMethods.CheckDoubleInput(NominalTextBox.Text, ref detailNominal))
                {
                    NominalTextBox.Text = "";
                    allInputIsCorrect[3] = 0;
                }
                if (!CheckMethods.CheckDoubleInput(AccessTextBox.Text, ref detailAccess))
                {
                    AccessTextBox.Text = "";
                    allInputIsCorrect[4] = 0;
                }
            }

            if (allInputIsCorrect.Sum() == allInputIsCorrect.Length)
            {
                using (DetailsDbContext db = new DetailsDbContext())
                {
                    AlternateResistor ar = new(ModelTextBox.Text,
                        ManufTextBox.Text,
                        detailPrice,
                        IntchabTextBox.Text,
                        detailPower,
                        detailNominal,
                        detailAccess,
                        SpinTypeTextBox.Text);
                    db.AlternateResistors.Add(ar);
                    db.SaveChanges();
                }
                CheckMethods.TextBoxClear(localTextBoxes);
                MessageBox.Show("Деталь успешно добавлена!");
            }
        }
    }
}
