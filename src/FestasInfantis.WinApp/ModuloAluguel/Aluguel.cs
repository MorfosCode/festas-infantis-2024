using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloFesta;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {
        
        public List<Cliente> Cliente { get; set; }

        public List <Tema> Tema { get; set; }
        public int PercentualEntrada { get; set; }
        public int PercentualDesconto { get; set; }
        public DateTime DataPagamento { get; set; }
        public bool Status{ get; set; } = false;
        public Festa Festa { get; set; }


        public Aluguel(
            List<Cliente> cliente, 
            List<Tema> tema, 
            int percentualEntrada, 
            int percentualDesconto, 
            DateTime dataPagamento, 
            bool status, 
            Festa festa)
        {
            Cliente = cliente;
            Tema = tema;
            PercentualEntrada = percentualEntrada;
            PercentualDesconto = percentualDesconto;
            DataPagamento = dataPagamento;
            Status = status;
            Festa = festa;
        }


        #region Atualização de registro
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel aluguelAtualizado = (Aluguel)novoRegistro;

            Cliente = aluguelAtualizado.Cliente;
            Tema = aluguelAtualizado.Tema;
            Festa = aluguelAtualizado.Festa;
            PercentualEntrada = aluguelAtualizado.PercentualEntrada;
            PercentualDesconto = aluguelAtualizado.PercentualDesconto;
            DataPagamento = aluguelAtualizado.DataPagamento;
            Status = aluguelAtualizado.Status;
        }
        #endregion

        #region Validação dos dados de entrada
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

        //    if (string.IsNullOrEmpty(Cliente.Nome.Trim()))
                erros.Add("O campo \"NOME DO CLIENTE\" é obrigatório");
           // if (string.IsNullOrEmpty(Tema.Nome.Trim()))
                erros.Add("O campo \"DESCRIÇÃO DO TEMA\" é obrigatório");
            if (string.IsNullOrEmpty(PercentualEntrada.ToString().Trim()))
                erros.Add("O campo \"PERCENTUAL DE ENTRADA\" é obrigatório");
            if (string.IsNullOrEmpty(PercentualDesconto.ToString().Trim()))
                erros.Add("O campo \"PERCENTUAL DE DESCONTO\" é obrigatório");

            return erros;
        }
        #endregion
    }
}
