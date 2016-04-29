namespace Filatelists
{
    partial class AddMark
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.collectiorComboBox = new System.Windows.Forms.ComboBox();
            this.collectiorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.nominalTextBox = new System.Windows.Forms.TextBox();
            this.tirageTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.specialTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.collectiorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Страна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Год:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Стоимость: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тираж: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Коллекционер: ";
            // 
            // collectiorComboBox
            // 
            this.collectiorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.collectiorComboBox.DataSource = this.collectiorBindingSource;
            this.collectiorComboBox.DisplayMember = "Name";
            this.collectiorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.collectiorComboBox.FormattingEnabled = true;
            this.collectiorComboBox.Location = new System.Drawing.Point(104, 140);
            this.collectiorComboBox.Name = "collectiorComboBox";
            this.collectiorComboBox.Size = new System.Drawing.Size(231, 21);
            this.collectiorComboBox.TabIndex = 15;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(104, 19);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(231, 20);
            this.countryTextBox.TabIndex = 16;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(104, 50);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(231, 20);
            this.yearTextBox.TabIndex = 17;
            // 
            // nominalTextBox
            // 
            this.nominalTextBox.Location = new System.Drawing.Point(104, 79);
            this.nominalTextBox.Name = "nominalTextBox";
            this.nominalTextBox.Size = new System.Drawing.Size(231, 20);
            this.nominalTextBox.TabIndex = 18;
            // 
            // tirageTextBox
            // 
            this.tirageTextBox.Location = new System.Drawing.Point(104, 109);
            this.tirageTextBox.Name = "tirageTextBox";
            this.tirageTextBox.Size = new System.Drawing.Size(231, 20);
            this.tirageTextBox.TabIndex = 19;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(117, 287);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 25);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(229, 287);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 25);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Особенность:";
            // 
            // specialTextBox
            // 
            this.specialTextBox.Location = new System.Drawing.Point(104, 184);
            this.specialTextBox.Multiline = true;
            this.specialTextBox.Name = "specialTextBox";
            this.specialTextBox.Size = new System.Drawing.Size(231, 57);
            this.specialTextBox.TabIndex = 25;
            // 
            // AddMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 324);
            this.Controls.Add(this.specialTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tirageTextBox);
            this.Controls.Add(this.nominalTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.collectiorComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMark";
            this.Text = "Добавить марку";
            this.Load += new System.EventHandler(this.AddMark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collectiorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox collectiorComboBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox nominalTextBox;
        private System.Windows.Forms.TextBox tirageTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource collectiorBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox specialTextBox;
    }
}