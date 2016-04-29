using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Filatelists
{
    /// <summary>
    /// Форма для добавление марок.
    /// </summary>
    [Serializable]
    public partial class AddMark : Form
    {
        ListOfMarks listOfMarks = new ListOfMarks();
        ListOfCollectors listOfCollectors = new ListOfCollectors();
        private double id;
        private bool add;
        public AddMark()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка "Добавить": проверка введенных данных и добавление в список афоризмов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            if (add)
            {
                id = 0;
                listOfMarks.Open();
                if (listOfMarks.Length == 0)
                    listOfMarks.Add(new Marka(listOfMarks.RemoveSpaces(countryTextBox.Text),
                       listOfMarks.RemoveSpaces(nominalTextBox.Text),
                       listOfMarks.RemoveSpaces(yearTextBox.Text),
                       listOfMarks.RemoveSpaces(tirageTextBox.Text),
                       listOfMarks.RemoveSpaces(specialTextBox.Text),id,
                        listOfCollectors[collectiorComboBox.SelectedIndex]));
                else
                {
                    id = listOfMarks[listOfMarks.Length - 1].Id + 1;
                    listOfMarks.Add(new Marka(listOfMarks.RemoveSpaces(countryTextBox.Text),
                      listOfMarks.RemoveSpaces(nominalTextBox.Text),
                      listOfMarks.RemoveSpaces(yearTextBox.Text),
                      listOfMarks.RemoveSpaces(tirageTextBox.Text),
                      listOfMarks.RemoveSpaces(specialTextBox.Text), id,
                       listOfCollectors[collectiorComboBox.SelectedIndex]));
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
                for (int i = 0; i < listOfMarks.Length; i++)
                {
                    if (listOfMarks[i].Change)
                    {
                        listOfMarks[i].Country = listOfMarks.RemoveSpaces(countryTextBox.Text);
                        listOfMarks[i].Year = listOfMarks.RemoveSpaces(yearTextBox.Text);
                        listOfMarks[i].Nominal = listOfMarks.RemoveSpaces(nominalTextBox.Text);
                        listOfMarks[i].Tirage = listOfMarks.RemoveSpaces(tirageTextBox.Text);
                        listOfMarks[i].Special = listOfMarks.RemoveSpaces(specialTextBox.Text);
                        listOfMarks[i].Coll = listOfCollectors[collectiorComboBox.SelectedIndex];
                        break;
                    }
                }
            }
            DialogResult = DialogResult.OK;
            listOfMarks.Save();
            this.ClearAll();
            this.Close();
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
        private void AddMark_Load(object sender, EventArgs e)
        {
            listOfMarks.Open();
            listOfCollectors.Open();
            collectiorBindingSource.DataSource = listOfCollectors.Collectior; // Привязка списка коллекционеров.
            collectiorComboBox.SelectedIndex = -1;

            if (listOfMarks.Length == 0 || listOfMarks[0].Part)
            {
                add = true;
                addButton.Text = "Добавить";
                this.Text = "Добавить марку";
            }
            
            listOfMarks[0].Part = false;
        }

        /// <summary>
        /// Оччистка всех полей.
        /// </summary>
        private void ClearAll()
        {
            collectiorComboBox.SelectedIndex = -1;
            countryTextBox.Text = "";
            yearTextBox.Text = "";
            nominalTextBox.Text = "";
            tirageTextBox.Text = "";
            specialTextBox.Text = "";
        }
       
        /// <summary>
        /// Проверка на то, заполнены ли поля.
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (collectiorComboBox.SelectedIndex == -1) return false;
            if (String.IsNullOrWhiteSpace(countryTextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(yearTextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(nominalTextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(tirageTextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(specialTextBox.Text)) return false;
            return true;
        }





    }
}
