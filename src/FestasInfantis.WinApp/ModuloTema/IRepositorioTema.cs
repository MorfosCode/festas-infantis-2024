namespace FestasInfantis.WinApp.ModuloTema
{
    public interface IRepositorioTema
    {
        void Cadastrar(Tema novoTema);

        void CadastrarVarios(List<Tema> temas);

        bool Editar(int id, Tema temaEditado);
        bool Excluir(int id);

        Tema SelecionarPorId(int idSelecionado);

        List<Tema> SelecionarTodos();
    }
}