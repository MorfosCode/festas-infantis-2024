namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaFiltroAlugueis
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
            btnSalvar = new Button();
            groupBox1 = new GroupBox();
            rdbFinalizado = new RadioButton();
            rdbPendentes = new RadioButton();
            btnCacelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(37, 185);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 35);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbFinalizado);
            groupBox1.Controls.Add(rdbPendentes);
            groupBox1.Location = new Point(37, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 101);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status Aluguel:";
            // 
            // rdbFinalizado
            // 
            rdbFinalizado.AutoSize = true;
            rdbFinalizado.Location = new Point(42, 66);
            rdbFinalizado.Name = "rdbFinalizado";
            rdbFinalizado.Size = new Size(83, 19);
            rdbFinalizado.TabIndex = 1;
            rdbFinalizado.TabStop = true;
            rdbFinalizado.Text = "Finalizados";
            rdbFinalizado.UseVisualStyleBackColor = true;
            // 
            // rdbPendentes
            // 
            rdbPendentes.AutoSize = true;
            rdbPendentes.Location = new Point(42, 30);
            rdbPendentes.Name = "rdbPendentes";
            rdbPendentes.Size = new Size(80, 19);
            rdbPendentes.TabIndex = 0;
            rdbPendentes.TabStop = true;
            rdbPendentes.Text = "Pendentes";
            rdbPendentes.UseVisualStyleBackColor = true;
            // 
            // btnCacelar
            // 
            btnCacelar.AutoSize = true;
            btnCacelar.DialogResult = DialogResult.Cancel;
            btnCacelar.Location = new Point(143, 185);
            btnCacelar.Name = "btnCacelar";
            btnCacelar.Size = new Size(94, 35);
            btnCacelar.TabIndex = 8;
            btnCacelar.Text = "Cancelar";
            btnCacelar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroAlugueis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 232);
            Controls.Add(btnCacelar);
            Controls.Add(groupBox1);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaFiltroAlugueis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtrar Aluguéis";
            Load += TelaPesquisaCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private GroupBox groupBox1;
        private RadioButton rdbFinalizado;
        private RadioButton rdbPendentes;
        private Button btnCacelar;
    }
}