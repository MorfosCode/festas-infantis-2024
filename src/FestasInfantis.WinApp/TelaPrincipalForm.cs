using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        RepositorioCliente repositorioClientes;
        RepositorioAluguel repositorioAluguel;

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            repositorioClientes = new RepositorioCliente();
            repositorioAluguel = new RepositorioAluguel();

            //Cadastra registro de cliente para teste
            CadastrarClientesTeste();
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            btnFiltrar.Enabled = controladorSelecionado is IControladorFiltravel;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is IControladorFiltravel controladorFiltravel)
                btnFiltrar.ToolTipText = controladorFiltravel.ToolTipFiltrar;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }


        private void clientesMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioClientes);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarTelaPrincipal(controlador);
        }

        #region Cadastra clientes para facilitar nos testes
        private void CadastrarClientesTeste()
        {
            List<Cliente> cliente = new List<Cliente>()
            {
                new Cliente("CARLOS EDUARDO DA SILVA", "(49) 9 9988 - 7766", "038.014.389-42"),
                new Cliente("JANAÍNA CARDOSO DE SOUZA", "(47) 9 9987 - 7665", "041.380.477-91"),
                new Cliente("MAÍZA DA CONCEIÇÃO", "(49) 9 9955 - 4433", "038.014.389-42"),
                new Cliente("ANDERSON WAIS MELO", "(48) 9 9944 - 3322", "081.924.259-64"),
                new Cliente("NICOLAU VASCONCELOZ", "(49) 9 9111 - 2233", "178.090.179-51"),
                new Cliente("JANDERLEI CUSTÓDIO DE OLIVAIRA", "(49) 9 9222 - 3344", "380.992.129-23"),
                new Cliente("ANA CRISTINA DE MELO PINTO", "(49) 9 9123 - 4567", "025.017.009-13"),
                new Cliente("MARIA EDUARDA DO NASCIMENTO", "(49) 9 9876 - 5432", "01.823.459-58"),
                new Cliente("DÉBORA MULLER", "(47) 9 9987 - 6543", "144.441.149-14"),
                new Cliente("MÁRCIO BECKER", "(49) 9 9812 - 3456", "044.173.999-98"),
            };

            repositorioClientes.CadastrarVarios(cliente);
        }
        #endregion

        #region Eventos de botões

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        #endregion


        private void festasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorAluguel(repositorioAluguel);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnConcluirAluguel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
