
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public interface IRepositorioAluguel
    {
        void Cadastrar(Aluguel novoAluguel);

        void CadastrarVarios(List<Aluguel> alugueis);

        bool Editar(int id, Aluguel aluguelEditado);
        bool Excluir(int id);

        Aluguel SelecionarPorId(int idSelecionado);

        List<Aluguel> SelecionarTodos();
    }
}
