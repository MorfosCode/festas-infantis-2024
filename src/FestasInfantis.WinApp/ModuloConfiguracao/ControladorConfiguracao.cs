using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloConfiguracao
{
    public class ControladorConfiguracao
    {
        private RepositorioConfiguracaoEmArquivo repositorioConfiguracaoEmArquivo;
        private TelaConfiguracao telaConfiguracao;

        #region Construtor
        public ControladorConfiguracao(RepositorioConfiguracaoEmArquivo repositorio)
        {
            repositorioConfiguracaoEmArquivo = repositorio;
        }
        #endregion

        #region Declarações
        public string TipoCadastro { get { return "Configurações do Sistema"; } }

        public string ToolTipEditar { get { return "Configurações do Sistema"; } }
        #endregion

        #region Edita configuração
        public void Editar()
        {
            telaConfiguracao = new TelaConfiguracao();

            CarregarConfiguracao();

            DialogResult resultado = telaConfiguracao.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Configuracao configuracaoEditada = telaConfiguracao.Configuracao;

            repositorioConfiguracaoEmArquivo.Editar(configuracaoEditada);

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape("Configuração alterada com sucesso!");
        }
        #endregion

        #region Carrega registros na lista de clientes
        private void CarregarConfiguracao()
        {
            Configuracao configuracao = repositorioConfiguracaoEmArquivo.SelecionarTodos();
            telaConfiguracao.AtualizarDados(configuracao);
        }
        #endregion
    }
}
