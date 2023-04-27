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
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void btnQuem_Click(object sender, EventArgs e)
        {
            lblNoddy.Visible = true;
        }
    }
}
