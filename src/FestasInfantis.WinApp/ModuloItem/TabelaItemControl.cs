using eAgenda.WinApp.Compartilhado;
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
    public partial class TabelaItemControl : UserControl
    {
        public TabelaItemControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(obterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Item> items)
        {
            grid.Rows.Clear();
            foreach (Item item in items)
                grid.Rows.Add
                (
                    item.Id,
                    item.Descricao,
                    item.Valor

                );
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }
        private static DataGridViewColumn[] obterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn{ DataPropertyName = "Id", HeaderText = "ID" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Descrição", HeaderText = "Descrição" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Valor", HeaderText = "Valor" },
                
            };
        }
    }
}
