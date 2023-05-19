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
    public partial class ex6 : Form
    {
        public ex6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opcao = groupBox1.Controls.OfType<RadioButton>()
.FirstOrDefault(r => r.Checked)?.Text;
            MessageBox.Show(opcao);
        }
    }
}
