namespace ProjetoFinalPJS
{
    partial class FormEmprestarMidia
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Musica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Album", System.Windows.Forms.HorizontalAlignment.Left);
            this.lblApelido = new System.Windows.Forms.Label();
            this.lbInterprete = new System.Windows.Forms.Label();
            this.cbxInterprete = new System.Windows.Forms.ComboBox();
            this.cbxApelido = new System.Windows.Forms.ComboBox();
            this.radioMusica = new System.Windows.Forms.RadioButton();
            this.radioAlbum = new System.Windows.Forms.RadioButton();
            this.lbMusica = new System.Windows.Forms.Label();
            this.lbTipoMidia = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.cbxMidia = new System.Windows.Forms.ComboBox();
            this.cbxAlbum = new System.Windows.Forms.ComboBox();
            this.cbxMusica = new System.Windows.Forms.ComboBox();
            this.lbDataEmprestimo = new System.Windows.Forms.Label();
            this.DtEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.cbxEndereco = new System.Windows.Forms.ComboBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.ListViewEmprestimos = new System.Windows.Forms.ListView();
            this.LVInterprete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVMusica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVMidia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVDTEmpres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbApelido = new System.Windows.Forms.Label();
            this.btEmprestar = new System.Windows.Forms.Button();
            this.errorProviderEmprestimo = new System.Windows.Forms.ErrorProvider(this.components);
            this.btRemover = new System.Windows.Forms.Button();
            this.tbxIdEmprestimo = new System.Windows.Forms.TextBox();
            this.radioButtonSelecao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApelido
            // 
            this.lblApelido.Location = new System.Drawing.Point(0, 0);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(100, 23);
            this.lblApelido.TabIndex = 53;
            // 
            // lbInterprete
            // 
            this.lbInterprete.AutoSize = true;
            this.lbInterprete.Location = new System.Drawing.Point(12, 72);
            this.lbInterprete.Name = "lbInterprete";
            this.lbInterprete.Size = new System.Drawing.Size(100, 13);
            this.lbInterprete.TabIndex = 3;
            this.lbInterprete.Text = "Nome do intérprete:";
            // 
            // cbxInterprete
            // 
            this.cbxInterprete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInterprete.Enabled = false;
            this.cbxInterprete.FormattingEnabled = true;
            this.cbxInterprete.Location = new System.Drawing.Point(12, 88);
            this.cbxInterprete.Name = "cbxInterprete";
            this.cbxInterprete.Size = new System.Drawing.Size(225, 21);
            this.cbxInterprete.TabIndex = 5;
            this.cbxInterprete.SelectedIndexChanged += new System.EventHandler(this.cbxInterprete_SelectedIndexChanged);
            // 
            // cbxApelido
            // 
            this.cbxApelido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxApelido.FormattingEnabled = true;
            this.cbxApelido.Location = new System.Drawing.Point(12, 25);
            this.cbxApelido.Name = "cbxApelido";
            this.cbxApelido.Size = new System.Drawing.Size(225, 21);
            this.cbxApelido.TabIndex = 1;
            this.cbxApelido.SelectedIndexChanged += new System.EventHandler(this.cbxApelido_SelectedIndexChanged);
            // 
            // radioMusica
            // 
            this.radioMusica.AutoSize = true;
            this.radioMusica.Location = new System.Drawing.Point(72, 52);
            this.radioMusica.Name = "radioMusica";
            this.radioMusica.Size = new System.Drawing.Size(59, 17);
            this.radioMusica.TabIndex = 4;
            this.radioMusica.TabStop = true;
            this.radioMusica.Text = "Música";
            this.radioMusica.UseVisualStyleBackColor = true;
            this.radioMusica.CheckedChanged += new System.EventHandler(this.radioMusica_CheckedChanged);
            // 
            // radioAlbum
            // 
            this.radioAlbum.AutoSize = true;
            this.radioAlbum.Location = new System.Drawing.Point(12, 52);
            this.radioAlbum.Name = "radioAlbum";
            this.radioAlbum.Size = new System.Drawing.Size(54, 17);
            this.radioAlbum.TabIndex = 3;
            this.radioAlbum.TabStop = true;
            this.radioAlbum.Text = "Álbum";
            this.radioAlbum.UseVisualStyleBackColor = true;
            this.radioAlbum.CheckedChanged += new System.EventHandler(this.radioAlbum_CheckedChanged);
            // 
            // lbMusica
            // 
            this.lbMusica.AutoSize = true;
            this.lbMusica.Location = new System.Drawing.Point(9, 112);
            this.lbMusica.Name = "lbMusica";
            this.lbMusica.Size = new System.Drawing.Size(86, 13);
            this.lbMusica.TabIndex = 41;
            this.lbMusica.Text = "Nome da música";
            // 
            // lbTipoMidia
            // 
            this.lbTipoMidia.AutoSize = true;
            this.lbTipoMidia.Location = new System.Drawing.Point(240, 112);
            this.lbTipoMidia.Name = "lbTipoMidia";
            this.lbTipoMidia.Size = new System.Drawing.Size(72, 13);
            this.lbTipoMidia.TabIndex = 39;
            this.lbTipoMidia.Text = "Tipo de mídia";
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.Location = new System.Drawing.Point(250, 72);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(81, 13);
            this.lbAlbum.TabIndex = 35;
            this.lbAlbum.Text = "Nome do álbum";
            // 
            // cbxMidia
            // 
            this.cbxMidia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMidia.Enabled = false;
            this.cbxMidia.FormattingEnabled = true;
            this.cbxMidia.Location = new System.Drawing.Point(243, 127);
            this.cbxMidia.Name = "cbxMidia";
            this.cbxMidia.Size = new System.Drawing.Size(140, 21);
            this.cbxMidia.TabIndex = 8;
            // 
            // cbxAlbum
            // 
            this.cbxAlbum.AutoCompleteCustomSource.AddRange(new string[] {
            " "});
            this.cbxAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlbum.Enabled = false;
            this.cbxAlbum.FormattingEnabled = true;
            this.cbxAlbum.Location = new System.Drawing.Point(243, 88);
            this.cbxAlbum.Name = "cbxAlbum";
            this.cbxAlbum.Size = new System.Drawing.Size(237, 21);
            this.cbxAlbum.TabIndex = 6;
            this.cbxAlbum.SelectedIndexChanged += new System.EventHandler(this.cbxAlbum_SelectedIndexChanged);
            // 
            // cbxMusica
            // 
            this.cbxMusica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMusica.Enabled = false;
            this.cbxMusica.FormattingEnabled = true;
            this.cbxMusica.Location = new System.Drawing.Point(12, 128);
            this.cbxMusica.Name = "cbxMusica";
            this.cbxMusica.Size = new System.Drawing.Size(225, 21);
            this.cbxMusica.TabIndex = 7;
            this.cbxMusica.SelectedIndexChanged += new System.EventHandler(this.cbxMusica_SelectedIndexChanged);
            // 
            // lbDataEmprestimo
            // 
            this.lbDataEmprestimo.AutoSize = true;
            this.lbDataEmprestimo.Location = new System.Drawing.Point(391, 113);
            this.lbDataEmprestimo.Name = "lbDataEmprestimo";
            this.lbDataEmprestimo.Size = new System.Drawing.Size(89, 13);
            this.lbDataEmprestimo.TabIndex = 48;
            this.lbDataEmprestimo.Text = "Data empréstimo:";
            // 
            // DtEmprestimo
            // 
            this.DtEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtEmprestimo.Location = new System.Drawing.Point(389, 129);
            this.DtEmprestimo.Name = "DtEmprestimo";
            this.DtEmprestimo.Size = new System.Drawing.Size(91, 20);
            this.DtEmprestimo.TabIndex = 47;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(240, 9);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 49;
            this.lbEndereco.Text = "Endereço";
            // 
            // cbxEndereco
            // 
            this.cbxEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEndereco.FormattingEnabled = true;
            this.cbxEndereco.Location = new System.Drawing.Point(243, 25);
            this.cbxEndereco.Name = "cbxEndereco";
            this.cbxEndereco.Size = new System.Drawing.Size(237, 21);
            this.cbxEndereco.TabIndex = 2;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Enabled = false;
            this.btAdicionar.Location = new System.Drawing.Point(405, 155);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 10;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListViewEmprestimos
            // 
            this.ListViewEmprestimos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVInterprete,
            this.LVAlbum,
            this.LVMusica,
            this.LVMidia,
            this.LVDTEmpres});
            this.ListViewEmprestimos.FullRowSelect = true;
            listViewGroup1.Header = "Musica";
            listViewGroup1.Name = "Músicas";
            listViewGroup2.Header = "Album";
            listViewGroup2.Name = "Álbum";
            this.ListViewEmprestimos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.ListViewEmprestimos.Location = new System.Drawing.Point(12, 184);
            this.ListViewEmprestimos.Name = "ListViewEmprestimos";
            this.ListViewEmprestimos.Size = new System.Drawing.Size(468, 173);
            this.ListViewEmprestimos.TabIndex = 52;
            this.ListViewEmprestimos.UseCompatibleStateImageBehavior = false;
            this.ListViewEmprestimos.View = System.Windows.Forms.View.Details;
            // 
            // LVInterprete
            // 
            this.LVInterprete.Text = "Intéprete";
            this.LVInterprete.Width = 84;
            // 
            // LVAlbum
            // 
            this.LVAlbum.Text = "Álbum";
            this.LVAlbum.Width = 82;
            // 
            // LVMusica
            // 
            this.LVMusica.Text = "Música";
            this.LVMusica.Width = 85;
            // 
            // LVMidia
            // 
            this.LVMidia.Text = "Mídia";
            this.LVMidia.Width = 83;
            // 
            // LVDTEmpres
            // 
            this.LVDTEmpres.Text = "Data Empréstimo";
            this.LVDTEmpres.Width = 64;
            // 
            // lbApelido
            // 
            this.lbApelido.AutoSize = true;
            this.lbApelido.Location = new System.Drawing.Point(12, 9);
            this.lbApelido.Name = "lbApelido";
            this.lbApelido.Size = new System.Drawing.Size(42, 13);
            this.lbApelido.TabIndex = 54;
            this.lbApelido.Text = "Apelido";
            // 
            // btEmprestar
            // 
            this.btEmprestar.Enabled = false;
            this.btEmprestar.Location = new System.Drawing.Point(405, 363);
            this.btEmprestar.Name = "btEmprestar";
            this.btEmprestar.Size = new System.Drawing.Size(75, 23);
            this.btEmprestar.TabIndex = 12;
            this.btEmprestar.Text = "Emprestar";
            this.btEmprestar.UseVisualStyleBackColor = true;
            this.btEmprestar.Click += new System.EventHandler(this.btEmprestar_Click);
            // 
            // errorProviderEmprestimo
            // 
            this.errorProviderEmprestimo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEmprestimo.ContainerControl = this;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(324, 362);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 11;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // tbxIdEmprestimo
            // 
            this.tbxIdEmprestimo.Location = new System.Drawing.Point(12, 366);
            this.tbxIdEmprestimo.Name = "tbxIdEmprestimo";
            this.tbxIdEmprestimo.Size = new System.Drawing.Size(0, 20);
            this.tbxIdEmprestimo.TabIndex = 57;
            this.tbxIdEmprestimo.Text = "1";
            this.tbxIdEmprestimo.Visible = false;
            // 
            // radioButtonSelecao
            // 
            this.radioButtonSelecao.AutoSize = true;
            this.radioButtonSelecao.Location = new System.Drawing.Point(137, 52);
            this.radioButtonSelecao.Name = "radioButtonSelecao";
            this.radioButtonSelecao.Size = new System.Drawing.Size(14, 13);
            this.radioButtonSelecao.TabIndex = 58;
            this.radioButtonSelecao.TabStop = true;
            this.radioButtonSelecao.UseVisualStyleBackColor = true;
            // 
            // FormEmprestarMidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(502, 411);
            this.Controls.Add(this.radioButtonSelecao);
            this.Controls.Add(this.tbxIdEmprestimo);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btEmprestar);
            this.Controls.Add(this.lbApelido);
            this.Controls.Add(this.ListViewEmprestimos);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.cbxEndereco);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbDataEmprestimo);
            this.Controls.Add(this.DtEmprestimo);
            this.Controls.Add(this.cbxMusica);
            this.Controls.Add(this.cbxAlbum);
            this.Controls.Add(this.radioMusica);
            this.Controls.Add(this.radioAlbum);
            this.Controls.Add(this.lbMusica);
            this.Controls.Add(this.lbTipoMidia);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.cbxMidia);
            this.Controls.Add(this.cbxInterprete);
            this.Controls.Add(this.cbxApelido);
            this.Controls.Add(this.lbInterprete);
            this.Controls.Add(this.lblApelido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(508, 435);
            this.MinimumSize = new System.Drawing.Size(508, 435);
            this.Name = "FormEmprestarMidia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormEmprestarMidia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lbInterprete;
        private System.Windows.Forms.ComboBox cbxInterprete;
        private System.Windows.Forms.ComboBox cbxApelido;
        private System.Windows.Forms.RadioButton radioMusica;
        private System.Windows.Forms.RadioButton radioAlbum;
        private System.Windows.Forms.Label lbMusica;
        private System.Windows.Forms.Label lbTipoMidia;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.ComboBox cbxMidia;
        private System.Windows.Forms.ComboBox cbxAlbum;
        private System.Windows.Forms.ComboBox cbxMusica;
        private System.Windows.Forms.Label lbDataEmprestimo;
        private System.Windows.Forms.DateTimePicker DtEmprestimo;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.ComboBox cbxEndereco;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.ListView ListViewEmprestimos;
        private System.Windows.Forms.Label lbApelido;
        private System.Windows.Forms.ColumnHeader LVInterprete;
        private System.Windows.Forms.ColumnHeader LVAlbum;
        private System.Windows.Forms.ColumnHeader LVMusica;
        private System.Windows.Forms.ColumnHeader LVMidia;
        private System.Windows.Forms.ColumnHeader LVDTEmpres;
        private System.Windows.Forms.Button btEmprestar;
        private System.Windows.Forms.ErrorProvider errorProviderEmprestimo;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.TextBox tbxIdEmprestimo;
        private System.Windows.Forms.RadioButton radioButtonSelecao;
    }
}