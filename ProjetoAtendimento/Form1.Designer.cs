namespace ProjetoAtendimento
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGerarSenha;
        private System.Windows.Forms.Button btnAdicionarGuiche;
        private System.Windows.Forms.Button btnChamarSenha;
        private System.Windows.Forms.Button btnListarGuiches;
        private System.Windows.Forms.Button btnListarAtendimentos;
        private System.Windows.Forms.ListBox lstSenhas;
        private System.Windows.Forms.ListBox lstGuiches;
        private System.Windows.Forms.TextBox txtGuicheId;
        private System.Windows.Forms.Label lblGuicheId;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnGerarSenha = new Button();
            btnAdicionarGuiche = new Button();
            btnChamarSenha = new Button();
            btnListarGuiches = new Button();
            btnListarAtendimentos = new Button();
            lstSenhas = new ListBox();
            lstGuiches = new ListBox();
            txtGuicheId = new TextBox();
            lblGuicheId = new Label();
            SuspendLayout();
            // 
            // btnGerarSenha
            // 
            btnGerarSenha.Location = new Point(75, 48);
            btnGerarSenha.Margin = new Padding(4, 3, 4, 3);
            btnGerarSenha.Name = "btnGerarSenha";
            btnGerarSenha.Size = new Size(117, 27);
            btnGerarSenha.TabIndex = 0;
            btnGerarSenha.Text = "Gerar Senha";
            btnGerarSenha.UseVisualStyleBackColor = true;
            btnGerarSenha.Click += btnGerarSenha_Click;
            // 
            // btnAdicionarGuiche
            // 
            btnAdicionarGuiche.Location = new Point(433, 196);
            btnAdicionarGuiche.Margin = new Padding(4, 3, 4, 3);
            btnAdicionarGuiche.Name = "btnAdicionarGuiche";
            btnAdicionarGuiche.Size = new Size(117, 27);
            btnAdicionarGuiche.TabIndex = 1;
            btnAdicionarGuiche.Text = "Adicionar Guichê";
            btnAdicionarGuiche.UseVisualStyleBackColor = true;
            btnAdicionarGuiche.Click += btnAdicionarGuiche_Click;
            // 
            // btnChamarSenha
            // 
            btnChamarSenha.Location = new Point(563, 39);
            btnChamarSenha.Margin = new Padding(4, 3, 4, 3);
            btnChamarSenha.Name = "btnChamarSenha";
            btnChamarSenha.Size = new Size(117, 27);
            btnChamarSenha.TabIndex = 2;
            btnChamarSenha.Text = "Chamar Senha";
            btnChamarSenha.UseVisualStyleBackColor = true;
            btnChamarSenha.Click += btnChamarSenha_Click;
            // 
            // btnListarGuiches
            // 
            btnListarGuiches.Location = new Point(563, 196);
            btnListarGuiches.Margin = new Padding(4, 3, 4, 3);
            btnListarGuiches.Name = "btnListarGuiches";
            btnListarGuiches.Size = new Size(117, 27);
            btnListarGuiches.TabIndex = 3;
            btnListarGuiches.Text = "Listar Guichês";
            btnListarGuiches.UseVisualStyleBackColor = true;
            btnListarGuiches.Click += btnListarGuiches_Click;
            // 
            // btnListarAtendimentos
            // 
            btnListarAtendimentos.Location = new Point(75, 196);
            btnListarAtendimentos.Margin = new Padding(4, 3, 4, 3);
            btnListarAtendimentos.Name = "btnListarAtendimentos";
            btnListarAtendimentos.Size = new Size(117, 27);
            btnListarAtendimentos.TabIndex = 4;
            btnListarAtendimentos.Text = "Listar Atendimentos";
            btnListarAtendimentos.UseVisualStyleBackColor = true;
            btnListarAtendimentos.Click += btnListarAtendimentos_Click;
            // 
            // lstSenhas
            // 
            lstSenhas.FormattingEnabled = true;
            lstSenhas.ItemHeight = 15;
            lstSenhas.Location = new Point(14, 81);
            lstSenhas.Margin = new Padding(4, 3, 4, 3);
            lstSenhas.Name = "lstSenhas";
            lstSenhas.Size = new Size(247, 109);
            lstSenhas.TabIndex = 5;
            // 
            // lstGuiches
            // 
            lstGuiches.FormattingEnabled = true;
            lstGuiches.ItemHeight = 15;
            lstGuiches.Location = new Point(433, 81);
            lstGuiches.Margin = new Padding(4, 3, 4, 3);
            lstGuiches.Name = "lstGuiches";
            lstGuiches.Size = new Size(247, 109);
            lstGuiches.TabIndex = 6;
            // 
            // txtGuicheId
            // 
            txtGuicheId.Location = new Point(499, 42);
            txtGuicheId.Margin = new Padding(4, 3, 4, 3);
            txtGuicheId.Name = "txtGuicheId";
            txtGuicheId.Size = new Size(58, 23);
            txtGuicheId.TabIndex = 7;
            // 
            // lblGuicheId
            // 
            lblGuicheId.AutoSize = true;
            lblGuicheId.Location = new Point(433, 45);
            lblGuicheId.Margin = new Padding(4, 0, 4, 0);
            lblGuicheId.Name = "lblGuicheId";
            lblGuicheId.Size = new Size(58, 15);
            lblGuicheId.TabIndex = 8;
            lblGuicheId.Text = "Guichê ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 321);
            Controls.Add(lblGuicheId);
            Controls.Add(txtGuicheId);
            Controls.Add(lstGuiches);
            Controls.Add(lstSenhas);
            Controls.Add(btnListarAtendimentos);
            Controls.Add(btnListarGuiches);
            Controls.Add(btnChamarSenha);
            Controls.Add(btnAdicionarGuiche);
            Controls.Add(btnGerarSenha);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Gerenciamento de Senhas";
            ResumeLayout(false);
            PerformLayout();
        }
    }

}
