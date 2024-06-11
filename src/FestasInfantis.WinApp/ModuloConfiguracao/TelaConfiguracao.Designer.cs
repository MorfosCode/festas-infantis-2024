namespace FestasInfantis.WinApp.ModuloConfiguracao
{
    partial class TelaConfiguracao
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
            groupBox1 = new GroupBox();
            textBoxPercentualMaximoDeDesconto = new TextBox();
            textBoxPercentualDeDesconto = new TextBox();
            labelPercentualMaximoDeDesconto = new Label();
            labelPercentualDeDesconto = new Label();
            buttonCancelar = new Button();
            buttonLimpar = new Button();
            buttonSalvar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxPercentualMaximoDeDesconto);
            groupBox1.Controls.Add(textBoxPercentualDeDesconto);
            groupBox1.Controls.Add(labelPercentualMaximoDeDesconto);
            groupBox1.Controls.Add(labelPercentualDeDesconto);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(420, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurações";
            // 
            // textBoxPercentualMaximoDeDesconto
            // 
            textBoxPercentualMaximoDeDesconto.Location = new Point(315, 82);
            textBoxPercentualMaximoDeDesconto.Margin = new Padding(4);
            textBoxPercentualMaximoDeDesconto.Name = "textBoxPercentualMaximoDeDesconto";
            textBoxPercentualMaximoDeDesconto.Size = new Size(90, 27);
            textBoxPercentualMaximoDeDesconto.TabIndex = 1;
            // 
            // textBoxPercentualDeDesconto
            // 
            textBoxPercentualDeDesconto.Location = new Point(315, 32);
            textBoxPercentualDeDesconto.Margin = new Padding(4);
            textBoxPercentualDeDesconto.Name = "textBoxPercentualDeDesconto";
            textBoxPercentualDeDesconto.Size = new Size(90, 27);
            textBoxPercentualDeDesconto.TabIndex = 0;
            // 
            // labelPercentualMaximoDeDesconto
            // 
            labelPercentualMaximoDeDesconto.AutoSize = true;
            labelPercentualMaximoDeDesconto.Location = new Point(25, 85);
            labelPercentualMaximoDeDesconto.Margin = new Padding(4, 0, 4, 0);
            labelPercentualMaximoDeDesconto.Name = "labelPercentualMaximoDeDesconto";
            labelPercentualMaximoDeDesconto.Size = new Size(226, 20);
            labelPercentualMaximoDeDesconto.TabIndex = 0;
            labelPercentualMaximoDeDesconto.Text = "Percentual Máximo de Desconto:";
            // 
            // labelPercentualDeDesconto
            // 
            labelPercentualDeDesconto.AutoSize = true;
            labelPercentualDeDesconto.Location = new Point(8, 35);
            labelPercentualDeDesconto.Margin = new Padding(4, 0, 4, 0);
            labelPercentualDeDesconto.Name = "labelPercentualDeDesconto";
            labelPercentualDeDesconto.Size = new Size(248, 20);
            labelPercentualDeDesconto.TabIndex = 0;
            labelPercentualDeDesconto.Text = "Percentual de Desconto Por Aluguel:";
            // 
            // buttonCancelar
            // 
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(302, 166);
            buttonCancelar.Margin = new Padding(4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(118, 36);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseCompatibleTextRendering = true;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(176, 166);
            buttonLimpar.Margin = new Padding(4);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(118, 36);
            buttonLimpar.TabIndex = 3;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.DialogResult = DialogResult.OK;
            buttonSalvar.Location = new Point(50, 166);
            buttonSalvar.Margin = new Padding(4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(118, 36);
            buttonSalvar.TabIndex = 2;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // TelaConfiguracao
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 242);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonCancelar);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaConfiguracao";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração de Desconto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelPercentualMaximoDeDesconto;
        private Label labelPercentualDeDesconto;
        private TextBox textBoxPercentualMaximoDeDesconto;
        private TextBox textBoxPercentualDeDesconto;
        private Button buttonCancelar;
        private Button buttonLimpar;
        private Button buttonSalvar;
    }
}