using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filatelists
{
    /// <summary>
    /// Форма добавления нового коллекционера.
    /// </summary>
    public partial class AddCollector : Form
    {
        ListOfCollectors listOfCollectors = new ListOfCollectors();
        Collector temp;
        private double id;
        private bool add;

        public AddCollector()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка "Добавить": добавление коллекционера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (this.Check())
            {
                if (Char.IsDigit(nameTextBox.Text[0]))
                {
                    MessageBox.Show("Имя не может быть одной буквой.");
                    return;
                }
                
                if (add)
                {
                    try
                    {
                        id = 0;
                        if (listOfCollectors.Length == 0)
                        {
                            temp = new Collector(listOfCollectors.RemoveSpaces(nameTextBox.Text),
                               listOfCollectors.RemoveSpaces(countryTextBox.Text),
                               listOfCollectors.RemoveSpaces(phoneTextBox.Text),id);
                        }
                        else
                        {
                            id = listOfCollectors[listOfCollectors.Length - 1].Id + 1;
                            temp = new Collector(listOfCollectors.RemoveSpaces(nameTextBox.Text),
                              listOfCollectors.RemoveSpaces(countryTextBox.Text),
                              listOfCollectors.RemoveSpaces(phoneTextBox.Text), id);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Неверно заполнены поля.");
                        return;
                    }
                    if (listOfCollectors.IsCopy(temp))
                    {
                        MessageBox.Show("Этот автор уже существует.");
                        return;
                    }
                    listOfCollectors.Add(temp);
                    DialogResult = DialogResult.OK;
                    listOfCollectors.Save();
                }
                this.ClearAll();
                this.Close();
            }
            else MessageBox.Show("Не все поля заполнены!");
        }

        /// <summary>
        /// Кнопка "Отмена".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Запуск формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCollector_Load(object sender, EventArgs e)
        {
            listOfCollectors.Open();
            if (listOfCollectors.Length == 0 || listOfCollectors[0].Part)
            {
                add = true;
                addButton.Text = "Добавить";
                this.Text = "Добавить автора";
            }
            listOfCollectors[0].Part = false;
        }
        
        /// <summary>
        /// Запуск формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCollector_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ClearAll();
        }

        /// <summary>
        /// Проверка на то, заполнены ли поля.
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (String.IsNullOrWhiteSpace(nameTextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(countryTextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(phoneTextBox.Text)) return false;
            return true;
        }

        /// <summary>
        /// Очистка всех полей.
        /// </summary>
        private void ClearAll()
        {
            nameTextBox.Text = "";
            countryTextBox.Text = "";
            phoneTextBox.Text = "";
        }



    }
}
