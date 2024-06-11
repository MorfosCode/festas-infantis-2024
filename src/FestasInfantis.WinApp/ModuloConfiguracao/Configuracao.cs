using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FestasInfantis.WinApp.ModuloConfiguracao
{
    public class Configuracao : EntidadeBase
    {
        public double PercentualPorAluguel { get; set; }
        public double PercentualMaximoDeDesconto { get; set; }

        #region Construtores de classe
        public Configuracao()
        {

        }

        public Configuracao(double percentualPorAluguel, double percentualMaximoDeDesconto)
        {
            this.PercentualPorAluguel = percentualPorAluguel;
            this.PercentualMaximoDeDesconto = percentualMaximoDeDesconto;
        }
        #endregion

        #region Atualização de registro de configurações
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Configuracao configuracaoAtualizada = (Configuracao)novoRegistro;

            PercentualPorAluguel = configuracaoAtualizada.PercentualPorAluguel;
            PercentualMaximoDeDesconto = configuracaoAtualizada.PercentualMaximoDeDesconto;
        }
        #endregion

        #region Validação de dados
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(PercentualPorAluguel.ToString().Trim()))
                erros.Add("O campo \"PERCENTUAL DE DESCONTO POR ALUGUEL\" é obrigatório");

            if (string.IsNullOrEmpty(PercentualMaximoDeDesconto.ToString().Trim()))
                erros.Add("O campo \"PERCENTUAL MÁXIMO DE DESCONTO\" é obrigatório");

            return erros;
        }
        #endregion
    }
}
