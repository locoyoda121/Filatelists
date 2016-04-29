namespace Filatelists
{
    partial class Collectiors
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
            this.collectiorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectiorListBox = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.countryLabel = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.TextBox();
            this.nominalLabel = new System.Windows.Forms.TextBox();
            this.tirageLabel = new System.Windows.Forms.TextBox();
            this.marksListBox = new System.Windows.Forms.ListBox();
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.collectiorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // collectiorListBox
            // 
            this.collectiorListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.collectiorListBox.DataSource = this.collectiorBindingSource;
            this.collectiorListBox.DisplayMember = "Name";
            this.collectiorListBox.FormattingEnabled = true;
            this.collectiorListBox.Location = new System.Drawing.Point(12, 12);
            this.collectiorListBox.Name = "collectiorListBox";
            this.collectiorListBox.Size = new System.Drawing.Size(116, 316);
            this.collectiorListBox.TabIndex = 2;
            this.collectiorListBox.ValueMember = "Id";
            this.collectiorListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.collectiorListBox.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.Location = new System.Drawing.Point(298, 258);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(145, 25);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Вернуться";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(298, 289);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(145, 25);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить коллекционера";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.Location = new System.Drawing.Point(298, 44);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.ReadOnly = true;
            this.countryLabel.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.countryLabel.Size = new System.Drawing.Size(145, 22);
            this.countryLabel.TabIndex = 9;
            this.countryLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearLabel
            // 
            this.yearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(298, 81);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.ReadOnly = true;
            this.yearLabel.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.yearLabel.Size = new System.Drawing.Size(145, 22);
            this.yearLabel.TabIndex = 10;
            this.yearLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nominalLabel
            // 
            this.nominalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nominalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nominalLabel.Location = new System.Drawing.Point(298, 118);
            this.nominalLabel.Name = "nominalLabel";
            this.nominalLabel.ReadOnly = true;
            this.nominalLabel.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.nominalLabel.Size = new System.Drawing.Size(145, 22);
            this.nominalLabel.TabIndex = 11;
            this.nominalLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tirageLabel
            // 
            this.tirageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tirageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tirageLabel.Location = new System.Drawing.Point(298, 155);
            this.tirageLabel.Name = "tirageLabel";
            this.tirageLabel.ReadOnly = true;
            this.tirageLabel.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tirageLabel.Size = new System.Drawing.Size(145, 22);
            this.tirageLabel.TabIndex = 12;
            this.tirageLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // marksListBox
            // 
            this.marksListBox.FormattingEnabled = true;
            this.marksListBox.DataSource = this.marksBindingSource;
            this.marksListBox.DisplayMember = "Special";
            this.marksListBox.FormattingEnabled = true;
            this.marksListBox.Location = new System.Drawing.Point(155, 12);
            this.marksListBox.Name = "marksListBox";
            this.marksListBox.Size = new System.Drawing.Size(120, 316);
            this.marksListBox.TabIndex = 13;
            this.marksListBox.ValueMember = "Id";
            this.marksListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Collectiors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 339);
            this.Controls.Add(this.marksListBox);
            this.Controls.Add(this.tirageLabel);
            this.Controls.Add(this.nominalLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.collectiorListBox);
            this.Name = "Collectiors";
            this.Text = "Коллекционеры";
            this.Load += new System.EventHandler(this.Collectiors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collectiorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource collectiorBindingSource;
        private System.Windows.Forms.ListBox collectiorListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox countryLabel;
        private System.Windows.Forms.TextBox yearLabel;
        private System.Windows.Forms.TextBox nominalLabel;
        private System.Windows.Forms.TextBox tirageLabel;
        private System.Windows.Forms.ListBox marksListBox;
        private System.Windows.Forms.BindingSource marksBindingSource;
    }
}