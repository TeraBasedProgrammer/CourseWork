using DetailsHandbook.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DetailsHandbook
{
    internal class CheckMethods
    {
        // Метод проверки заполненности полей

        public static bool IsFilled(List<TextBox> localTextBoxes)
        {
            foreach (var textBox in localTextBoxes)
            {
                if (textBox.Text == "")
                    return false;
            }
            return true;
        }

        // Проверка на количество символов в строке

        public static bool HasManyCharacters(ref List<TextBox> localTextBoxes)
        {
            int cyclesCounter = 0;
            for (int i = 0; i < localTextBoxes.Count; i++)
            {
                if (localTextBoxes[i].Text.Length > 25)
                {
                    localTextBoxes[i].Text = "";
                    ++cyclesCounter;
                }
            }
            if (cyclesCounter > 0)
                return true;
            return false;
        }

        // Метод очистки текстовых полей при добавлении детали в БД

        public static void TextBoxClear(List<TextBox> localTextBoxes)
        {
            foreach (var textBox in localTextBoxes)
                textBox.Text = "";
        }

        // Метод проверки наличия введённой модели детали в БД

        public static bool CheckModel(string model)
        {
            using(DetailsDbContext db = new DetailsDbContext())
            {
                foreach(Detail detail in db.GetData())
                {
                    if(model == detail.Model)
                    {
                        CustomMessageBox cmb = new CustomMessageBox("Такая деталь уже есть в базе данных, повторите попытку");
                        cmb.ShowDialog();
                        return false;
                    }
                }
            }
            return true;
        }

        // Метод проверки правильности ввода значений типа double

        public static bool CheckDoubleInput(string inputString, ref double doubleNum)
        {
            bool temp = double.TryParse(inputString, out doubleNum);
            if (!temp)
            {
                CustomMessageBox cmb = new CustomMessageBox("Неправильный формат введённой строки. Введите целое число или дробное (через запятую)");
                cmb.ShowDialog();
                return false;
            }
            return true;
        }

        // Метод проверки правильности ввода значений типа int

        public static bool CheckIntInput(string inputString, ref int doubleNum)
        {
            bool temp = int.TryParse(inputString, out doubleNum);
            if (!temp)
            {
                CustomMessageBox cmb = new CustomMessageBox("Неправильный формат введённой строки. Введите целое число или дробное (через запятую)");
                cmb.ShowDialog();
                return false;
            }
            return true;
        }
    }
}
