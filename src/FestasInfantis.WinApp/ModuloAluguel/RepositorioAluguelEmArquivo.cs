using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class RepositorioAluguelEmArquivo : RepositorioBaseEmArquivo<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmArquivo() : base("aluguel.json")
        {
        }
        public List<Aluguel> SelecionarCompromissosPendentes()
            => registros
                .FindAll(aluguel => !aluguel.statusConcluido);

        public List<Aluguel> SelecionarCompromissosConcluidos()
            => registros
                .FindAll(aluguel => aluguel.statusConcluido);
    }
}
