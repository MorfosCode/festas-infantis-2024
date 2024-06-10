using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel.ModuloFesta;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {
        public Aluguel(List<Cliente> cliente, List<Tema> tema, int percentualEntrada, int percentualDesconto, 
             Festa festa)
        {
            Cliente = cliente;
            Tema = tema;
            this.percentualEntrada = percentualEntrada;
            this.percentualDesconto = percentualDesconto;
        
            Festa = festa;
        }

        public List<Cliente> Cliente { get; set; }

        public List <Tema> Tema { get; set; }
        public int percentualEntrada { get; set; }
        public int percentualDesconto { get; set; }
        public DateTime dataPagamento { get; set; }
        public bool status {  get; set; }

        public Festa Festa { get; set; }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
