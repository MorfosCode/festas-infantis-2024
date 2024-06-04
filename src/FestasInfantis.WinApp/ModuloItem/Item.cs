using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class Item: EntidadeBase
    {
        
        public string descriao{ get; set; }
        public string valor { get; set; }
        public Item(string descriao, string valor)
        {
            descriao = descriao;
            valor = valor;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item atualizar = (Item)novoRegistro;

            descriao = atualizar.descriao;
            valor = atualizar.valor;
        }

        public override List<string> Validar()
        {
        
            List<string> erros = new List<string>();



         

            return erros;
        }
    }
}
