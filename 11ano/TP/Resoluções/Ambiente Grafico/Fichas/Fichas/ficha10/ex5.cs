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
    public partial class ex5 : Form
    {
        public ex5()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            lbl1.Text = "";
            if (chkordem.Checked) lbl1.Text += "Conta Ordem";
            if (chkPrazo.Checked) lbl1.Text += "Conta Prazo";
            if (chkCredito.Checked) lbl1.Text += " + Cartao de Credito";
            if (chkDebito.Checked) lbl1.Text += " + Cartão de Débito";
        }

        private void chkPrazo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrazo.Checked)
            {
                chkCredito.Checked = false;
                chkDebito.Checked = false;
                chkordem.Checked = false;
            }
        }
    }
}
