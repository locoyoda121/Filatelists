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
    /// Форма для работы со списком коллекционеров.
    /// </summary>
    /// [Serializable]
    public partial class Collectiors : Form
    {
        ListOfCollectors listOfCollectors = new ListOfCollectors();
        ListOfMarks listOfMarks = new ListOfMarks();
        AddCollector changeCollector = new AddCollector();
        int showAuthor;
        int showMark;

        public Collectiors()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Двойной клик по имени коллекционера в listBox1 открывает
        /// в главном окне марки данного автора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listOfCollectors[collectiorListBox.SelectedIndex].Show = true;
            listOfCollectors.Save();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Обновляет информацию об коллекционере в соответствующих полях формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOfMarks.Open();

            // Если список марок пуст, вывести сообщение.
            if (listOfMarks.Length == 0)
            {
                MessageBox.Show("У этого коллекционера еще нет марок.");
            }
            else
            {
                marksListBox.Enabled = true;
                backButton.Visible = false;
                deleteButton.Visible = true;
                showMark = -1;

                //Привязка данных.
                marksBindingSource.DataSource = listOfMarks.Collection;
                for (int i = 0; i < listOfMarks.Length; i++)
                {
                    listOfMarks[i].Show = false;
                    listOfMarks[i].Change = false;
                    if (listOfMarks[i].ShowMark)
                    {
                        showMark = i;
                        listOfMarks[i].ShowMark = false;
                    }
                }
                listOfMarks.Save();

                if (listOfMarks.Length != 0)
                {
                    backButton.Visible = false;
                    marksListBox.SelectedIndex = 0;
                    this.RefreshInfo();
                }
            }
        }
      
        /// <summary>
        /// Кнопка "Отмена".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
                      
        }

        /// <summary>
        /// Обновляет информацию об марке в соответствующих полях формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshInfo();
        }

        /// <summary>
        /// Запуск формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Collectiors_Load(object sender, EventArgs e)
        {
            listOfCollectors.Open();

            // Если список коллекционеров пуст, закрыть форму.
            if (listOfCollectors.Length == 0)
            {
                MessageBox.Show("Список авторов пока пуст.");
                this.Close();
            }
            else
            {
                collectiorListBox.Enabled = true;
                backButton.Visible = false;
                deleteButton.Visible = true;
                showAuthor = -1;

                //Привязка данных.
                collectiorBindingSource.DataSource = listOfCollectors.Collectior;
                for (int i = 0; i < listOfCollectors.Length; i++)
                {
                    listOfCollectors[i].Show = false;
                    listOfCollectors[i].Change = false;
                    if (listOfCollectors[i].ShowAuthor)
                    {
                        showAuthor = i;
                        listOfCollectors[i].ShowAuthor = false;
                    }
                }
                listOfCollectors.Save();

                if (listOfCollectors.Length != 0)
                {
                   backButton.Visible = false;
                   collectiorListBox.SelectedIndex = 0;
                   this.RefreshInfo();
                }
            }
        }

        /// <summary>
        /// Обновляет информацию в окне.
        /// </summary>
        private void RefreshInfo()
        {
            countryLabel.Text = listOfMarks[marksListBox.SelectedIndex].Country;
            yearLabel.Text = listOfMarks[marksListBox.SelectedIndex].Year;
            nominalLabel.Text = listOfMarks[marksListBox.SelectedIndex].Nominal;
            tirageLabel.Text = listOfMarks[marksListBox.SelectedIndex].Tirage;
        
        }




    }
}
