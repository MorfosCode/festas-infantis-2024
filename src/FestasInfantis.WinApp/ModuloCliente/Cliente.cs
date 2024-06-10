using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestasInfantis.ConsoleApp.Compartilhado;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        //public Aluguel Aluguel { get; set; }

        #region Construtor de classe
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }
        #endregion

        #region Atualização de registro de cliente
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Cliente clienteAtualizado = (Cliente)novoRegistro;

            Nome = clienteAtualizado.Nome;
            Telefone = clienteAtualizado.Telefone;
            Cpf = clienteAtualizado.Cpf;
        }
        #endregion

        #region Validação de dados de entrada
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(Telefone.Trim()))
                erros.Add("O campo \"telefone\" é obrigatório");

            if (string.IsNullOrEmpty(Cpf.Trim()))
                erros.Add("O campo \"CPF\" é obrigatório");

            return erros;
        }
        #endregion

        public override string ToString()
        {
            return Nome;
        }
    }
}
