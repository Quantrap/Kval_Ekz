namespace Kval_Ekz
{
    partial class UL_Form
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
            this.listViewUL = new System.Windows.Forms.ListView();
            this.labelManagers = new System.Windows.Forms.Label();
            this.comboBoxManagers = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.labelINN = new System.Windows.Forms.Label();
            this.textBoxKPP = new System.Windows.Forms.TextBox();
            this.labelKPP = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(703, 311);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(85, 43);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(612, 311);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 43);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(521, 311);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 43);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewUL
            // 
            this.listViewUL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewUL.FullRowSelect = true;
            this.listViewUL.GridLines = true;
            this.listViewUL.Location = new System.Drawing.Point(179, 48);
            this.listViewUL.MultiSelect = false;
            this.listViewUL.Name = "listViewUL";
            this.listViewUL.Size = new System.Drawing.Size(609, 257);
            this.listViewUL.TabIndex = 14;
            this.listViewUL.UseCompatibleStateImageBehavior = false;
            this.listViewUL.View = System.Windows.Forms.View.Details;
            this.listViewUL.SelectedIndexChanged += new System.EventHandler(this.listViewUL_SelectedIndexChanged);
            // 
            // labelManagers
            // 
            this.labelManagers.AutoSize = true;
            this.labelManagers.Location = new System.Drawing.Point(12, 196);
            this.labelManagers.Name = "labelManagers";
            this.labelManagers.Size = new System.Drawing.Size(44, 13);
            this.labelManagers.TabIndex = 36;
            this.labelManagers.Text = "Агенты";
            // 
            // comboBoxManagers
            // 
            this.comboBoxManagers.FormattingEnabled = true;
            this.comboBoxManagers.Location = new System.Drawing.Point(12, 212);
            this.comboBoxManagers.Name = "comboBoxManagers";
            this.comboBoxManagers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxManagers.TabIndex = 35;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 37;
            this.labelName.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(128, 20);
            this.textBoxName.TabIndex = 38;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPress);
            // 
            // textBoxINN
            // 
            this.textBoxINN.Location = new System.Drawing.Point(12, 90);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(128, 20);
            this.textBoxINN.TabIndex = 40;
            this.textBoxINN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPressN);
            // 
            // labelINN
            // 
            this.labelINN.AutoSize = true;
            this.labelINN.Location = new System.Drawing.Point(9, 74);
            this.labelINN.Name = "labelINN";
            this.labelINN.Size = new System.Drawing.Size(31, 13);
            this.labelINN.TabIndex = 39;
            this.labelINN.Text = "ИНН";
            // 
            // textBoxKPP
            // 
            this.textBoxKPP.Location = new System.Drawing.Point(12, 131);
            this.textBoxKPP.Name = "textBoxKPP";
            this.textBoxKPP.Size = new System.Drawing.Size(128, 20);
            this.textBoxKPP.TabIndex = 42;
            this.textBoxKPP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPressO);
            // 
            // labelKPP
            // 
            this.labelKPP.AutoSize = true;
            this.labelKPP.Location = new System.Drawing.Point(9, 115);
            this.labelKPP.Name = "labelKPP";
            this.labelKPP.Size = new System.Drawing.Size(30, 13);
            this.labelKPP.TabIndex = 41;
            this.labelKPP.Text = "КПП";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 154);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(38, 13);
            this.labelAddress.TabIndex = 44;
            this.labelAddress.Text = "Адрес";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(12, 170);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(128, 20);
            this.textBoxAddress.TabIndex = 43;
            this.textBoxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterControl_KeyPressA);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "КПП";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ИНН";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Адрес";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id Агента";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Kval_Ekz.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 283);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(158, 71);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 45;
            this.pictureBoxLogo.TabStop = false;
            // 
            // UL_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxKPP);
            this.Controls.Add(this.labelKPP);
            this.Controls.Add(this.textBoxINN);
            this.Controls.Add(this.labelINN);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelManagers);
            this.Controls.Add(this.comboBoxManagers);
            this.Controls.Add(this.listViewUL);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "UL_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Юридические лица";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewUL;
        private System.Windows.Forms.Label labelManagers;
        private System.Windows.Forms.ComboBox comboBoxManagers;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.Label labelINN;
        private System.Windows.Forms.TextBox textBoxKPP;
        private System.Windows.Forms.Label labelKPP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}