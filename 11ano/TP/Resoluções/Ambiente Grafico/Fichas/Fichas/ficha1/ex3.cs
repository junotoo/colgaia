using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichas.ficha1
{
    public partial class ex3 : Form
    {
        public ex3()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            txtFinal.Text = "Olá, " + txtNome.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFinal.Text = "";
            txtNome.Text = "";
        }
    }
}
