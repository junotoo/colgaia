﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichas.ficha1
{
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        private void btnQuem_Click(object sender, EventArgs e)
        {
            lblNoddy.Visible = true;
        }
    }
}
