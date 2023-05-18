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
    
    public partial class ex2 : Form
    {
        private string[] diasSemana = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo" };
        private string[] estacoesAno = { "Primavera", "Verão", "Outono", "Inverno" };
        private string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

        public ex2()
        {
            InitializeComponent();
            lstResultados.Items.Clear();
        }

        private void rbtDiasSemanas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDiasSemana.Checked)
            {
                lstResultados.Items.Clear();
                foreach (string dia in diasSemana)
                {
                    lstResultados.Items.Add(dia);
                }
            }
        }

        private void rbtMeses_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMeses.Checked)
            {
                lstResultados.Items.Clear();
                foreach (string mes in meses)
                {
                    lstResultados.Items.Add(mes);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbtEstacoes_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtEstacoes.Checked)
            {
                lstResultados.Items.Clear();
                foreach (string estacao in estacoesAno)
                {
                    lstResultados.Items.Add(estacao);
                }
            }
        }
    }
}
