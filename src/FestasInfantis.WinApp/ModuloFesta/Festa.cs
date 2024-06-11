using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloFesta
{
    public class Festa : EntidadeBase
    {
        public DateTime DataFesta { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }
        public string Rua {  get; set; }
        public string NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade {  get; set; }
        public string Estado { get; set; }

        #region Construtor de classe
        public Festa
            (
                DateTime dataFesta,
                TimeSpan horaInicio,
                TimeSpan horaTermino,
                string rua,
                string numeroEndereco,
                string bairro,
                string cidade,
                string estado
            )
        {
            this.DataFesta = dataFesta;
            this.HoraInicio = horaInicio;
            this.HoraTermino = horaTermino;
            this.Rua = rua;
            this.NumeroEndereco = numeroEndereco;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
        }
        #endregion

        #region Atualização de registro de festa
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Festa festaAtualizada = (Festa)novoRegistro;

            DataFesta = festaAtualizada.DataFesta;
            HoraInicio = festaAtualizada.HoraInicio;
            HoraTermino = festaAtualizada.HoraTermino;
            Rua = festaAtualizada.Rua;
            NumeroEndereco = festaAtualizada.NumeroEndereco;
            Bairro = festaAtualizada.Bairro;
            Cidade = festaAtualizada.Cidade;
            Estado = festaAtualizada.Estado;
        }
        #endregion

        #region Validação de dados de entrada
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(DataFesta.ToString().Trim()))
                erros.Add("O campo \"DATA DA FESTA\" é obrigatório");

            if (string.IsNullOrEmpty(HoraInicio.ToString().Trim()))
                erros.Add("O campo \"HORA DE INÍCIO DA FESTA\" é obrigatório");

            if (string.IsNullOrEmpty(HoraTermino.ToString().Trim()))
                erros.Add("O campo \"HORA DO TÉRMINO DA FESTA\" é obrigatório");

            if (string.IsNullOrEmpty(Rua.Trim()))
                erros.Add("O campo \"RUA\" é obrigatório");

            if (string.IsNullOrEmpty(Bairro.Trim()))
                erros.Add("O campo \"BAIRRO\" é obrigatório");

            if (string.IsNullOrEmpty(Cidade.Trim()))
                erros.Add("O campo \"CIDADE\" é obrigatório");

            if (string.IsNullOrEmpty(Estado.Trim()))
                erros.Add("O campo \"ESTADO\" é obrigatório");

            return erros;
        }
        #endregion
    }
}
