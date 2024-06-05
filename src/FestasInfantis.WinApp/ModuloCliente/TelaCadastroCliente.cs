using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaCadastroCliente : Form
    {
        private Cliente cliente;

        public Cliente Cliente
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                maskedTxtTelefone.Text = value.Telefone.ToString();
                maskedTxtCpf.Text = value.Cpf;
            }
            get
            {
                return cliente;
            }
        }

        #region Construtor
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos de botões
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNome.Clear();
            maskedTxtTelefone.Clear();
            maskedTxtCpf.Clear();
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = maskedTxtTelefone.Text;
            string cpf = maskedTxtCpf.Text;

            cliente = new Cliente(nome, telefone, cpf);

            List<string> erros = cliente.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
        #endregion
    }
}
