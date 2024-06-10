namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaCadastroAluguelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlAlugueis = new TabControl();
            tabPageDadosFesta = new TabPage();
            groupBoxEndereco = new GroupBox();
            comboBoxEstados = new ComboBox();
            txtCidade = new TextBox();
            txtNumeroEndereco = new TextBox();
            txtBairro = new TextBox();
            txtRua = new TextBox();
            lblNumero = new Label();
            lblUf = new Label();
            lblBairro = new Label();
            lblCidade = new Label();
            lblRua = new Label();
            groupBoxDataHora = new GroupBox();
            dateTimePickerHoraTermino = new DateTimePicker();
            dateTimePickerHoraInicio = new DateTimePicker();
            dateTimePickerDataFesta = new DateTimePicker();
            lblHoraTermino = new Label();
            lblHoraInicio = new Label();
            lblData = new Label();
            tabPageDadosAluguel = new TabPage();
            groupBoxDadosCliente = new GroupBox();
            comboBoxSinal = new ComboBox();
            comboBoxTemas = new ComboBox();
            comboBoxClientes = new ComboBox();
            lblTema = new Label();
            lblSinal = new Label();
            lblCliente = new Label();
            groupBoxDadosPagamento = new GroupBox();
            lblPorcento = new Label();
            lblValorPendente = new Label();
            lblTotalComDesconto = new Label();
            lblValorSinal = new Label();
            lblTotal = new Label();
            lblPercentualDEsconto = new Label();
            txtTotalComDesconto = new TextBox();
            txtValorSinal = new TextBox();
            txtValorPendente = new TextBox();
            txtTotal = new TextBox();
            txtDesconto = new TextBox();
            btnCalcular = new Button();
            lblId = new Label();
            txtId = new TextBox();
            btnCancelar = new Button();
            btnLimpar = new Button();
            btnSalvar = new Button();
            tabControlAlugueis.SuspendLayout();
            tabPageDadosFesta.SuspendLayout();
            groupBoxEndereco.SuspendLayout();
            groupBoxDataHora.SuspendLayout();
            tabPageDadosAluguel.SuspendLayout();
            groupBoxDadosCliente.SuspendLayout();
            groupBoxDadosPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAlugueis
            // 
            tabControlAlugueis.Controls.Add(tabPageDadosFesta);
            tabControlAlugueis.Controls.Add(tabPageDadosAluguel);
            tabControlAlugueis.Location = new Point(7, 67);
            tabControlAlugueis.Name = "tabControlAlugueis";
            tabControlAlugueis.SelectedIndex = 0;
            tabControlAlugueis.Size = new Size(723, 428);
            tabControlAlugueis.TabIndex = 0;
            // 
            // tabPageDadosFesta
            // 
            tabPageDadosFesta.Controls.Add(groupBoxEndereco);
            tabPageDadosFesta.Controls.Add(groupBoxDataHora);
            tabPageDadosFesta.Location = new Point(4, 28);
            tabPageDadosFesta.Name = "tabPageDadosFesta";
            tabPageDadosFesta.Padding = new Padding(3);
            tabPageDadosFesta.Size = new Size(715, 396);
            tabPageDadosFesta.TabIndex = 0;
            tabPageDadosFesta.Text = "Dados da Festa";
            tabPageDadosFesta.UseVisualStyleBackColor = true;
            // 
            // groupBoxEndereco
            // 
            groupBoxEndereco.Controls.Add(comboBoxEstados);
            groupBoxEndereco.Controls.Add(txtCidade);
            groupBoxEndereco.Controls.Add(txtNumeroEndereco);
            groupBoxEndereco.Controls.Add(txtBairro);
            groupBoxEndereco.Controls.Add(txtRua);
            groupBoxEndereco.Controls.Add(lblNumero);
            groupBoxEndereco.Controls.Add(lblUf);
            groupBoxEndereco.Controls.Add(lblBairro);
            groupBoxEndereco.Controls.Add(lblCidade);
            groupBoxEndereco.Controls.Add(lblRua);
            groupBoxEndereco.Location = new Point(6, 186);
            groupBoxEndereco.Name = "groupBoxEndereco";
            groupBoxEndereco.Size = new Size(694, 191);
            groupBoxEndereco.TabIndex = 1;
            groupBoxEndereco.TabStop = false;
            groupBoxEndereco.Text = "Dados do Endereço";
            // 
            // comboBoxEstados
            // 
            comboBoxEstados.FormattingEnabled = true;
            comboBoxEstados.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxEstados.Location = new Point(583, 134);
            comboBoxEstados.Name = "comboBoxEstados";
            comboBoxEstados.Size = new Size(96, 27);
            comboBoxEstados.TabIndex = 7;
            // 
            // txtCidade
            // 
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.Location = new Point(179, 135);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(350, 27);
            txtCidade.TabIndex = 6;
            // 
            // txtNumeroEndereco
            // 
            txtNumeroEndereco.Location = new Point(179, 88);
            txtNumeroEndereco.Name = "txtNumeroEndereco";
            txtNumeroEndereco.Size = new Size(101, 27);
            txtNumeroEndereco.TabIndex = 4;
            txtNumeroEndereco.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(354, 88);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(325, 27);
            txtBairro.TabIndex = 5;
            // 
            // txtRua
            // 
            txtRua.CharacterCasing = CharacterCasing.Upper;
            txtRua.Location = new Point(179, 39);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(500, 27);
            txtRua.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(144, 91);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(26, 20);
            lblNumero.TabIndex = 100;
            lblNumero.Text = "Nº";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(544, 138);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(29, 20);
            lblUf.TabIndex = 100;
            lblUf.Text = "UF:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(290, 91);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(52, 20);
            lblBairro.TabIndex = 100;
            lblBairro.Text = "Bairro:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(111, 138);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(56, 20);
            lblCidade.TabIndex = 100;
            lblCidade.Text = "Cidade";
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(131, 42);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(37, 20);
            lblRua.TabIndex = 100;
            lblRua.Text = "Rua:";
            // 
            // groupBoxDataHora
            // 
            groupBoxDataHora.Controls.Add(dateTimePickerHoraTermino);
            groupBoxDataHora.Controls.Add(dateTimePickerHoraInicio);
            groupBoxDataHora.Controls.Add(dateTimePickerDataFesta);
            groupBoxDataHora.Controls.Add(lblHoraTermino);
            groupBoxDataHora.Controls.Add(lblHoraInicio);
            groupBoxDataHora.Controls.Add(lblData);
            groupBoxDataHora.Location = new Point(6, 6);
            groupBoxDataHora.Name = "groupBoxDataHora";
            groupBoxDataHora.Size = new Size(694, 174);
            groupBoxDataHora.TabIndex = 0;
            groupBoxDataHora.TabStop = false;
            groupBoxDataHora.Text = "Data e Hora";
            // 
            // dateTimePickerHoraTermino
            // 
            dateTimePickerHoraTermino.CustomFormat = "HH:MM";
            dateTimePickerHoraTermino.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoraTermino.Location = new Point(179, 126);
            dateTimePickerHoraTermino.Name = "dateTimePickerHoraTermino";
            dateTimePickerHoraTermino.ShowUpDown = true;
            dateTimePickerHoraTermino.Size = new Size(101, 27);
            dateTimePickerHoraTermino.TabIndex = 2;
            // 
            // dateTimePickerHoraInicio
            // 
            dateTimePickerHoraInicio.CustomFormat = "HH:MM";
            dateTimePickerHoraInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoraInicio.Location = new Point(179, 78);
            dateTimePickerHoraInicio.Name = "dateTimePickerHoraInicio";
            dateTimePickerHoraInicio.ShowUpDown = true;
            dateTimePickerHoraInicio.Size = new Size(101, 27);
            dateTimePickerHoraInicio.TabIndex = 1;
            // 
            // dateTimePickerDataFesta
            // 
            dateTimePickerDataFesta.Format = DateTimePickerFormat.Short;
            dateTimePickerDataFesta.Location = new Point(179, 30);
            dateTimePickerDataFesta.Name = "dateTimePickerDataFesta";
            dateTimePickerDataFesta.Size = new Size(143, 27);
            dateTimePickerDataFesta.TabIndex = 0;
            // 
            // lblHoraTermino
            // 
            lblHoraTermino.AutoSize = true;
            lblHoraTermino.Location = new Point(29, 129);
            lblHoraTermino.Name = "lblHoraTermino";
            lblHoraTermino.Size = new Size(124, 20);
            lblHoraTermino.TabIndex = 100;
            lblHoraTermino.Text = "Hora de Término:";
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Location = new Point(50, 81);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(106, 20);
            lblHoraInicio.TabIndex = 100;
            lblHoraInicio.Text = "Hora de Início:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(53, 33);
            lblData.Name = "lblData";
            lblData.Size = new Size(103, 20);
            lblData.TabIndex = 100;
            lblData.Text = "Data da Festa:";
            // 
            // tabPageDadosAluguel
            // 
            tabPageDadosAluguel.Controls.Add(groupBoxDadosCliente);
            tabPageDadosAluguel.Controls.Add(groupBoxDadosPagamento);
            tabPageDadosAluguel.Location = new Point(4, 28);
            tabPageDadosAluguel.Name = "tabPageDadosAluguel";
            tabPageDadosAluguel.Padding = new Padding(3);
            tabPageDadosAluguel.Size = new Size(715, 396);
            tabPageDadosAluguel.TabIndex = 1;
            tabPageDadosAluguel.Text = "Dados do Aluguel";
            tabPageDadosAluguel.UseVisualStyleBackColor = true;
            // 
            // groupBoxDadosCliente
            // 
            groupBoxDadosCliente.Controls.Add(comboBoxSinal);
            groupBoxDadosCliente.Controls.Add(comboBoxTemas);
            groupBoxDadosCliente.Controls.Add(comboBoxClientes);
            groupBoxDadosCliente.Controls.Add(lblTema);
            groupBoxDadosCliente.Controls.Add(lblSinal);
            groupBoxDadosCliente.Controls.Add(lblCliente);
            groupBoxDadosCliente.Location = new Point(6, 6);
            groupBoxDadosCliente.Name = "groupBoxDadosCliente";
            groupBoxDadosCliente.Size = new Size(703, 131);
            groupBoxDadosCliente.TabIndex = 1;
            groupBoxDadosCliente.TabStop = false;
            groupBoxDadosCliente.Text = "Dados do Cliente";
            // 
            // comboBoxSinal
            // 
            comboBoxSinal.FormattingEnabled = true;
            comboBoxSinal.Location = new Point(498, 81);
            comboBoxSinal.Name = "comboBoxSinal";
            comboBoxSinal.Size = new Size(135, 27);
            comboBoxSinal.TabIndex = 2;
            // 
            // comboBoxTemas
            // 
            comboBoxTemas.FormattingEnabled = true;
            comboBoxTemas.Location = new Point(72, 81);
            comboBoxTemas.MaxLength = 1;
            comboBoxTemas.Name = "comboBoxTemas";
            comboBoxTemas.Size = new Size(361, 27);
            comboBoxTemas.TabIndex = 1;
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(72, 27);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(561, 27);
            comboBoxClientes.TabIndex = 0;
            comboBoxClientes.SelectedIndexChanged += comboBoxClientes_SelectedIndexChanged;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Location = new Point(18, 84);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(48, 20);
            lblTema.TabIndex = 100;
            lblTema.Text = "Tema:";
            // 
            // lblSinal
            // 
            lblSinal.AutoSize = true;
            lblSinal.Location = new Point(449, 84);
            lblSinal.Name = "lblSinal";
            lblSinal.Size = new Size(44, 20);
            lblSinal.TabIndex = 100;
            lblSinal.Text = "Sinal:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(6, 31);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 100;
            lblCliente.Text = "Cliente:";
            // 
            // groupBoxDadosPagamento
            // 
            groupBoxDadosPagamento.Controls.Add(lblPorcento);
            groupBoxDadosPagamento.Controls.Add(lblValorPendente);
            groupBoxDadosPagamento.Controls.Add(lblTotalComDesconto);
            groupBoxDadosPagamento.Controls.Add(lblValorSinal);
            groupBoxDadosPagamento.Controls.Add(lblTotal);
            groupBoxDadosPagamento.Controls.Add(lblPercentualDEsconto);
            groupBoxDadosPagamento.Controls.Add(txtTotalComDesconto);
            groupBoxDadosPagamento.Controls.Add(txtValorSinal);
            groupBoxDadosPagamento.Controls.Add(txtValorPendente);
            groupBoxDadosPagamento.Controls.Add(txtTotal);
            groupBoxDadosPagamento.Controls.Add(txtDesconto);
            groupBoxDadosPagamento.Controls.Add(btnCalcular);
            groupBoxDadosPagamento.Location = new Point(6, 143);
            groupBoxDadosPagamento.Name = "groupBoxDadosPagamento";
            groupBoxDadosPagamento.Size = new Size(703, 241);
            groupBoxDadosPagamento.TabIndex = 0;
            groupBoxDadosPagamento.TabStop = false;
            groupBoxDadosPagamento.Text = "Dados do Pagamento";
            // 
            // lblPorcento
            // 
            lblPorcento.AutoSize = true;
            lblPorcento.Location = new Point(146, 100);
            lblPorcento.Name = "lblPorcento";
            lblPorcento.Size = new Size(21, 20);
            lblPorcento.TabIndex = 2;
            lblPorcento.Text = "%";
            // 
            // lblValorPendente
            // 
            lblValorPendente.AutoSize = true;
            lblValorPendente.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorPendente.Location = new Point(370, 194);
            lblValorPendente.Name = "lblValorPendente";
            lblValorPendente.Size = new Size(166, 20);
            lblValorPendente.TabIndex = 100;
            lblValorPendente.Text = "VALOR PENDENTE R$:";
            // 
            // lblTotalComDesconto
            // 
            lblTotalComDesconto.AutoSize = true;
            lblTotalComDesconto.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalComDesconto.Location = new Point(324, 147);
            lblTotalComDesconto.Name = "lblTotalComDesconto";
            lblTotalComDesconto.Size = new Size(201, 20);
            lblTotalComDesconto.TabIndex = 100;
            lblTotalComDesconto.Text = "TOTAL COM DESCONTO R$:";
            lblTotalComDesconto.Click += label4_Click;
            // 
            // lblValorSinal
            // 
            lblValorSinal.AutoSize = true;
            lblValorSinal.Location = new Point(419, 100);
            lblValorSinal.Name = "lblValorSinal";
            lblValorSinal.Size = new Size(125, 20);
            lblValorSinal.TabIndex = 100;
            lblValorSinal.Text = "Valor do Sinal R$:";
            lblValorSinal.Click += lblValorSinal_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(183, 100);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(74, 20);
            lblTotal.TabIndex = 100;
            lblTotal.Text = "TOTAL R$:";
            // 
            // lblPercentualDEsconto
            // 
            lblPercentualDEsconto.AutoSize = true;
            lblPercentualDEsconto.Location = new Point(6, 100);
            lblPercentualDEsconto.Name = "lblPercentualDEsconto";
            lblPercentualDEsconto.Size = new Size(63, 20);
            lblPercentualDEsconto.TabIndex = 100;
            lblPercentualDEsconto.Text = "% Desc.:";
            // 
            // txtTotalComDesconto
            // 
            txtTotalComDesconto.Enabled = false;
            txtTotalComDesconto.Location = new Point(572, 144);
            txtTotalComDesconto.Name = "txtTotalComDesconto";
            txtTotalComDesconto.Size = new Size(125, 27);
            txtTotalComDesconto.TabIndex = 1;
            txtTotalComDesconto.TextAlign = HorizontalAlignment.Right;
            txtTotalComDesconto.TextChanged += textBox9_TextChanged;
            // 
            // txtValorSinal
            // 
            txtValorSinal.Enabled = false;
            txtValorSinal.Location = new Point(572, 97);
            txtValorSinal.Name = "txtValorSinal";
            txtValorSinal.Size = new Size(125, 27);
            txtValorSinal.TabIndex = 1;
            txtValorSinal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtValorPendente
            // 
            txtValorPendente.Enabled = false;
            txtValorPendente.Location = new Point(572, 191);
            txtValorPendente.Name = "txtValorPendente";
            txtValorPendente.Size = new Size(125, 27);
            txtValorPendente.TabIndex = 1;
            txtValorPendente.TextAlign = HorizontalAlignment.Right;
            txtValorPendente.TextChanged += textBox7_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(276, 97);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 1;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDesconto
            // 
            txtDesconto.Enabled = false;
            txtDesconto.Location = new Point(86, 97);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(58, 27);
            txtDesconto.TabIndex = 1;
            txtDesconto.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.AutoSize = true;
            btnCalcular.Location = new Point(6, 30);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(691, 50);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(16, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(56, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 100;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(632, 501);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 35);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.AutoSize = true;
            btnLimpar.Location = new Point(532, 501);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 35);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(432, 501);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 35);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaCadastroAluguelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 548);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnCancelar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(tabControlAlugueis);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroAluguelForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaAluguel";
            tabControlAlugueis.ResumeLayout(false);
            tabPageDadosFesta.ResumeLayout(false);
            groupBoxEndereco.ResumeLayout(false);
            groupBoxEndereco.PerformLayout();
            groupBoxDataHora.ResumeLayout(false);
            groupBoxDataHora.PerformLayout();
            tabPageDadosAluguel.ResumeLayout(false);
            groupBoxDadosCliente.ResumeLayout(false);
            groupBoxDadosCliente.PerformLayout();
            groupBoxDadosPagamento.ResumeLayout(false);
            groupBoxDadosPagamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlAlugueis;
        private TabPage tabPageDadosFesta;
        private TabPage tabPageDadosAluguel;
        private Label lblId;
        private TextBox txtId;
        private GroupBox groupBoxDataHora;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePickerHoraInicio;
        private Label lblHoraTermino;
        private Label lblHoraInicio;
        private Label lblData;
        public DateTimePicker dateTimePickerDataFesta;
        private DateTimePicker dateTimePickerHoraTermino;
        private GroupBox groupBoxEndereco;
        private TextBox txtRua;
        private Label lblNumero;
        private Label lblUf;
        private Label lblBairro;
        private Label lblCidade;
        private Label lblRua;
        private ComboBox comboBoxEstados;
        private TextBox txtCidade;
        private TextBox txtNumeroEndereco;
        private TextBox txtBairro;
        private GroupBox groupBoxDadosCliente;
        private ComboBox comboBoxClientes;
        private Label lblCliente;
        private GroupBox groupBoxDadosPagamento;
        private Label lblTema;
        private Label lblSinal;
        private ComboBox comboBoxSinal;
        private ComboBox comboBoxTemas;
        private Label lblPercentualDEsconto;
        private TextBox txtTotalComDesconto;
        private TextBox txtValorSinal;
        private TextBox txtValorPendente;
        private TextBox txtTotal;
        private TextBox txtDesconto;
        private Button btnCalcular;
        private Label lblPorcento;
        private Label lblTotal;
        private Label lblValorSinal;
        private Label lblValorPendente;
        private Label lblTotalComDesconto;
        private Button btnCancelar;
        private Button btnLimpar;
        private Button btnSalvar;
    }
}