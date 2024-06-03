namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaCadastroCliente
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
            labelId = new Label();
            txtId = new TextBox();
            listBox1 = new ListBox();
            labelNome = new Label();
            labelTelefone = new Label();
            labelCpf = new Label();
            txtNome = new TextBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnCancelar = new Button();
            maskedTxtTelefone = new MaskedTextBox();
            maskedTxtCpf = new MaskedTextBox();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(59, 24);
            labelId.Name = "labelId";
            labelId.Size = new Size(34, 25);
            labelId.TabIndex = 100;
            labelId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(99, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 31);
            txtId.TabIndex = 100;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 162);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(487, 154);
            listBox1.TabIndex = 100;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(28, 70);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(65, 25);
            labelNome.TabIndex = 100;
            labelNome.Text = "Nome:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(12, 116);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(81, 25);
            labelTelefone.TabIndex = 100;
            labelTelefone.Text = "Telefone:";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(312, 116);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(46, 25);
            labelCpf.TabIndex = 100;
            labelCpf.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Location = new Point(99, 67);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(400, 31);
            txtNome.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(205, 331);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 35);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.AutoSize = true;
            btnLimpar.Location = new Point(305, 331);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 35);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(405, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 35);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // maskedTxtTelefone
            // 
            maskedTxtTelefone.Location = new Point(99, 113);
            maskedTxtTelefone.Mask = "(00) 0 0000 - 0000";
            maskedTxtTelefone.Name = "maskedTxtTelefone";
            maskedTxtTelefone.Size = new Size(158, 31);
            maskedTxtTelefone.TabIndex = 1;
            // 
            // maskedTxtCpf
            // 
            maskedTxtCpf.Location = new Point(364, 113);
            maskedTxtCpf.Mask = "000,000,000-00";
            maskedTxtCpf.Name = "maskedTxtCpf";
            maskedTxtCpf.Size = new Size(135, 31);
            maskedTxtCpf.TabIndex = 2;
            // 
            // TelaCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 385);
            Controls.Add(maskedTxtCpf);
            Controls.Add(maskedTxtTelefone);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(listBox1);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(labelCpf);
            Controls.Add(labelTelefone);
            Controls.Add(labelNome);
            Controls.Add(labelId);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "TelaCadastroCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaCadastroCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private TextBox txtId;
        private ListBox listBox1;
        private Label labelNome;
        private Label labelTelefone;
        private Label labelCpf;
        private TextBox txtNome;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnCancelar;
        private MaskedTextBox maskedTxtTelefone;
        private MaskedTextBox maskedTxtCpf;
    }
}