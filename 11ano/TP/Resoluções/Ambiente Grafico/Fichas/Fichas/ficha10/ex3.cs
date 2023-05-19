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
    public partial class ex3 : Form
    {
        public ex3()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lst1.SelectedIndices.Count > 0)
            {
                for (int i = lst1.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int selectedIndex = lst1.SelectedIndices[i];
                    lst1.Items.RemoveAt(selectedIndex);
                }
            }
        }

        private void btnAcrescenta_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(txt1.Text);
        }

        private void btnJunta_Click(object sender, EventArgs e)
        {
            string res = "";

            if (lst1.SelectedIndex != -1)
            {
                foreach (string aux in lst1.SelectedItems)
                {
                    res += " - " + aux;
                }
            }
            lblSelect.Text = res;
        }

    }
}
