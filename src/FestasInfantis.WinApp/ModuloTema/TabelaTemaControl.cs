using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.WinApp.Compartilhado;


namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(obterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();


        }
        public void AtualizarRegistros(List<Tema> temas)
        {
            grid.Rows.Clear();
            foreach (Tema tema in temas)
                grid.Rows.Add
                (
                    tema.Id,
                    tema.Nome,
                    tema.Valor
                    
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
                new DataGridViewTextBoxColumn{ DataPropertyName = "Tema", HeaderText = "Tema" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Valor", HeaderText = "Valor" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Aluguel", HeaderText = "Aluguel" }
            };
        }
    }
}
