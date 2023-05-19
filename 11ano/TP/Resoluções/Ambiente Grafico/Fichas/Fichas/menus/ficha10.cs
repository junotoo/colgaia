using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichas.menus
{
    public partial class ficha10 : UserControl
    {
        public ficha10()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            Fichas.ficha10.ex1 f = new Fichas.ficha10.ex1();
            f.Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            Fichas.ficha10.ex2 f = new Fichas.ficha10.ex2();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fichas.ficha10.ex3 f = new Fichas.ficha10.ex3();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fichas.ficha10.ex4 f = new Fichas.ficha10.ex4();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fichas.ficha10.ex6 f = new Fichas.ficha10.ex6();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fichas.ficha10.ex5 f = new Fichas.ficha10.ex5();
            f.Show();
        }
    }
}
