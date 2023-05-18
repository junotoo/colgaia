using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichas.ficha10
{
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lstCidade.Items.RemoveAt(lstCidade.SelectedIndex);
            }
            catch { }
        }

        private void btnAcrescenta_Click(object sender, EventArgs e)
        {
            lstCidade.Items.Add(txtCidades.Text);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtCidades.Text = "";
        }

        private void btnInicia_Click(object sender, EventArgs e)
        {
            lstCidade.Items.Clear();
        }
    }
}
