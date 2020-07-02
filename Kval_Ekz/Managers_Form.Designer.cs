namespace Kval_Ekz
{
    partial class Managers_Form
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
            this.textBoxFamilia = new System.Windows.Forms.TextBox();
            this.textBoxImya = new System.Windows.Forms.TextBox();
            this.textBoxOtchestvo = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelFamilia = new System.Windows.Forms.Label();
            this.labelImya = new System.Windows.Forms.Label();
            this.labelOtchestvo = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewManagers = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFL = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewUL = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFL = new System.Windows.Forms.Label();
            this.labelUL = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFamilia
            // 
            this.textBoxFamilia.Location = new System.Drawing.Point(12, 57);
            this.textBoxFamilia.Name = "textBoxFamilia";
            this.textBoxFamilia.Size = new System.Drawing.Size(128, 20);
            this.textBoxFamilia.TabIndex = 0;
            this.textBoxFamilia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPress);
            // 
            // textBoxImya
            // 
            this.textBoxImya.Location = new System.Drawing.Point(12, 94);
            this.textBoxImya.Name = "textBoxImya";
            this.textBoxImya.Size = new System.Drawing.Size(128, 20);
            this.textBoxImya.TabIndex = 1;
            this.textBoxImya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPressN);
            // 
            // textBoxOtchestvo
            // 
            this.textBoxOtchestvo.Location = new System.Drawing.Point(12, 133);
            this.textBoxOtchestvo.Name = "textBoxOtchestvo";
            this.textBoxOtchestvo.Size = new System.Drawing.Size(128, 20);
            this.textBoxOtchestvo.TabIndex = 2;
            this.textBoxOtchestvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPressO);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 172);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(128, 20);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPressE);
            // 
            // labelFamilia
            // 
            this.labelFamilia.AutoSize = true;
            this.labelFamilia.Location = new System.Drawing.Point(12, 41);
            this.labelFamilia.Name = "labelFamilia";
            this.labelFamilia.Size = new System.Drawing.Size(56, 13);
            this.labelFamilia.TabIndex = 4;
            this.labelFamilia.Text = "Фамилия";
            // 
            // labelImya
            // 
            this.labelImya.AutoSize = true;
            this.labelImya.Location = new System.Drawing.Point(12, 80);
            this.labelImya.Name = "labelImya";
            this.labelImya.Size = new System.Drawing.Size(29, 13);
            this.labelImya.TabIndex = 5;
            this.labelImya.Text = "Имя";
            // 
            // labelOtchestvo
            // 
            this.labelOtchestvo.AutoSize = true;
            this.labelOtchestvo.Location = new System.Drawing.Point(12, 117);
            this.labelOtchestvo.Name = "labelOtchestvo";
            this.labelOtchestvo.Size = new System.Drawing.Size(54, 13);
            this.labelOtchestvo.TabIndex = 6;
            this.labelOtchestvo.Text = "Отчество";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 156);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(522, 335);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 43);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(613, 335);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 43);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(704, 335);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(85, 43);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewManagers
            // 
            this.listViewManagers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewManagers.FullRowSelect = true;
            this.listViewManagers.GridLines = true;
            this.listViewManagers.Location = new System.Drawing.Point(146, 41);
            this.listViewManagers.MultiSelect = false;
            this.listViewManagers.Name = "listViewManagers";
            this.listViewManagers.Size = new System.Drawing.Size(642, 151);
            this.listViewManagers.TabIndex = 11;
            this.listViewManagers.UseCompatibleStateImageBehavior = false;
            this.listViewManagers.View = System.Windows.Forms.View.Details;
            this.listViewManagers.SelectedIndexChanged += new System.EventHandler(this.listViewManagers_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ФИО";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            // 
            // listViewFL
            // 
            this.listViewFL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewFL.FullRowSelect = true;
            this.listViewFL.GridLines = true;
            this.listViewFL.Location = new System.Drawing.Point(146, 219);
            this.listViewFL.MultiSelect = false;
            this.listViewFL.Name = "listViewFL";
            this.listViewFL.Size = new System.Drawing.Size(302, 106);
            this.listViewFL.TabIndex = 12;
            this.listViewFL.UseCompatibleStateImageBehavior = false;
            this.listViewFL.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО";
            // 
            // listViewUL
            // 
            this.listViewUL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewUL.FullRowSelect = true;
            this.listViewUL.GridLines = true;
            this.listViewUL.Location = new System.Drawing.Point(454, 219);
            this.listViewUL.MultiSelect = false;
            this.listViewUL.Name = "listViewUL";
            this.listViewUL.Size = new System.Drawing.Size(334, 106);
            this.listViewUL.TabIndex = 13;
            this.listViewUL.UseCompatibleStateImageBehavior = false;
            this.listViewUL.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Название";
            // 
            // labelFL
            // 
            this.labelFL.AutoSize = true;
            this.labelFL.Location = new System.Drawing.Point(143, 203);
            this.labelFL.Name = "labelFL";
            this.labelFL.Size = new System.Drawing.Size(98, 13);
            this.labelFL.TabIndex = 14;
            this.labelFL.Text = "Физические лица";
            // 
            // labelUL
            // 
            this.labelUL.AutoSize = true;
            this.labelUL.Location = new System.Drawing.Point(451, 203);
            this.labelUL.Name = "labelUL";
            this.labelUL.Size = new System.Drawing.Size(102, 13);
            this.labelUL.TabIndex = 15;
            this.labelUL.Text = "Юридические лица";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Kval_Ekz.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 331);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(158, 71);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 16;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Managers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelUL);
            this.Controls.Add(this.labelFL);
            this.Controls.Add(this.listViewUL);
            this.Controls.Add(this.listViewFL);
            this.Controls.Add(this.listViewManagers);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelOtchestvo);
            this.Controls.Add(this.labelImya);
            this.Controls.Add(this.labelFamilia);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxOtchestvo);
            this.Controls.Add(this.textBoxImya);
            this.Controls.Add(this.textBoxFamilia);
            this.Name = "Managers_Form";
            this.Text = "Агенты";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFamilia;
        private System.Windows.Forms.TextBox textBoxImya;
        private System.Windows.Forms.TextBox textBoxOtchestvo;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelFamilia;
        private System.Windows.Forms.Label labelImya;
        private System.Windows.Forms.Label labelOtchestvo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewManagers;
        private System.Windows.Forms.ListView listViewFL;
        private System.Windows.Forms.ListView listViewUL;
        private System.Windows.Forms.Label labelFL;
        private System.Windows.Forms.Label labelUL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}