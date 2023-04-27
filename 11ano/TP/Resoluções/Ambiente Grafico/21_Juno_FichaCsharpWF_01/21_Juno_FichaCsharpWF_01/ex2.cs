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
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }

        private void ex2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            txtsoma.Text = (int.Parse(txt1.Text) + int.Parse(txt2.Text)).ToString();
        }
    }
}
