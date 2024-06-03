using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private RepositorioCliente repositorioCliente;
        private TabelaClienteControl tabelaCliente;

        #region Contrutor
        public ControladorCliente(RepositorioCliente repositorio)
        {
            repositorioCliente = repositorio;
        }
        #endregion

        #region Declarações
        public override string TipoCadastro { get { return "Cliente"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar Cliente"; } }

        public override string ToolTipEditar { get { return "Editar Cliente"; } }

        public override string ToolTipExcluir { get { return "Excluir Cliente"; } }
        #endregion

        #region Adiciona novo registro de cliente
        public override void Adicionar()
        {
            TelaCadastroCliente telaCadastroCliente = new TelaCadastroCliente();
            DialogResult resultado = telaCadastroCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Cliente novoCliente = telaCadastroCliente.Cliente;
            repositorioCliente.Cadastrar(novoCliente);

            CarregarContatos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoCliente.Nome}\" foi criado com sucesso!");
        }
        #endregion

        #region Edita registro de cliente
        public override void Editar()
        {
            TelaCadastroCliente telaCadastroCliente = new TelaCadastroCliente();

            int idSelecionado = tabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaCadastroCliente.Cliente = clienteSelecionado;

            DialogResult resultado = telaCadastroCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Cliente clienteEditado = telaCadastroCliente.Cliente;

            repositorioCliente.Editar(clienteSelecionado.Id, clienteEditado);

            CarregarContatos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{clienteEditado.Nome}\" foi editado com sucesso!");
        }
        #endregion

        #region Exclui registro de cliente
        public override void Excluir()
        {
            int idSelecionado = tabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{clienteSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioCliente.Excluir(clienteSelecionado.Id);

            CarregarContatos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{clienteSelecionado.Nome}\" foi excluído com sucesso!");
        }
        #endregion

        #region Obtem registro e retorna tabela de clientes
        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarContatos();

            return tabelaCliente;
        }
        #endregion

        #region Contador de registros
        public int ContarRegistros()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            return clientes.Count();
        }
        #endregion

        #region Carrega registros na lista de clientes
        private void CarregarContatos()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();
            tabelaCliente.AtualizarRegistros(clientes);
        }
        #endregion
    }
}
