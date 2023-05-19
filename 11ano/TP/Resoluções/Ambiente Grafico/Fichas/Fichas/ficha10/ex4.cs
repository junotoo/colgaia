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
    public partial class ex4 : Form
    {
        public ex4()
        {
            InitializeComponent();
        }

        private void btnAcresce_Click(object sender, EventArgs e)
        {
            try { 
                comboBox1.Items.Add(textBox1.Text);
                comboBox1.SelectedItem = textBox1.Text;
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = comboBox1.SelectedItem.ToString();
            }
            catch { }
        }
    }
}
