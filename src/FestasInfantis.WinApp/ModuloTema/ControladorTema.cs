using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private RepositorioTema repositorioTema;
        private RepositorioItem repositorioItem;
        
        private TabelaTemaControl tabelaTema;

        public ControladorTema(RepositorioTema repositorio, RepositorioItem repositorioItem)
        {
            this.repositorioTema = repositorio;
            this.repositorioItem = repositorioItem;
        }

        public override string TipoCadastro { get { return "Tema"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo Tema"; } }

        public override string ToolTipEditar { get { return "Editar um  Tema"; } }

        public override string ToolTipExcluir { get { return "Excluir um  Tema"; } }

        public override void Adicionar()
        {
            TelaTemaForm telaCadastrarTema = new TelaTemaForm(repositorioItem.SelecionarTodos());
            DialogResult resultado = telaCadastrarTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tema novoTema = telaCadastrarTema.Tema;
            repositorioTema.Cadastrar(novoTema);

            CarregarTemas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoTema.Nome}\" foi criado com sucesso!");

        }

        public override void Editar()
        {

            TelaTemaForm telaCadastroTema = new TelaTemaForm(repositorioItem.SelecionarTodos());

            int idSelecionado = tabelaTema.ObterRegistroSelecionado();

            Tema temaSelecionado = repositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaCadastroTema.Tema = temaSelecionado;

            DialogResult resultado = telaCadastroTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tema temaEditado = telaCadastroTema.Tema;

            repositorioTema.Editar(temaSelecionado.Id, temaEditado);

          

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{temaEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaTema.ObterRegistroSelecionado();

            Tema temaSelecionado = repositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{temaSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (resposta != DialogResult.Yes)
                return;

            repositorioTema.Excluir(temaSelecionado.Id);

            TelaPrincipalForm
               .Instancia
               .AtualizarRodape($"O registro \"{temaSelecionado.Nome}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTemas();

            return tabelaTema;
        }
        private void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();
            foreach (Tema tema in temas)
            {
                tema.ValorTotal = tema.CalcularTotal();
            }
            tabelaTema.AtualizarRegistros(temas);
        }
        public int ContarRegistros()
        {
            List<Tema> tema = repositorioTema.SelecionarTodos();

            return tema.Count();
        }
    }
}
