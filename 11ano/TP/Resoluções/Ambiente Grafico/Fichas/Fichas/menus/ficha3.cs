﻿using System;
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
    public partial class ficha3 : UserControl
    {
        public ficha3()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            ficha2.ex1 f = new ficha2.ex1();
            f.Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            Fichas.ficha3.ex2 f = new Fichas.ficha3.ex2();
            f.Show();
        }
    }
}
