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
    /// Логика взаимодействия для SwitcherGrid.xaml
    /// </summary>
    public partial class SwitcherGrid : UserControl
    {
        List<TextBox> localTextBoxes = new();
        public SwitcherGrid()
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
            localTextBoxes.Add(MaxxCommVoltTextBox);
            localTextBoxes.Add(SwitchTypeTextBox);
        }

        private void DetailAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckMethods.IsFilled(localTextBoxes))
            {
                MessageBox.Show("Деталь успешно добавлена!");
                CheckMethods.TextBoxClear(localTextBoxes);
            }
            else
                MessageBox.Show("Заполните все поля");
        }
    }
}
