namespace pingPong
{
    partial class frCadastro
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btFinalizaCadastro = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(44, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(41, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // btFinalizaCadastro
            // 
            this.btFinalizaCadastro.Location = new System.Drawing.Point(44, 198);
            this.btFinalizaCadastro.Name = "btFinalizaCadastro";
            this.btFinalizaCadastro.Size = new System.Drawing.Size(75, 23);
            this.btFinalizaCadastro.TabIndex = 2;
            this.btFinalizaCadastro.Text = "Cadastrar";
            this.btFinalizaCadastro.UseVisualStyleBackColor = true;
            this.btFinalizaCadastro.Click += new System.EventHandler(this.btFinalizaCadastro_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(135, 198);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 3;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(41, 75);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(44, 91);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(41, 116);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(44, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Location = new System.Drawing.Point(41, 156);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(86, 13);
            this.lblConfirmaSenha.TabIndex = 9;
            this.lblConfirmaSenha.Text = "Confirmar senha:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(44, 172);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmarSenha.TabIndex = 8;
            // 
            // frCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btFinalizaCadastro);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "frCadastro";
            this.Text = "frCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btFinalizaCadastro;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
    }
}