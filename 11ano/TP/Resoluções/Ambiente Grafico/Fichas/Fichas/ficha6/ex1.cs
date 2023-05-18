using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichas.ficha6
{
    public partial class ex1 : Form
    {
        private List<int> numbers;
        public ex1()
        {
            InitializeComponent(); numbers = new List<int>();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int number))
            {
                numbers.Add(number);
                txtNumero.Clear();
            }
            else
            {
                MessageBox.Show("Número inválido. Por favor, insira um número válido.");
            }
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            if (numbers.Count > 0)
            {
                int maiorNumero = numbers.Max();
                txtResultado.Text = "Maior número: " + maiorNumero.ToString();
            }
            else
            {
                MessageBox.Show("Nenhum número foi inserido ainda.");
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            if (numbers.Count > 0)
            {
                double media = numbers.Average();
                txtResultado.Text = "Média: " + media.ToString();
            }
            else
            {
                MessageBox.Show("Nenhum número foi inserido ainda.");
            }
        }

        private void btnNovosNumeros_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            txtNumero.Clear();
            txtResultado.Clear();
        }
    }
}
