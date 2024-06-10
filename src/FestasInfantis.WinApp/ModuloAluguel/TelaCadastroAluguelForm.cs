using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FestasInfantis.WinApp.ModuloAluguel.ModuloFesta;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaCadastroAluguelForm : Form
    {
        private Aluguel aluguel;

        public Aluguel Aluguel
        {
            set
            {
                txtRua.Text = value.ToString();
                txtNumeroEndereco.Text = value.Festa.Numero.ToString();
                txtBairro.Text = value.ToString();
                txtCidade.Text = value.ToString();
                comboBoxEstados.Text = value.ToString();

                dateTimePickerDataFesta.Text = value.Festa.DiaFesta.ToShortDateString();
                dateTimePickerHoraInicio.Text = value.ToString();
                dateTimePickerHoraTermino.Text = value.ToString();
                txtId.Text = value.Id.ToString();


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

        public void CarregarTemas(List<Tema> tema)
        {
            foreach (Tema temaList in tema)
            {
                comboBoxTemas.Items.Add(temaList);

            }
        }

        public void CarregarClientes(List<Cliente> cliente)
        {
            foreach (Cliente clienteList in cliente)
            {
                comboBoxClientes.Items.Add(clienteList);

            }
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



        #region sem uso
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblValorSinal_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            string rua = txtRua.Text, bairro = txtBairro.Text, cidade = txtCidade.Text;
            int numero = Convert.ToInt32(txtNumeroEndereco);

           List<Cliente> cliente =comboBoxClientes.Items.Cast<Cliente>().ToList();
           List<Tema> tema =comboBoxTemas.Items.Cast<Tema>().ToList();  

         //   aluguel = new Aluguel();

        }
    }
}
