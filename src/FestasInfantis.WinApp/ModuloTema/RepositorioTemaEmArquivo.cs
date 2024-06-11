using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class RepositorioTemaEmArquivo : RepositorioBaseEmArquivo<Tema>, IRepositorioTema
    {
        public RepositorioTemaEmArquivo() : base("tema.json")
        {

        }
    }
}
