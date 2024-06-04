using eAgenda.ConsoleApp.Compartilhado;
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
        public string Valor { get; set; }

        public Tema(string nome, string valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema atualizar = (Tema)novoRegistro;

            Nome = atualizar.Nome;
            Valor = atualizar.Valor;
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
