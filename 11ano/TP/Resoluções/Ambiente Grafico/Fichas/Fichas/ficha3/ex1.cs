using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichas.ficha2
{
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }


        private void btnConfirma_Click(object sender, EventArgs e)
        {
            string opcao = groupBox2.Controls.OfType<RadioButton>()
            .FirstOrDefault(r => r.Checked)?.Text;
            if (!string.IsNullOrEmpty(opcao))txtCor.Text = opcao; else txtCor.Text = "";
            if (chklavagem.Checked) txtservico1.Text = "Lavagem"; else txtservico1.Text = "";
            if (chkOleo.Checked) txtServico2.Text = "Mudança de Óleo"; else txtServico2.Text = "";
            if (chkPneus.Checked) txtServico3.Text = "Troca de Pneus"; else txtServico3.Text = "";
        }
    }
}
