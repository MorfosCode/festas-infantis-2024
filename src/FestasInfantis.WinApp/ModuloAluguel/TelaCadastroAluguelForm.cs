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
        private List<Tema> temasListados = new List<Tema>();

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

        public TelaCadastroAluguelForm(List<Cliente> listClientes, List<Tema> listTemas)
        {
            InitializeComponent();

            CarregarClientes(listClientes);
            CarregarTemas(listTemas);
        }

        private void CarregarTemas(List<Tema> listTemas)
        {
            comboBoxTemas.Items.Clear();
            foreach (Tema tema in listTemas)
            {
                comboBoxTemas.Items.Add(tema.Nome);
                temasListados.Add(tema);
            }
        }

        private void CarregarClientes(List<Cliente> listClientes)
        {
            comboBoxClientes.Items.Clear();
            foreach (Cliente cliente in listClientes)
                comboBoxClientes.Items.Add(cliente.Nome);
        }

        public void CarregarClientes(List<Cliente> cliente)
        {
            foreach (Cliente clienteList in cliente)
            {
                comboBoxClientes.Items.Add(clienteList);

                txtRua.Focus();
            }

            if (tabPageDadosAluguel.Focus() == true)
            {
                comboBoxClientes.SelectedIndex = -1;
                comboBoxTemas.SelectedIndex = -1;
                txtSinal.Clear();
                txtDesconto.Text = "00";
                txtTotal.Text = "00,00";
                txtValorSinal.Text = "00,00";
                txtTotalComDesconto.Text = "00,00";
                txtValorPendente.Text = "00,00";

                comboBoxClientes.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Clear();

            dateTimePickerDataFesta.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dateTimePickerHoraInicio.Text = DateTime.Today.ToString("HH:mm");
            dateTimePickerHoraTermino.Text = DateTime.Today.ToString("HH:mm");
            txtRua.Clear();
            txtNumeroEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            comboBoxEstados.SelectedIndex = -1;

            comboBoxClientes.SelectedIndex = -1;
            comboBoxTemas.SelectedIndex = -1;
            txtSinal.Clear();
            txtDesconto.Text = "00";    ;
            txtTotal.Text = "00,00";
            txtValorSinal.Text = "00,00";
            txtTotalComDesconto.Text = "00,00";
            txtValorPendente.Text = "00,00";

            txtRua.Focus();
        }

        private void textBoxSinal_Leave(object sender, EventArgs e)
        {
            txtValorSinal.Text = txtSinal.Text;
        }

        private void comboBoxTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tema tema;
            if (comboBoxTemas.SelectedIndex > -1)
            {
                tema = temasListados.ElementAt(comboBoxTemas.SelectedIndex);
                txtTotal.Text = tema.ValorTotal.ToString();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txtTotal.Text);
            double desconto = Convert.ToDouble(txtDesconto.Text);
            double sinal = Convert.ToDouble(txtSinal.Text);

            double totalComDesconto = total - desconto;

            double pendente = totalComDesconto - sinal;

            txtTotalComDesconto.Text = totalComDesconto.ToString();
            txtValorPendente.Text = pendente.ToString();
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

//O cadastro do Aluguel consiste de:

//cliente
//tema
//porcentagem de entrada
//porcentagem de desconto
//data do pagamento (caso conclúido)
//status
//festa

//4.1. A porcentagem de entrada é obrigatória e deverá ser selecionada entre os valores 40% e 50%.

//4.2. O cadastro da Festa será realizado durante o aluguel e consiste de: -endereço - data - hora de início - hora de término

//4.3. Deverá ser possivel filtrar a tabela de aluguéis entre aluguéis pendentes e concluídos.

//4.4. Deverá ser possível concluir um aluguel através de um botão na tela principal.
