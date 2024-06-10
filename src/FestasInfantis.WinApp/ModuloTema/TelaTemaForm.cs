

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
                txtValor.Text = value.ValorTotal.ToString();

            }
            get
            {
                return tema;
            }
        }

        public TelaTemaForm(List<Item> itens)
        {
            InitializeComponent();
            CarregarItens(itens);
        }

        private void CarregarItens(List<Item> itens)
        {

            foreach (Item itensList in itens)
            {
                if (itensList.Tema == null)
                    ListBoxItem.Items.Add(itensList);

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtTema.Text;

            List<Item> itens = ListBoxItem.CheckedItems.Cast<Item>().ToList();
            double valor = Convert.ToDouble(txtValor.Text);

            tema = new Tema(nome, valor, itens);

            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void ListBoxItem_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<Item> itens = ListBoxItem.CheckedItems.Cast<Item>().ToList();

            List<Item> marcado = new List<Item>();

            foreach (Item itemMarcado in itens)
                marcado.Add(itemMarcado);


            if (e.NewValue == CheckState.Checked)
                marcado.Add((Item)ListBoxItem.Items[e.Index]);

            else marcado.Remove((Item)ListBoxItem.Items[e.Index]);

            double valorTotal = 0;

            foreach (Item itensList in marcado)
                valorTotal += itensList.Valor;

            txtValor.Text = valorTotal.ToString();
        }
    }
}
