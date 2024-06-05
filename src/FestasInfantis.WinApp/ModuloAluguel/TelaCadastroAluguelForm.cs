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

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaCadastroAluguelForm : Form
    {
        private Aluguel aluguel;

        public Aluguel Aluguel
        {
            set
            {
                txtId.Text = value.Id.ToString();

                txtRua.Text = value.ToString();
                txtNumeroEndereco.Text = value.ToString();
                txtBairro.Text = value.ToString();
                txtCidade.Text = value.ToString();
                comboBoxEstados.Text = value.ToString();

                dateTimePickerDataFesta.Text = value.ToString();
                dateTimePickerHoraInicio.Text = value.ToString();
                dateTimePickerHoraTermino.Text = value.ToString();

                comboBoxClientes.Text = value.ToString();
                comboBoxTemas.Text = value.ToString();

                txtDesconto.Text = value.percentualDesconto.ToString();
                txtTotal.Text = value.ToString();
                txtDesconto.Text = value.ToString();
                txtValorSinal.Text = value.ToString();
                txtTotalComDesconto.Text = value.ToString();
                txtValorPendente.Text = value.ToString();
            }
            get
            {
                return aluguel;
            }
        }

        public TelaCadastroAluguelForm()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dateTimePickerDataFesta.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dateTimePickerHoraInicio.Text = DateTime.Today.ToString("hh:mm");
            dateTimePickerHoraTermino.Text = DateTime.Today.ToString("hh:mm");
            txtRua.Clear();
            txtNumeroEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            comboBoxEstados.Items.Clear();
        }

        private void lblValorSinal_Click(object sender, EventArgs e)
        {

        }
    }
}
