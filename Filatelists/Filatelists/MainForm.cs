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
    /// Главная форма программы.
    /// </summary>
    /// 
    public partial class MainForm : Form
    {
        AddCollector addCollector = new AddCollector();
        AddMark addMark = new AddMark();
        Collectiors collForm = new Collectiors();
        Themes themes = new Themes();
        ListOfMarks listOfMarks = new ListOfMarks();
        ListOfCollectors listOfCollectors = new ListOfCollectors();
        List<Label> labels = new List<Label>();
        List<string> temp = new List<string>();
        private bool once;
        private int n;


        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Кнопка меню "Выход" закрывает форму главного окна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Кнопка меню "Добавить..." -> "Марку".
        /// Запускает форму добавления марки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void маркуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listOfMarks.Length != 0)
            {
                listOfMarks[0].Part = true;
                listOfMarks.Save();
            }
            addMark.ShowDialog();
            this.RefreshAll();
            this.CreateLabels();
        }

        /// <summary>
        /// Кнопка меню "Коллекционеры" открывает окно для управление списком коллекционеров.
        /// Открывает выбранные марки в главном окне в случае,
        /// если форма закрылась с положительным результатом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void коллекционерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            collForm.ShowDialog();
            if (collForm.DialogResult == DialogResult.OK)
            {
                n = 1;
                this.RefreshAll();
                once = false;
            }
            this.CreateLabels();
        }

        private void маркиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Кнопка меню "Темы" загружает список тем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void темыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themes.ShowDialog();
            if (themes.DialogResult == DialogResult.OK)
            {
                n = 8;
                once = false;
                this.CreateLabels();
                for (int i = 0; i < listOfMarks.Length; i++)
                {
                    if (listOfMarks[i].Show)
                        listOfMarks[i].Show = false;
                }
                listOfMarks.Save();
            }
        }

        /// <summary>
        /// Кнопка меню "Справка" -> "О программе...". Открывает сведения о программе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        /// <summary>
        /// Критерий поиска.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchComboBox.SelectedIndex != -1) searchTextBox.Enabled = true;
            if (searchTextBox.Text == "Выберите критерий поиска...")
            {
                searchTextBox.Text = "Введите слово или словосочетание...";
                searchTextBox.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        /// <summary>
        /// Кнопка "Показать все" показывает все доступные афоризмы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            n = 0;
            searchComboBox.SelectedIndex = -1;
            searchTextBox.Text = "Выберите критерий поиска...";
            searchTextBox.Enabled = false;
            this.CreateLabels();
        }
       
        /// <summary>
        /// Осуществление динамического поиска.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTextBox_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Введите слово или словосочетание...")
            {
                searchTextBox.ForeColor = System.Drawing.Color.Black;
                searchTextBox.Text = "";
            }
        }

        /// <summary>
        /// Изменение размера надписей при изменение размеров окна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_RegionChanged(object sender, EventArgs e)
        {
            this.CreateLabels();
        }

        /// <summary>
        /// Запуск формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            n = 0;
            this.CreateLabels();
            if (searchComboBox.SelectedIndex == -1) searchTextBox.Enabled = false;
            List<string> vars = new List<string>() { "По особенности", "По коллекционеру", "По теме" };
            searchComboBox.Items.AddRange(vars.ToArray());
            searchComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Поиск.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchTextBox.Enabled = true;
            if (searchComboBox.Text == "По особенности") n = 3;
            if (searchComboBox.Text == "По коллекционеру") n = 5;
            if (searchComboBox.Text == "По теме") n = 7;

            this.CreateLabels();
            if (searchTextBox.Text == "")
            {
                panel.Controls.Clear();
            }
        }


        /// <summary>
        /// Кнопка меню "Добавить..." -> "Коллекционера". Открывает окно добавление коллекционера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void коллекционераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listOfCollectors.Length != 0)
            {
                listOfCollectors[0].Part = true;
                listOfCollectors.Save();
            }
            addCollector.ShowDialog();
            listOfCollectors.Open();
        }

        /// <summary>
        /// Кнопка "Удалить" в подменю, которое появляется при клике
        /// правой кнопкной мыши по марке. Удаляет марку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteMB_Click(object sender, EventArgs e)
        {
            var curLabel = contextMenuStrip.SourceControl as Label;

            var res = MessageBox.Show("Удалить марку?", curLabel.Name, MessageBoxButtons.OKCancel);

            if (res == DialogResult.OK)
            {
                listOfMarks.RemoveAt(this.IndexOfLabel(curLabel));
                listOfMarks.Save();
                this.CreateLabels();
            }
        }

        /// <summary>
        /// Метод, который возвращает индекс афоризма в списке афоризмов.
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        private int IndexOfLabel(Label l)
        {
            for (int i = 0; i < listOfMarks.Length; i++)
            {
                if (listOfMarks[i].ToString() == l.Text)
                {
                    return i;
                }
            }
            return -1;
        }


        /// <summary>
        /// Создание и обновление марок.
        /// </summary>
        private void CreateLabels()
        {
            this.RefreshAll();
            temp.Clear();
            labels.Clear();
            panel.Controls.Clear();

            double id = -1;

            if (n == 0) //показывать все афоризмы
            {
                temp = listOfMarks.AllMarks();
            }

            else if (n == 1) //показывать афоризмы по авторам
            {
                for (int i = 0; i < listOfCollectors.Length; i++)
                {
                    if (listOfCollectors[i].Show)
                    {
                        id = listOfCollectors[i].Id;
                        break;
                    }
                }
                if (id == -1) return;

                temp = listOfMarks.MarksById(id, 0);
            }
            
            else if (n == 3) //результаты поиска по особенности
            {
                temp = listOfMarks.Search(searchTextBox.Text, 0);
            }

            else if (n == 5) //результат поиска по коллекционеру
            {
                temp = listOfMarks.Search(searchTextBox.Text, 1);
            }
             
            else if (n == 7) //результат поиска по темам
            {
                temp = listOfMarks.Search(searchTextBox.Text, 2);

            }
            else if (n == 8) //выбранная тема
            {
                List<string> s = new List<string>();
                for (int i = 0; i < listOfMarks.Length; i++)
                {
                    if (listOfMarks[i].Show)
                    {
                        s.Add(listOfMarks[i].ToString());
                    }
                }

                temp = s;
            }

            //Проверка на наличие афоризмов
            if (n == 1 || n == 2 || n == 4 || n == 8)
            {
                if (temp.Count == 0 && !once)
                {
                    MessageBox.Show("Афоризмов нет.");
                    once = true;
                    return;
                }
            }
            else if (n == 3 || n == 5 || n == 7)
            {
                if (temp.Count == 0)
                {
                    return;
                }
            }


            labels.Clear();
            panel.Controls.Clear();
            // Непосредственно создание надписей.
            int x = 10, y = 15;
            for (int i = 0; i < temp.Count; i++)
            {
                labels.Add(new Label());
                labels[labels.Count - 1].Text = temp[i];
                Size sz = new Size(panel.Width, Int32.MaxValue);
                sz = TextRenderer.MeasureText(labels[labels.Count - 1].Text, labels[labels.Count - 1].Font, sz, TextFormatFlags.WordBreak);

                labels[labels.Count - 1].MinimumSize = new System.Drawing.Size(panel.Size.Width - 30, sz.Height + 20);
                if (labels.Count == 1)
                {
                    labels[labels.Count - 1].Location = new System.Drawing.Point(x, y);
                }
                else
                {
                    try
                    {
                        y += labels[i - 1].Size.Height + 20;
                        labels[labels.Count - 1].Location = new System.Drawing.Point(x, y);
                    }
                    catch { }
                }
                labels[labels.Count - 1].Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
                panel.Controls.Add(labels[labels.Count - 1]);
                labels[labels.Count - 1].ContextMenuStrip = contextMenuStrip;
            }
        }

        /// <summary>
        /// Перезагружает информацию об коллекционерах и марках.
        /// </summary>
        private void RefreshAll()
        {
            listOfMarks.Open();
            listOfCollectors.Open();
        }

    }
}
