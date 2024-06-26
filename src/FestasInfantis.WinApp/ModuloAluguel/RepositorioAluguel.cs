﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestasInfantis.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class RepositorioAluguel : RepositorioBaseEmMemoria<Aluguel>, IRepositorioAluguel
    {
        public List<Aluguel> SelecionarAluguelConcluido()
        {
            return registros
                  .FindAll(aluguel => aluguel.Status);
        }

        public List<Aluguel> SelecionarAluguelPendente()
        {
            return registros
                 .FindAll(aluguel => !aluguel.Status);
        }
    }
}
