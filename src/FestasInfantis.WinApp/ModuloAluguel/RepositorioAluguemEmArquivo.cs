using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    internal class RepositorioAluguemEmArquivo : RepositorioBaseEmArquivo<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguemEmArquivo() : base("alugul.json")
        {
        }
    }
}
