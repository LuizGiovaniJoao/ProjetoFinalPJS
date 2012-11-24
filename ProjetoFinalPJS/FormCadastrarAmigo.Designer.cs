namespace ProjetoFinalPJS
{
    partial class FormCadastrarAmigo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarAmigo));
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.tbxBairro = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbUf = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.tbxTelefoneMasc = new System.Windows.Forms.MaskedTextBox();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.tbxCelularMasc = new System.Windows.Forms.MaskedTextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lbApelido = new System.Windows.Forms.Label();
            this.tbxApelido = new System.Windows.Forms.TextBox();
            this.errorProviderAmigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAmigo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(12, 63);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(483, 20);
            this.tbxNome.TabIndex = 2;
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Location = new System.Drawing.Point(12, 102);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(483, 20);
            this.tbxEndereco.TabIndex = 3;
            // 
            // tbxBairro
            // 
            this.tbxBairro.Location = new System.Drawing.Point(12, 141);
            this.tbxBairro.Name = "tbxBairro";
            this.tbxBairro.Size = new System.Drawing.Size(220, 20);
            this.tbxBairro.TabIndex = 4;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(9, 47);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(9, 86);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 7;
            this.lbEndereco.Text = "Endereço";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(9, 125);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 8;
            this.lbBairro.Text = "Bairro";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(302, 125);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 9;
            this.lbCidade.Text = "Cidade";
            // 
            // lbUf
            // 
            this.lbUf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUf.AutoSize = true;
            this.lbUf.Location = new System.Drawing.Point(239, 125);
            this.lbUf.Name = "lbUf";
            this.lbUf.Size = new System.Drawing.Size(21, 13);
            this.lbUf.TabIndex = 10;
            this.lbUf.Text = "UF";
            // 
            // btSalvar
            // 
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalvar.Location = new System.Drawing.Point(258, 218);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "Adicionar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btGravar
            // 
            this.btGravar.Image = ((System.Drawing.Image)(resources.GetObject("btGravar.Image")));
            this.btGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGravar.Location = new System.Drawing.Point(339, 218);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 11;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Image")));
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimpar.Location = new System.Drawing.Point(420, 218);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(10, 205);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 14;
            this.lbTelefone.Text = "Telefone";
            // 
            // tbxTelefoneMasc
            // 
            this.tbxTelefoneMasc.Location = new System.Drawing.Point(13, 221);
            this.tbxTelefoneMasc.Name = "tbxTelefoneMasc";
            this.tbxTelefoneMasc.PromptChar = '0';
            this.tbxTelefoneMasc.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefoneMasc.TabIndex = 8;
            // 
            // cbxUF
            // 
            this.cbxUF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Location = new System.Drawing.Point(238, 141);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(61, 21);
            this.cbxUF.TabIndex = 6;
            this.cbxUF.SelectedIndexChanged += new System.EventHandler(this.cbxUF_SelectedIndexChanged_1);
            // 
            // tbxCelularMasc
            // 
            this.tbxCelularMasc.Location = new System.Drawing.Point(119, 221);
            this.tbxCelularMasc.Name = "tbxCelularMasc";
            this.tbxCelularMasc.Size = new System.Drawing.Size(100, 20);
            this.tbxCelularMasc.TabIndex = 9;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Location = new System.Drawing.Point(116, 206);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(39, 13);
            this.lbCelular.TabIndex = 18;
            this.lbCelular.Text = "Celular";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(9, 164);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 19;
            this.lbEmail.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(12, 181);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(483, 20);
            this.tbxEmail.TabIndex = 7;
            // 
            // lbApelido
            // 
            this.lbApelido.AutoSize = true;
            this.lbApelido.Location = new System.Drawing.Point(9, 9);
            this.lbApelido.Name = "lbApelido";
            this.lbApelido.Size = new System.Drawing.Size(42, 13);
            this.lbApelido.TabIndex = 21;
            this.lbApelido.Text = "Apelido";
            // 
            // tbxApelido
            // 
            this.tbxApelido.Location = new System.Drawing.Point(12, 25);
            this.tbxApelido.Name = "tbxApelido";
            this.tbxApelido.Size = new System.Drawing.Size(483, 20);
            this.tbxApelido.TabIndex = 1;
            // 
            // errorProviderAmigo
            // 
            this.errorProviderAmigo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderAmigo.ContainerControl = this;
            // 
            // cbxCidade
            // 
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(305, 141);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(190, 21);
            this.cbxCidade.TabIndex = 22;
            // 
            // FormCadastrarAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 260);
            this.Controls.Add(this.cbxCidade);
            this.Controls.Add(this.tbxApelido);
            this.Controls.Add(this.lbApelido);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.tbxCelularMasc);
            this.Controls.Add(this.cbxUF);
            this.Controls.Add(this.tbxTelefoneMasc);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbUf);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbxBairro);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.tbxNome);
            this.Name = "FormCadastrarAmigo";
            this.Text = "Cadatro de Amigo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastrarAmigo_FormClosing);
            this.Load += new System.EventHandler(this.FormCadastrarAmigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAmigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.TextBox tbxBairro;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbUf;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.MaskedTextBox tbxTelefoneMasc;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.MaskedTextBox tbxCelularMasc;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lbApelido;
        private System.Windows.Forms.TextBox tbxApelido;
        private System.Windows.Forms.ErrorProvider errorProviderAmigo;
        private System.Windows.Forms.ComboBox cbxCidade;
    }
}