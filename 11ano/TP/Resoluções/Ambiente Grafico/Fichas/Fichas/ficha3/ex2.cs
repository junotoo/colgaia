using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichas.ficha3
{
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string s = "A sua encomenda tem ingrediente extra de ";
            if (chkCogumelos.Checked) s = s + "Cogumelos";
            if (chkCogumelos.Checked && chkFiambre.Checked) s = s + ", ";
            if (chkFiambre.Checked) s = s + "Fiambre";
            if ((chkFiambre.Checked || chkPepp.Checked) && chkCogumelos.Checked) s = s + ", ";
            if (chkPepp.Checked) s = s + "Pepperoni";
            s += ", massa ";
            if (rdbFina.Checked) s += "fina"; else s += "normal";
            s += " e queijo ";
            if (rdbMoz.Checked) s += "mozzarela"; else s += "parmesão";
            if (rdbMoz.Checked)s= s + "Mozarella";
            MessageBox.Show(s,"Encomenda");
        }
    }
}
