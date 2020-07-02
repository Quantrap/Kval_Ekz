using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kval_Ekz
{
    public partial class Managers_Form : Form
    {
        public Managers_Form()
        {
            InitializeComponent();
            ShowAgents();
        }

        private void listViewManagers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewManagers.SelectedItems.Count == 1)
            {
                string k = "0";
                Managers managers = listViewManagers.SelectedItems[0].Tag as Managers;
                textBoxFamilia.Text = managers.Familia;
                textBoxImya.Text= managers.Imya;
                textBoxOtchestvo.Text= managers.Otchestvo;
                textBoxEmail.Text= managers.Email;
                foreach (UL ul in Program.wtfDb.UL)
                {
                    if (managers.Id == ul.Id_manager)
                    {
                        k=Convert.ToString(Convert.ToInt32(k)+1);
                        ListViewItem item = new ListViewItem(new string[]
                            {
                        ul.Id.ToString(),ul.Name
                            });
                        item.Tag = ul;
                        listViewUL.Items.Add(item);
                    }
                }
                labelUL.Text += " " + k;
                k = "0";
                listViewUL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                foreach (FL fl in Program.wtfDb.FL)
                {
                    if (managers.Id == fl.Id_manager)
                    {
                        k = Convert.ToString(Convert.ToInt32(k) + 1);
                        ListViewItem item = new ListViewItem(new string[]
                            {
                        fl.Id.ToString(),fl.Familia+" "+fl.Imya+" "+fl.Otchestvo
                            });
                        item.Tag = fl;
                        listViewFL.Items.Add(item);
                    }
                }
                labelFL.Text += " " + k;
                listViewFL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                labelFL.Text = "Физические лица";
                labelUL.Text = "Юридические лица";
                textBoxFamilia.Text = "";
                textBoxImya.Text = "";
                textBoxOtchestvo.Text = "";
                textBoxEmail.Text = "";
                listViewFL.Items.Clear();
                listViewUL.Items.Clear();
            }
        }
        void ShowAgents()
        {
            listViewManagers.Items.Clear();
            foreach (Managers managers in Program.wtfDb.Managers)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        managers.Id.ToString(),managers.Familia+" "+managers.Imya+" "+managers.Otchestvo,managers.Email
                    });
                item.Tag = managers;
                listViewManagers.Items.Add(item);
            }
            listViewManagers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFamilia.Text != "" && textBoxImya.Text != "" && textBoxOtchestvo.Text != "" && textBoxEmail.Text != "")
            {
                Managers managers = new Managers();
                managers.Familia = textBoxFamilia.Text;
                managers.Imya = textBoxImya.Text;
                managers.Otchestvo = textBoxOtchestvo.Text;
                managers.Email = textBoxEmail.Text;
                Program.wtfDb.Managers.Add(managers);
                Program.wtfDb.SaveChanges();
                ShowAgents();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxFamilia.Text != "" && textBoxImya.Text != "" && textBoxOtchestvo.Text != "" && textBoxEmail.Text != "")
            {
                Managers managers = listViewManagers.SelectedItems[0].Tag as Managers;
                managers.Familia = textBoxFamilia.Text;
                managers.Imya = textBoxImya.Text;
                managers.Otchestvo = textBoxOtchestvo.Text;
                managers.Email = textBoxEmail.Text;
                Program.wtfDb.SaveChanges();
                ShowAgents();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewManagers.SelectedItems.Count == 1)
                {
                    Managers managers = listViewManagers.SelectedItems[0].Tag as Managers;
                    Program.wtfDb.Managers.Remove(managers);
                    Program.wtfDb.SaveChanges();
                    ShowAgents();
                }
                textBoxFamilia.Text = "";
                textBoxImya.Text = "";
                textBoxOtchestvo.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void letterControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsLetter(number) &&  !Char.IsControl(number)) || textBoxFamilia.Text.Length==80)
            {
                e.Handled = true;
            }
        }

        private void letterControl_KeyPressN(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsLetter(number) && !Char.IsControl(number)) || textBoxImya.Text.Length == 80)
            {
                e.Handled = true;
            }
        }

        private void letterControl_KeyPressO(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsLetter(number) && !Char.IsControl(number)) || textBoxOtchestvo.Text.Length == 80)
            {
                e.Handled = true;
            }
        }

        private void letterControl_KeyPressE(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (textBoxEmail.Text.Length == 80 && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }
    }
}
