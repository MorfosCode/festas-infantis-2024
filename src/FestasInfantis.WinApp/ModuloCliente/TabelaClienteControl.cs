using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {

        #region Construtor
        public TabelaClienteControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(obterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
            
        }
        #endregion

        #region Atualiza registros na tabela
        public void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();
            foreach (Cliente cliente in clientes)
                grid.Rows.Add(cliente.Id, cliente.Nome, cliente.Telefone, cliente.Cpf);
        }
        #endregion

        #region Retorna objeto que foi selecionado na tabela
        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }
        #endregion

        #region Constroi as colunas da tabela
        private static DataGridViewColumn[] obterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn{ DataPropertyName = "id", HeaderText = "ID" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Cliente", HeaderText = "Cliente" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Telefone", HeaderText = "Telefone" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Cpf", HeaderText = "CPF" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "quantidade", HeaderText = "Quantidade de Aluguéis" }
            };
        }
        #endregion
    }
}
