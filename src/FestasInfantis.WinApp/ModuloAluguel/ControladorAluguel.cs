using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase, IControladorFiltravel
    {
        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioCliente repositorioCliente;
        private IRepositorioTema repositorioTema;

        private TabelaAluguelControl tabelaAluguel;

        #region Construtor
        public ControladorAluguel(IRepositorioAluguel repositorio, IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema)
        {
            this.repositorioAluguel = repositorio;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
        }
        #endregion

        #region Declarações
        public override string TipoCadastro { get { return "Aluguel"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar Aluguel"; } }

        public override string ToolTipEditar { get { return "Editar Aluguel"; } }

        public override string ToolTipExcluir { get { return "Excluir Aluguel"; } }

        public string ToolTipFiltrar => "FiltrarAluguel";



        #endregion


        #region Adiciona novo registro de aluguel
        public override void Adicionar()
        {
            TelaCadastroAluguelForm telaAluguel = new TelaCadastroAluguelForm();
            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Aluguel novoAluguel = telaAluguel.Aluguel;
            repositorioAluguel.Cadastrar(novoAluguel);

            CarregarAlugueis();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoAluguel.Id}\" foi criado com sucesso!");
        }
        #endregion

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }
        public void Filtrar()
        {
            TelaFiltroAlugueis telaFiltro = new TelaFiltroAlugueis();

            DialogResult resutado = telaFiltro .ShowDialog();

            if(resutado != DialogResult.OK) return;

            TipoFiltroAluguelEnum filtroSelecionado = telaFiltro.FiltroEscolhido;


            List<Aluguel> aluguelSelecionado;

            if (filtroSelecionado == TipoFiltroAluguelEnum.Concluidos)
                aluguelSelecionado = repositorioAluguel.SelecionarAluguelConcluido();
            else 
                aluguelSelecionado = repositorioAluguel.SelecionarAluguelPendente();

            tabelaAluguel.AtualizarRegistros(aluguelSelecionado);


            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"Visualizando \"{aluguelSelecionado.Count}\" registros...");
        }


    

        #region Obtem registro e retorna tabela de alugueis
        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAlugueis();

            return tabelaAluguel;
        }
        #endregion

        #region Carrega registros na lista de alugueis
        private void CarregarAlugueis()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();
            tabelaAluguel.AtualizarRegistros(alugueis);
        }

      
        #endregion
    }
}
