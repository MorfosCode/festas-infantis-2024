using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloConfiguracao
{
    public partial class TelaConfiguracao : Form
    {
        private Configuracao configuracao;

        public Configuracao Configuracao
        {
            set
            {
                textBoxPercentualDeDesconto.Text = value.ToString();
                textBoxPercentualMaximoDeDesconto.Text = value.ToString();
            }
            get
            {
                return configuracao;
            }
        }

        public TelaConfiguracao()
        {
            InitializeComponent();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxPercentualDeDesconto.Clear();
            textBoxPercentualMaximoDeDesconto.Clear();

            textBoxPercentualDeDesconto.Focus();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            double percentualDeDesconto = Convert.ToDouble(textBoxPercentualDeDesconto.Text);
            double percentualMaximoDeDesconto = Convert.ToDouble(textBoxPercentualMaximoDeDesconto.Text);

            configuracao = new Configuracao(percentualDeDesconto, percentualMaximoDeDesconto);

            List<string> erros = configuracao.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        public void AtualizarDados(Configuracao configuracao)
        {
            textBoxPercentualDeDesconto.Text = configuracao.PercentualPorAluguel.ToString();
            textBoxPercentualMaximoDeDesconto.Text = configuracao.PercentualMaximoDeDesconto.ToString();
        }
    }
}
