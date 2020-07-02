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
    public partial class FL_Form : Form
    {
        public FL_Form()
        {
            InitializeComponent();
            ShowManagers();
            ShowFL();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFamilia.Text != "" && textBoxImya.Text != "" && textBoxOtchestvo.Text != "" && textBoxDate.Text != "" && textBoxAddress.Text != "" && comboBoxManagers.SelectedItem != null && comboBoxPol.SelectedItem != null)
            {
                FL managers = new FL();
                managers.Familia = textBoxFamilia.Text;
                managers.Imya = textBoxImya.Text;
                managers.Otchestvo = textBoxOtchestvo.Text;
                managers.Date = Convert.ToDateTime(textBoxDate.Text);
                managers.Address = textBoxAddress.Text;
                managers.Pol = comboBoxPol.SelectedItem.ToString();
                managers.Id_manager = Convert.ToInt32(comboBoxManagers.SelectedItem.ToString().Split('.')[0]);
                Program.wtfDb.FL.Add(managers);
                Program.wtfDb.SaveChanges();
                ShowFL();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listViewFL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFL.SelectedItems.Count == 1)
            {
                FL fl = listViewFL.SelectedItems[0].Tag as FL;
                textBoxFamilia.Text = fl.Familia;
                textBoxImya.Text = fl.Imya;
                textBoxOtchestvo.Text = fl.Otchestvo;
                textBoxDate.Text = fl.Date.ToString().Substring(0, 10);
                comboBoxManagers.SelectedIndex = comboBoxManagers.FindString(fl.Id_manager.ToString());
                comboBoxPol.SelectedIndex = comboBoxManagers.FindString(fl.Pol.ToString());
                textBoxAddress.Text = fl.Address;
            }
            else
            {
                textBoxFamilia.Text = "";
                textBoxImya.Text = "";
                textBoxOtchestvo.Text = "";
                textBoxDate.Text = "";
                comboBoxManagers.SelectedItem=null;
                comboBoxPol.SelectedItem=null;
                textBoxAddress.Text = "";
            }
        }
        void ShowManagers()
        {
            comboBoxManagers.Items.Clear();
            foreach (Managers managers in Program.wtfDb.Managers)
            {
                string[] item = { managers.Id.ToString() + ". ", managers.Familia+" "+ managers.Imya + " " + managers.Otchestvo };
                comboBoxManagers.Items.Add(string.Join(" ", item));
            }
        }
        void ShowFL()
        {
            listViewFL.Items.Clear();
            foreach (FL managers in Program.wtfDb.FL)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        managers.Id.ToString(),managers.Familia+" "+managers.Imya+" "+managers.Otchestvo,
                        managers.Date.ToString().Substring(0,10),managers.Address,managers.Pol,managers.Id_manager.ToString()
                    });
                item.Tag = managers;
                listViewFL.Items.Add(item);
            }
            listViewFL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewFL.SelectedItems.Count == 1)
            {
                if (textBoxFamilia.Text != "" && textBoxImya.Text != "" && textBoxOtchestvo.Text != "" && textBoxDate.Text != "" && textBoxAddress.Text != "" && comboBoxManagers.SelectedItem != null && comboBoxPol.SelectedItem != null)
                {
                    FL managers = listViewFL.SelectedItems[0].Tag as FL;
                    managers.Familia = textBoxFamilia.Text;
                    managers.Imya = textBoxImya.Text;
                    managers.Otchestvo = textBoxOtchestvo.Text;
                    managers.Date = Convert.ToDateTime(textBoxDate.Text);
                    managers.Address = textBoxAddress.Text;
                    managers.Pol = comboBoxPol.SelectedItem.ToString();
                    managers.Id_manager = Convert.ToInt32(comboBoxManagers.SelectedItem.ToString().Split('.')[0]);
                    Program.wtfDb.SaveChanges();
                    ShowFL();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFL.SelectedItems.Count == 1)
                {
                    FL fl = listViewFL.SelectedItems[0].Tag as FL;
                    Program.wtfDb.FL.Remove(fl);
                    Program.wtfDb.SaveChanges();
                    ShowFL();
                }
                textBoxFamilia.Text = "";
                textBoxImya.Text = "";
                textBoxOtchestvo.Text = "";
                textBoxDate.Text = "";
                comboBoxManagers.SelectedItem = null;
                comboBoxPol.SelectedItem = null;
                textBoxAddress.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void letterControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsLetter(number) && !Char.IsControl(number)) || textBoxFamilia.Text.Length == 80)
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
            if (textBoxDate.Text.Length == 10 || (!Char.IsControl(number) && !Char.IsDigit(number) && number!='.'))
            {
                e.Handled = true;
            }
        }

        private void letterControl_KeyPressA(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (textBoxAddress.Text.Length == 80 && !Char.IsControl(number) )
            {
                e.Handled = true;
            }
        }
    }
}
