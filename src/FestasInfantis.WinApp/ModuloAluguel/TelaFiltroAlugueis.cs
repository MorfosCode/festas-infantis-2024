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
    public partial class TelaFiltroAlugueis : Form
    {
        public TipoFiltroAluguelEnum FiltroEscolhido { get; private set; }
        public TelaFiltroAlugueis()
        {
            InitializeComponent();
        }

        private void TelaPesquisaCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rdbPendentes.Checked)
                FiltroEscolhido = TipoFiltroAluguelEnum.Pendentes;

            else if (rdbFinalizado.Checked)
                FiltroEscolhido = TipoFiltroAluguelEnum.Concluidos;
        }
    
    }
}
