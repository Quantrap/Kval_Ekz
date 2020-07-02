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
    public partial class UL_Form : Form
    {
        public UL_Form()
        {
            InitializeComponent();
            ShowManagers();
            ShowUL();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxAddress.Text != "" && textBoxINN.Text != "" && textBoxKPP.Text != "" && comboBoxManagers.SelectedItem != null)
            {
                UL managers = new UL();
                managers.Name = textBoxName.Text;
                managers.Address = textBoxAddress.Text;
                managers.INN = textBoxINN.Text;
                managers.KPP = textBoxKPP.Text;
                managers.Id_manager = Convert.ToInt32(comboBoxManagers.SelectedItem.ToString().Split('.')[0]);
                Program.wtfDb.UL.Add(managers);
                Program.wtfDb.SaveChanges();
                ShowUL();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void ShowManagers()
        {
            comboBoxManagers.Items.Clear();
            foreach (Managers managers in Program.wtfDb.Managers)
            {
                string[] item = { managers.Id.ToString() + ". ", managers.Familia + " " + managers.Imya + " " + managers.Otchestvo };
                comboBoxManagers.Items.Add(string.Join(" ", item));
            }
        }
        void ShowUL()
        {
            listViewUL.Items.Clear();
            foreach (UL managers in Program.wtfDb.UL)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        managers.Id.ToString(),managers.Name,managers.KPP,managers.INN,
                        managers.Address,managers.Id_manager.ToString()
                    });
                item.Tag = managers;
                listViewUL.Items.Add(item);
            }
            listViewUL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewUL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUL.SelectedItems.Count == 1)
            {
                UL fl = listViewUL.SelectedItems[0].Tag as UL;
                textBoxName.Text = fl.Name;
                textBoxINN.Text = fl.INN;
                textBoxKPP.Text = fl.KPP;
                textBoxAddress.Text = fl.Address;
                comboBoxManagers.SelectedIndex = comboBoxManagers.FindString(fl.Id_manager.ToString());
            }
            else
            {
                textBoxName.Text = "";
                textBoxINN.Text = "";
                textBoxKPP.Text = "";
                textBoxAddress.Text = "";
                comboBoxManagers.SelectedItem=null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewUL.SelectedItems.Count == 1)
            {
                if (textBoxName.Text != "" && textBoxAddress.Text != "" && textBoxINN.Text != "" && textBoxKPP.Text != "" && comboBoxManagers.SelectedItem != null)
                {
                    UL managers = listViewUL.SelectedItems[0].Tag as UL;
                    managers.Name = textBoxName.Text;
                    managers.Address = textBoxAddress.Text;
                    managers.INN = textBoxINN.Text;
                    managers.KPP = textBoxKPP.Text;
                    managers.Id_manager = Convert.ToInt32(comboBoxManagers.SelectedItem.ToString().Split('.')[0]);
                    Program.wtfDb.SaveChanges();
                    ShowUL();
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
                if (listViewUL.SelectedItems.Count == 1)
                {
                    UL managers = listViewUL.SelectedItems[0].Tag as UL;
                    Program.wtfDb.UL.Remove(managers);
                    Program.wtfDb.SaveChanges();
                    ShowUL();
                }
                textBoxName.Text = "";
                textBoxINN.Text = "";
                textBoxKPP.Text = "";
                textBoxAddress.Text = "";
                comboBoxManagers.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void letterControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (textBoxName.Text.Length == 80 && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }

        private void letterControl_KeyPressN(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) && !Char.IsControl(number)) || textBoxINN.Text.Length == 80)
            {
                e.Handled = true;
            }
        }

        private void letterControl_KeyPressO(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) && !Char.IsControl(number)) || textBoxKPP.Text.Length == 80)
            {
                e.Handled = true;
            }
        }
        private void letterControl_KeyPressA(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (textBoxAddress.Text.Length == 80 && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }
    }
}
