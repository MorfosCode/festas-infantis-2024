using FestasInfantis.ConsoleApp.Compartilhado;
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
        
        public string Descricao{ get; set; }
        public double Valor { get; set; }

        public Tema Tema { get; set; }

        public Item()
        {
           
        }
        public Item(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item atualizar = (Item)novoRegistro;

            Descricao = atualizar.Descricao;
            Valor = atualizar.Valor;
            Tema = atualizar.Tema;
        }

        public override List<string> Validar()
        {
        
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Descricao.Trim()))
                erros.Add("O campo \"Nome\" é obrigatório");


            return erros;
        }
        public override string ToString()
        {
            return $"Descrição: {Descricao} | Valor: R${Valor}";
        }

    }
}
