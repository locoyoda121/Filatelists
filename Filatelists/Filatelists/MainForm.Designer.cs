namespace Filatelists
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коллекционераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коллекционерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маркиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.коллекционерыToolStripMenuItem,
            this.маркиToolStripMenuItem,
            this.темыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.коллекционераToolStripMenuItem,
            this.маркуToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // коллекционераToolStripMenuItem
            // 
            this.коллекционераToolStripMenuItem.Name = "коллекционераToolStripMenuItem";
            this.коллекционераToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.коллекционераToolStripMenuItem.Text = "Коллекционера";
            this.коллекционераToolStripMenuItem.Click += new System.EventHandler(this.коллекционераToolStripMenuItem_Click);
            // 
            // маркуToolStripMenuItem
            // 
            this.маркуToolStripMenuItem.Name = "маркуToolStripMenuItem";
            this.маркуToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.маркуToolStripMenuItem.Text = "Марку";
            this.маркуToolStripMenuItem.Click += new System.EventHandler(this.маркуToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // коллекционерыToolStripMenuItem
            // 
            this.коллекционерыToolStripMenuItem.Name = "коллекционерыToolStripMenuItem";
            this.коллекционерыToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.коллекционерыToolStripMenuItem.Text = "Коллекционеры";
            this.коллекционерыToolStripMenuItem.Click += new System.EventHandler(this.коллекционерыToolStripMenuItem_Click);
            // 
            // маркиToolStripMenuItem
            // 
            this.маркиToolStripMenuItem.Name = "маркиToolStripMenuItem";
            this.маркиToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.маркиToolStripMenuItem.Text = "Марки";
            this.маркиToolStripMenuItem.Click += new System.EventHandler(this.маркиToolStripMenuItem_Click);
            // 
            // темыToolStripMenuItem
            // 
            this.темыToolStripMenuItem.Name = "темыToolStripMenuItem";
            this.темыToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.темыToolStripMenuItem.Text = "Темы";
            this.темыToolStripMenuItem.Click += new System.EventHandler(this.темыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // searchComboBox
            // 
            this.searchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(232, 27);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(131, 21);
            this.searchComboBox.TabIndex = 5;
            this.searchComboBox.SelectedIndexChanged += new System.EventHandler(this.searchComboBox_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(232, 54);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 26);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Показать все";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(12, 86);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(351, 163);
            this.panel.TabIndex = 7;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 28);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(214, 52);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.Text = "Выберите критерий поиска...";
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMB});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // deleteMB
            // 
            this.deleteMB.Name = "deleteMB";
            this.deleteMB.Size = new System.Drawing.Size(152, 22);
            this.deleteMB.Text = "Удалить";
            this.deleteMB.Click += new System.EventHandler(this.deleteMB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 261);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник филателиста";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RegionChanged += new System.EventHandler(this.Form1_RegionChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коллекционераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маркуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коллекционерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маркиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteMB;
    }
}