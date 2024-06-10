using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.Compartilhado
{
    public class RepositorioBaseEmArquivo<T> where T : EntidadeBase
    {
        protected List<T> registros = new List<T>();
        protected int contadorId = 1;
        private string caminho = string.Empty;

        #region Construtor
        public RepositorioBaseEmArquivo(string nomeArquivo)
        {
            caminho = $"C:\\eAgenda\\repositorio\\{nomeArquivo}";

            registros = DeserializarRegistros();
        }
        #endregion

        #region Cadastra entidade
        public void Cadastrar(T novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            registros.Add(novoRegistro);

            SerializarRegistros();
        }
        #endregion

        #region Cadastra várias entidades de uma lista para facilitar os testes
        public void CadastrarVarios(List<T> registrosAdicionados)
        {
            foreach (T registro in registrosAdicionados)
            {
                registro.Id = contadorId++;
                registros.Add(registro);

                SerializarRegistros();
            }
        }
        #endregion

        #region Edita entidade
        public bool Editar(int id, T novaEntidade)
        {
            T registro = SelecionarPorId(id);

            if (registro == null)
                return false;

            registro.AtualizarRegistro(novaEntidade);

            SerializarRegistros();

            return true;
        }
        #endregion

        #region Exclui entidade
        public bool Excluir(int id)
        {
            bool conseguiuExcluir = registros.Remove(SelecionarPorId(id));

            if (!conseguiuExcluir)
                return false;

            SerializarRegistros();

            return true;
        }
        #endregion

        #region Seleciona todos registros e retorna em uma lista
        public List<T> SelecionarTodos()
        {
            return registros;
        }
        #endregion

        #region Seleciona entidade por um id
        public T SelecionarPorId(int id)
        {
            return registros.Find(x => x.Id == id);
        }
        #endregion

        #region Consulta se existe um registro com um determinado id
        public bool Existe(int id)
        {
            return registros.Any(x => x.Id == id);
        }
        #endregion

        #region Serealiza registro em um arquivo para persistir dados de forma permanete
        protected void SerializarRegistros()
        {
            FileInfo arquivo = new FileInfo(caminho);
            arquivo.Directory.Create();
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };
            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(registros, options);
            File.WriteAllBytes(caminho, registrosEmBytes);
        }
        #endregion

        #region Deserealiza dados de um arquivo
        protected List<T> DeserializarRegistros()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return new List<T>();

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            List<T> registros = JsonSerializer.Deserialize<List<T>>(registrosEmBytes, options);

            return registros;
        }
        #endregion
    }
}
