using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_Juno_FichaCsharpWF_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            Ex1 f = new Ex1();
            f.Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            ex2 f = new ex2();
            f.Show();
        }
    }
}
