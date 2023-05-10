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

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if (txtInt.Text != "")
            {
                try {
                    if (int.Parse(txtInt.Text) % 2 == 0) lblPrimo.Text = "É primo"; else lblPrimo.Text = "Não é primo";
                            lblPrimo.Visible = true;
                        }
                catch { }
            }
        }
    }
}
