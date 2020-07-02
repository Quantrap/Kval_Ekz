namespace Kval_Ekz
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Managers = new System.Windows.Forms.Button();
            this.FL = new System.Windows.Forms.Button();
            this.UL = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Managers
            // 
            this.Managers.Location = new System.Drawing.Point(12, 89);
            this.Managers.Name = "Managers";
            this.Managers.Size = new System.Drawing.Size(159, 49);
            this.Managers.TabIndex = 0;
            this.Managers.Text = "Агенты";
            this.Managers.UseVisualStyleBackColor = true;
            this.Managers.Click += new System.EventHandler(this.Managers_Click);
            // 
            // FL
            // 
            this.FL.Location = new System.Drawing.Point(12, 144);
            this.FL.Name = "FL";
            this.FL.Size = new System.Drawing.Size(159, 49);
            this.FL.TabIndex = 1;
            this.FL.Text = "Физические лица";
            this.FL.UseVisualStyleBackColor = true;
            this.FL.Click += new System.EventHandler(this.FL_Click);
            // 
            // UL
            // 
            this.UL.Location = new System.Drawing.Point(12, 199);
            this.UL.Name = "UL";
            this.UL.Size = new System.Drawing.Size(159, 49);
            this.UL.TabIndex = 2;
            this.UL.Text = "Юридические лица";
            this.UL.UseVisualStyleBackColor = true;
            this.UL.Click += new System.EventHandler(this.UL_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Kval_Ekz.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(158, 71);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 261);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.UL);
            this.Controls.Add(this.FL);
            this.Controls.Add(this.Managers);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Managers;
        private System.Windows.Forms.Button FL;
        private System.Windows.Forms.Button UL;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

