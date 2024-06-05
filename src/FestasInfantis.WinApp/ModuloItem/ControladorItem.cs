using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        private RepositorioItem repositorioItem;
        private TabelaItemControl tabelaItem;

        public ControladorItem(RepositorioItem repositorioItem)
        {
          this.repositorioItem = repositorioItem;
        }

        public override string TipoCadastro { get { return "Item"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo Item"; } }

        public override string ToolTipEditar { get { return "Editar um Item"; } }

        public override string ToolTipExcluir { get { return "Excluir um Item"; } }
        public override void Adicionar()
        {
            TelaCadastroItem telaItem = new TelaCadastroItem();
            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item novoItem = telaItem.Item;
            repositorioItem.Cadastrar(novoItem);

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoItem.Descricao}\" foi criado com sucesso!");

        }

        public override void Editar()
        {
            TelaCadastroItem telaItem = new TelaCadastroItem();

            int idSelecionado = tabelaItem.ObterRegistroSelecionado();

            Item itemSelecionado = repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaItem.Item = itemSelecionado;

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item itemEditado = telaItem.Item;

            repositorioItem.Editar(itemSelecionado.Id, itemEditado);



            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{itemEditado.Descricao}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            TelaCadastroItem telaItem = new TelaCadastroItem();

            int idSelecionado = tabelaItem.ObterRegistroSelecionado();

            Item itemSelecionado = repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{itemSelecionado.Descricao}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (resposta != DialogResult.Yes)
                return;

            repositorioItem.Excluir(itemSelecionado.Id);

            TelaPrincipalForm
               .Instancia
               .AtualizarRodape($"O registro \"{itemSelecionado.Descricao}\" foi excluído com sucesso!");

        }

        public override UserControl ObterListagem()
        {
            if (tabelaItem == null)
                tabelaItem = new TabelaItemControl();


            CarregarItens();
            return tabelaItem;
        }

        public int ContarRegistros()
        {
            List<Item> item = repositorioItem.SelecionarTodos();

            return item.Count();
        }
        private void CarregarItens()
        {
            List<Item> itens = repositorioItem.SelecionarTodos();
            tabelaItem.AtualizarRegistros(itens);
        }
    }
}
