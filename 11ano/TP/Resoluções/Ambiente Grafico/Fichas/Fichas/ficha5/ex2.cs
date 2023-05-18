using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichas.ficha5
{
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (int.Parse(textBox1.Text) > 0) label1.Text = "Positivo"; else if (int.Parse(textBox1.Text) < 0) label1.Text = "Negativo"; else label1.Text = "Nulo";
                label1.Visible = true;
            } catch { }
        }
    }
}
