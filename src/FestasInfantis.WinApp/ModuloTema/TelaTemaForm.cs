
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema;
        public Tema Tema
        {
            set
            {

                txtId.Text = value.Id.ToString();
                txtTema.Text = value.Nome;
                txtValor.Text = value.Valor.ToString();

            }
            get
            {
                return tema;
            }
        }

        public TelaTemaForm()
        {
            InitializeComponent();
            
        }
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtTema.Text;
            string valor = txtTema.Text;
            List<Item> itens =ListBoxItem.CheckedItems.Cast<Item>().ToList();       


            tema = new Tema(nome, valor);
          
            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
        private void TelaItemForm_Load(object sender, EventArgs e)
        {

        }

        private void ListBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
