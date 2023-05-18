using Fichas.ficha1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void button1_Click(object sender, EventArgs e)
        {
            ficha1.ex1 f = new ficha1.ex1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ficha1.ex2 f = new ficha1.ex2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ficha1.ex3 f = new ficha1.ex3();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ficha1.ex4 f = new ficha1.ex4();
            f.Show();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFicha1_Click(object sender, EventArgs e)
        {
            ficha1_ucf.Visible = true;
            ficha1_ucf.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ficha31.Visible = true;
            ficha31.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ficha51.Visible = true;
            ficha51.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ficha61.Visible = true;
            ficha61.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ficha101.Visible = true;
            ficha101.BringToFront();
        }
    }
}
