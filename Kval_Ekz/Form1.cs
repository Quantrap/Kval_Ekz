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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Managers_Click(object sender, EventArgs e)
        {
            Form formAgent = new Managers_Form();
            formAgent.Show();
        }

        private void FL_Click(object sender, EventArgs e)
        {
            Form formAgent = new FL_Form();
            formAgent.Show();
        }

        private void UL_Click(object sender, EventArgs e)
        {
            Form formAgent = new UL_Form();
            formAgent.Show();
        }
    }
}
