namespace RBIntegracaoFront.Viwer.Usuario
{
    partial class frmAdicionarUsuario
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
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmacaoSenha = new System.Windows.Forms.Label();
            this.lblCnpjCpf = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtRacaoSocial = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.txtCpjCnpj = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(30, 120);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazaoSocial.TabIndex = 0;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(30, 157);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(81, 13);
            this.lblNomeFantasia.TabIndex = 1;
            this.lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 194);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(30, 231);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // lblConfirmacaoSenha
            // 
            this.lblConfirmacaoSenha.AutoSize = true;
            this.lblConfirmacaoSenha.Location = new System.Drawing.Point(30, 268);
            this.lblConfirmacaoSenha.Name = "lblConfirmacaoSenha";
            this.lblConfirmacaoSenha.Size = new System.Drawing.Size(103, 13);
            this.lblConfirmacaoSenha.TabIndex = 4;
            this.lblConfirmacaoSenha.Text = "Confirmação Senha:";
            // 
            // lblCnpjCpf
            // 
            this.lblCnpjCpf.AutoSize = true;
            this.lblCnpjCpf.Location = new System.Drawing.Point(30, 305);
            this.lblCnpjCpf.Name = "lblCnpjCpf";
            this.lblCnpjCpf.Size = new System.Drawing.Size(52, 13);
            this.lblCnpjCpf.TabIndex = 5;
            this.lblCnpjCpf.Text = "Cnpj/Cpf:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(30, 342);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtRacaoSocial
            // 
            this.txtRacaoSocial.Location = new System.Drawing.Point(131, 117);
            this.txtRacaoSocial.Name = "txtRacaoSocial";
            this.txtRacaoSocial.Size = new System.Drawing.Size(211, 20);
            this.txtRacaoSocial.TabIndex = 0;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(131, 154);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(211, 20);
            this.txtNomeFantasia.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(131, 224);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(211, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // txtConfirmacaoSenha
            // 
            this.txtConfirmacaoSenha.Location = new System.Drawing.Point(131, 261);
            this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            this.txtConfirmacaoSenha.PasswordChar = '*';
            this.txtConfirmacaoSenha.Size = new System.Drawing.Size(211, 20);
            this.txtConfirmacaoSenha.TabIndex = 4;
            // 
            // txtCpjCnpj
            // 
            this.txtCpjCnpj.Location = new System.Drawing.Point(131, 298);
            this.txtCpjCnpj.Name = "txtCpjCnpj";
            this.txtCpjCnpj.Size = new System.Drawing.Size(121, 20);
            this.txtCpjCnpj.TabIndex = 5;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Cliente",
            "Fornecedor",
            "Ambos"});
            this.cmbTipo.Location = new System.Drawing.Point(131, 333);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(322, 412);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(429, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(316, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 25);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Cadastro Usuário";
            // 
            // frmAdicionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 474);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtCpjCnpj);
            this.Controls.Add(this.txtConfirmacaoSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.txtRacaoSocial);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCnpjCpf);
            this.Controls.Add(this.lblConfirmacaoSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.lblRazaoSocial);
            this.Name = "frmAdicionarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmacaoSenha;
        private System.Windows.Forms.Label lblCnpjCpf;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtRacaoSocial;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmacaoSenha;
        private System.Windows.Forms.TextBox txtCpjCnpj;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
    }
}