using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class TelaCadastroItem : Form
    {
        private Item item;
        public Item Item
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtDescrição.Text = value.descriao;
                txtValor.Text = value.valor;

            }
            get
            {
                return item;
            }
        }
        public TelaCadastroItem()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtDescrição.Text;
            string valor = txtValor.Text;


            item = new Item(nome, valor);

            List<string> erros = item.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

    }
}
