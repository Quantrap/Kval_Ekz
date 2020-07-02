namespace Kval_Ekz
{
    partial class FL_Form
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewFL = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxPol = new System.Windows.Forms.ComboBox();
            this.comboBoxManagers = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelOtchestvo = new System.Windows.Forms.Label();
            this.labelImya = new System.Windows.Forms.Label();
            this.labelFamilia = new System.Windows.Forms.Label();
            this.textBoxOtchestvo = new System.Windows.Forms.TextBox();
            this.textBoxImya = new System.Windows.Forms.TextBox();
            this.textBoxFamilia = new System.Windows.Forms.TextBox();
            this.labelPol = new System.Windows.Forms.Label();
            this.labelManagers = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(703, 325);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(85, 43);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(612, 325);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 43);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(521, 325);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 43);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewFL
            // 
            this.listViewFL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewFL.FullRowSelect = true;
            this.listViewFL.GridLines = true;
            this.listViewFL.Location = new System.Drawing.Point(146, 25);
            this.listViewFL.MultiSelect = false;
            this.listViewFL.Name = "listViewFL";
            this.listViewFL.Size = new System.Drawing.Size(642, 294);
            this.listViewFL.TabIndex = 20;
            this.listViewFL.UseCompatibleStateImageBehavior = false;
            this.listViewFL.View = System.Windows.Forms.View.Details;
            this.listViewFL.SelectedIndexChanged += new System.EventHandler(this.listViewFL_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата рождения";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Адрес";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Пол";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id Агентов";
            // 
            // comboBoxPol
            // 
            this.comboBoxPol.FormattingEnabled = true;
            this.comboBoxPol.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxPol.Location = new System.Drawing.Point(12, 218);
            this.comboBoxPol.Name = "comboBoxPol";
            this.comboBoxPol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPol.TabIndex = 21;
            // 
            // comboBoxManagers
            // 
            this.comboBoxManagers.FormattingEnabled = true;
            this.comboBoxManagers.Location = new System.Drawing.Point(12, 260);
            this.comboBoxManagers.Name = "comboBoxManagers";
            this.comboBoxManagers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxManagers.TabIndex = 22;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 124);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(86, 13);
            this.labelDate.TabIndex = 24;
            this.labelDate.Text = "Дата рождения";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(12, 140);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(128, 20);
            this.textBoxDate.TabIndex = 23;
            this.textBoxDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPressE);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 163);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(38, 13);
            this.labelAddress.TabIndex = 26;
            this.labelAddress.Text = "Адрес";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(12, 179);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(128, 20);
            this.textBoxAddress.TabIndex = 25;
            this.textBoxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPressA);
            // 
            // labelOtchestvo
            // 
            this.labelOtchestvo.AutoSize = true;
            this.labelOtchestvo.Location = new System.Drawing.Point(12, 88);
            this.labelOtchestvo.Name = "labelOtchestvo";
            this.labelOtchestvo.Size = new System.Drawing.Size(54, 13);
            this.labelOtchestvo.TabIndex = 32;
            this.labelOtchestvo.Text = "Отчество";
            // 
            // labelImya
            // 
            this.labelImya.AutoSize = true;
            this.labelImya.Location = new System.Drawing.Point(12, 51);
            this.labelImya.Name = "labelImya";
            this.labelImya.Size = new System.Drawing.Size(29, 13);
            this.labelImya.TabIndex = 31;
            this.labelImya.Text = "Имя";
            // 
            // labelFamilia
            // 
            this.labelFamilia.AutoSize = true;
            this.labelFamilia.Location = new System.Drawing.Point(12, 12);
            this.labelFamilia.Name = "labelFamilia";
            this.labelFamilia.Size = new System.Drawing.Size(56, 13);
            this.labelFamilia.TabIndex = 30;
            this.labelFamilia.Text = "Фамилия";
            // 
            // textBoxOtchestvo
            // 
            this.textBoxOtchestvo.Location = new System.Drawing.Point(12, 104);
            this.textBoxOtchestvo.Name = "textBoxOtchestvo";
            this.textBoxOtchestvo.Size = new System.Drawing.Size(128, 20);
            this.textBoxOtchestvo.TabIndex = 29;
            this.textBoxOtchestvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPressO);
            // 
            // textBoxImya
            // 
            this.textBoxImya.Location = new System.Drawing.Point(12, 65);
            this.textBoxImya.Name = "textBoxImya";
            this.textBoxImya.Size = new System.Drawing.Size(128, 20);
            this.textBoxImya.TabIndex = 28;
            this.textBoxImya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPressN);
            // 
            // textBoxFamilia
            // 
            this.textBoxFamilia.Location = new System.Drawing.Point(12, 28);
            this.textBoxFamilia.Name = "textBoxFamilia";
            this.textBoxFamilia.Size = new System.Drawing.Size(128, 20);
            this.textBoxFamilia.TabIndex = 27;
            this.textBoxFamilia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPress);
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Location = new System.Drawing.Point(12, 202);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(27, 13);
            this.labelPol.TabIndex = 33;
            this.labelPol.Text = "Пол";
            // 
            // labelManagers
            // 
            this.labelManagers.AutoSize = true;
            this.labelManagers.Location = new System.Drawing.Point(12, 244);
            this.labelManagers.Name = "labelManagers";
            this.labelManagers.Size = new System.Drawing.Size(44, 13);
            this.labelManagers.TabIndex = 34;
            this.labelManagers.Text = "Агенты";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Kval_Ekz.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 325);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(158, 71);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 35;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FL_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelManagers);
            this.Controls.Add(this.labelPol);
            this.Controls.Add(this.labelOtchestvo);
            this.Controls.Add(this.labelImya);
            this.Controls.Add(this.labelFamilia);
            this.Controls.Add(this.textBoxOtchestvo);
            this.Controls.Add(this.textBoxImya);
            this.Controls.Add(this.textBoxFamilia);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.comboBoxManagers);
            this.Controls.Add(this.comboBoxPol);
            this.Controls.Add(this.listViewFL);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FL_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Физические лица";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewFL;
        private System.Windows.Forms.ComboBox comboBoxPol;
        private System.Windows.Forms.ComboBox comboBoxManagers;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelOtchestvo;
        private System.Windows.Forms.Label labelImya;
        private System.Windows.Forms.Label labelFamilia;
        private System.Windows.Forms.TextBox textBoxOtchestvo;
        private System.Windows.Forms.TextBox textBoxImya;
        private System.Windows.Forms.TextBox textBoxFamilia;
        private System.Windows.Forms.Label labelPol;
        private System.Windows.Forms.Label labelManagers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}