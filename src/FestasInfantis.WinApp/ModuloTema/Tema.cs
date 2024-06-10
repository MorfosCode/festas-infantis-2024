using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloTema
{
   public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public int Valor { get; set; }
        public List<Item> Itens {  get; set; }

        public Tema(string nome, List<Item> itens)
        {
            Nome = nome;
            Itens = itens;

        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema atualizar = (Tema)novoRegistro;

            Nome = atualizar.Nome;
            Valor = atualizar.Valor;
            Itens = atualizar.Itens;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"Tema\" é obrigatório");

            return erros;
        }

        internal void MarcarItens()
        {
            foreach (Item item in Itens)
            {
                item.Descricao = Nome;
            }
        }
        internal int ValorTema()
        {
            valor = 0;

            foreach (Item item in Itens)
                valor += item.Valor;

            return valor;
        }
    }
}
