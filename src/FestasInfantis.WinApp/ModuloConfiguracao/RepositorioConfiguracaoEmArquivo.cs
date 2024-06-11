using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using FestasInfantis.WinApp.Compartilhado;
using Microsoft.Win32;

namespace FestasInfantis.WinApp.ModuloConfiguracao
{
    public class RepositorioConfiguracaoEmArquivo
    {
        protected Configuracao configuracao = new Configuracao();
        private string caminho;

        #region Construtor
        public RepositorioConfiguracaoEmArquivo()
        {
            caminho = $"C:\\eAgenda\\repositorio\\configuracao.json";

            configuracao = DeserializarRegistros();
        }
        #endregion

        #region Configuração
        public void Cadastrar(Configuracao configuracao)
        {
            this.configuracao = configuracao;
            SerializarRegistros();
        }
        #endregion

        #region Edita entidade
        public bool Editar(Configuracao novaConfiguracao)
        {
            Configuracao configuracao = new Configuracao();

            this.configuracao.AtualizarRegistro(novaConfiguracao);

            SerializarRegistros();

            return true;
        }
        #endregion

        #region Seleciona todos registros e retorna em uma lista
        public Configuracao SelecionarTodos()
        {
            return configuracao;
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
            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(configuracao, options);
            File.WriteAllBytes(caminho, registrosEmBytes);
        }
        #endregion

        #region Deserealiza dados de um arquivo
        protected Configuracao DeserializarRegistros()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return new Configuracao();

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            Configuracao configuracao = JsonSerializer.Deserialize<Configuracao>(registrosEmBytes, options);

            return configuracao;
        }
        #endregion
    }
}
