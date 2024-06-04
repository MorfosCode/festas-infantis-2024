namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaTemaForm
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
            btnCancelar = new Button();
            label1 = new Label();
            btnSalvar = new Button();
            label2 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtTema = new TextBox();
            ListBoxItem = new CheckedListBox();
            txtValor = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(433, 418);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 41);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(316, 418);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(123, 33);
            txtId.Name = "txtId";
            txtId.Size = new Size(48, 23);
            txtId.TabIndex = 0;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 82);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Tema:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 382);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Valor:";
            // 
            // txtTema
            // 
            txtTema.Location = new Point(123, 74);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(304, 23);
            txtTema.TabIndex = 7;
            // 
            // ListBoxItem
            // 
            ListBoxItem.FormattingEnabled = true;
            ListBoxItem.Location = new Point(123, 122);
            ListBoxItem.Name = "ListBoxItem";
            ListBoxItem.Size = new Size(304, 220);
            ListBoxItem.TabIndex = 8;
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Location = new Point(125, 380);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(302, 23);
            txtValor.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 126);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 10;
            label5.Text = "Itens:";
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(537, 463);
            Controls.Add(label5);
            Controls.Add(txtValor);
            Controls.Add(ListBoxItem);
            Controls.Add(txtTema);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaTemaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Tema";
            Load += TelaItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Label label1;
        private Button btnSalvar;
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private Label label4;
        private TextBox txtTema;
        private CheckedListBox ListBoxItem;
        private TextBox txtValor;
        private Label label5;
    }
}