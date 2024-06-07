using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public double ValorTotal { get; set; }

        public List<Item> Itens {  get; set; } = new List<Item>();

        public Tema(string nome, double valor, List<Item> itens)
        {
            Nome = nome;
            ValorTotal = CalcularTotal();
            Itens = itens;

        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema atualizar = (Tema)novoRegistro;

            Nome = atualizar.Nome;
            ValorTotal = atualizar.ValorTotal;
            Itens = atualizar.Itens;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"Nome\" é obrigatório");

            return erros;
        }

        public double CalcularTotal()
        {
            ValorTotal = 0;

            foreach (Item item in Itens)
                ValorTotal += item.Valor;

            return ValorTotal;
        }

       
    }
}
