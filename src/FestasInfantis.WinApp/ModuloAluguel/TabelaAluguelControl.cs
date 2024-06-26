﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FestasInfantis.WinApp.Compartilhado;


namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(obterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();
            foreach (Aluguel aluguel in alugueis)
                grid.Rows.Add
                (
                    aluguel.Id
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
                new DataGridViewTextBoxColumn{ DataPropertyName = "id", HeaderText = "ID"},
                new DataGridViewTextBoxColumn{ DataPropertyName = "cliente", HeaderText = "Cliente" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Tema", HeaderText = "Tema" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "status", HeaderText = "Status" },  
                new DataGridViewTextBoxColumn{ DataPropertyName = "dia Pagamento", HeaderText = "Pagamento" },
            };
        }
    }
}
