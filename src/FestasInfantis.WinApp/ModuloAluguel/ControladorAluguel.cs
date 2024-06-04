﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private RepositorioAluguel repositorioAluguel;
        private TelaAluguel telaAluguel;
        private TabelaAluguelControl tabelaAluguel;

        #region Construtor
        public ControladorAluguel(RepositorioAluguel repositorio)
        {
            repositorioAluguel = repositorio;
        }
        #endregion

        #region Declarações
        public override string TipoCadastro { get { return "Aluguel"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar Aluguel"; } }

        public override string ToolTipEditar { get { return "Editar Aluguel"; } }

        public override string ToolTipExcluir { get { return "Excluir Aluguel"; } }
        #endregion

        #region Adiciona novo registro de aluguel
        public override void Adicionar()
        {
            TelaAluguel telaAluguel = new TelaAluguel();
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
