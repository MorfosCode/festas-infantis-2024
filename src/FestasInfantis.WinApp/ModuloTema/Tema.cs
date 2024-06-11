using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;
using System.Drawing;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public double ValorTotal { get; set; }

        public List<Item> Itens {  get; set; } = new List<Item>();

        public Tema()
        {

        }

        public Tema(string nome, double valor, List<Item> itens)
        {
            Nome = nome;
            Itens = itens;
            ValorTotal = CalcularTotal();

        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema atualizar = (Tema)novoRegistro;

            ValorTotal = atualizar.ValorTotal;
            Nome = atualizar.Nome;
            Itens = atualizar.Itens;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"Tema\" é obrigatório");

            return erros;
        }

        public double CalcularTotal()
        {
            ValorTotal = 0;

            foreach (Item item in Itens)
                ValorTotal += item.Valor;

            return ValorTotal;
        }

        public override string ToString()
        {
            return $"Tema: {Nome} ";
        }
    }
}
