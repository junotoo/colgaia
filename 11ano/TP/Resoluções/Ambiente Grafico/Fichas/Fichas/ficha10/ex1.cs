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
    public partial class ex1 : Form
    {
        int c = 0;
        public ex1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c++;
            lblCont.Text = "Contador: " + c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c--;
            lblCont.Text = "Contador: " + c.ToString();
        }
    }
}
