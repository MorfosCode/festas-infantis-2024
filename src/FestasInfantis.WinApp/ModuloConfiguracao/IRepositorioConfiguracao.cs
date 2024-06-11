using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloConfiguracao
{
    public interface IRepositorioConfiguracao
    {
        bool Editar(double PercentualDesconto, double PercentualDescontoMaximo);
    }
}
