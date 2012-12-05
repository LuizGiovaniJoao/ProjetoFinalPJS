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
            this.lblApelido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxInterprete = new System.Windows.Forms.ComboBox();
            this.cbxApelido = new System.Windows.Forms.ComboBox();
            this.radioMusica = new System.Windows.Forms.RadioButton();
            this.radioAlbum = new System.Windows.Forms.RadioButton();
            this.lbMusica = new System.Windows.Forms.Label();
            this.lbTipoMidia = new System.Windows.Forms.Label();
            this.lbDataDevolucao = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.cbxMidia = new System.Windows.Forms.ComboBox();
            this.DtDevolucao = new System.Windows.Forms.DateTimePicker();
            this.cbxAlbum = new System.Windows.Forms.ComboBox();
            this.cbxMusica = new System.Windows.Forms.ComboBox();
            this.lbDataEmprestimo = new System.Windows.Forms.Label();
            this.DtEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.cbxEndereco = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(12, 9);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(91, 13);
            this.lblApelido.TabIndex = 2;
            this.lblApelido.Text = "Apelido do amigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do intérprete:";
            // 
            // cbxInterprete
            // 
            this.cbxInterprete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInterprete.Enabled = false;
            this.cbxInterprete.FormattingEnabled = true;
            this.cbxInterprete.Location = new System.Drawing.Point(12, 88);
            this.cbxInterprete.Name = "cbxInterprete";
            this.cbxInterprete.Size = new System.Drawing.Size(199, 21);
            this.cbxInterprete.TabIndex = 5;
            // 
            // cbxApelido
            // 
            this.cbxApelido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxApelido.FormattingEnabled = true;
            this.cbxApelido.Location = new System.Drawing.Point(12, 25);
            this.cbxApelido.Name = "cbxApelido";
            this.cbxApelido.Size = new System.Drawing.Size(199, 21);
            this.cbxApelido.TabIndex = 4;
            // 
            // radioMusica
            // 
            this.radioMusica.AutoSize = true;
            this.radioMusica.Location = new System.Drawing.Point(72, 52);
            this.radioMusica.Name = "radioMusica";
            this.radioMusica.Size = new System.Drawing.Size(59, 17);
            this.radioMusica.TabIndex = 44;
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
            this.radioAlbum.TabIndex = 43;
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
            this.lbTipoMidia.Location = new System.Drawing.Point(214, 112);
            this.lbTipoMidia.Name = "lbTipoMidia";
            this.lbTipoMidia.Size = new System.Drawing.Size(72, 13);
            this.lbTipoMidia.TabIndex = 39;
            this.lbTipoMidia.Text = "Tipo de mídia";
            // 
            // lbDataDevolucao
            // 
            this.lbDataDevolucao.AutoSize = true;
            this.lbDataDevolucao.Location = new System.Drawing.Point(387, 112);
            this.lbDataDevolucao.Name = "lbDataDevolucao";
            this.lbDataDevolucao.Size = new System.Drawing.Size(86, 13);
            this.lbDataDevolucao.TabIndex = 37;
            this.lbDataDevolucao.Text = "Data devolução:";
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.Location = new System.Drawing.Point(214, 72);
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
            this.cbxMidia.Items.AddRange(new object[] {
            "Vinil",
            "K7",
            "CD",
            "DVD",
            "Digital"});
            this.cbxMidia.Location = new System.Drawing.Point(217, 128);
            this.cbxMidia.Name = "cbxMidia";
            this.cbxMidia.Size = new System.Drawing.Size(67, 21);
            this.cbxMidia.TabIndex = 31;
            // 
            // DtDevolucao
            // 
            this.DtDevolucao.Enabled = false;
            this.DtDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDevolucao.Location = new System.Drawing.Point(390, 129);
            this.DtDevolucao.Name = "DtDevolucao";
            this.DtDevolucao.Size = new System.Drawing.Size(91, 20);
            this.DtDevolucao.TabIndex = 29;
            // 
            // cbxAlbum
            // 
            this.cbxAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlbum.Enabled = false;
            this.cbxAlbum.FormattingEnabled = true;
            this.cbxAlbum.Location = new System.Drawing.Point(217, 88);
            this.cbxAlbum.Name = "cbxAlbum";
            this.cbxAlbum.Size = new System.Drawing.Size(264, 21);
            this.cbxAlbum.TabIndex = 45;
            // 
            // cbxMusica
            // 
            this.cbxMusica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMusica.Enabled = false;
            this.cbxMusica.FormattingEnabled = true;
            this.cbxMusica.Location = new System.Drawing.Point(12, 128);
            this.cbxMusica.Name = "cbxMusica";
            this.cbxMusica.Size = new System.Drawing.Size(199, 21);
            this.cbxMusica.TabIndex = 46;
            // 
            // lbDataEmprestimo
            // 
            this.lbDataEmprestimo.AutoSize = true;
            this.lbDataEmprestimo.Location = new System.Drawing.Point(292, 112);
            this.lbDataEmprestimo.Name = "lbDataEmprestimo";
            this.lbDataEmprestimo.Size = new System.Drawing.Size(89, 13);
            this.lbDataEmprestimo.TabIndex = 48;
            this.lbDataEmprestimo.Text = "Data empréstimo:";
            // 
            // DtEmprestimo
            // 
            this.DtEmprestimo.Enabled = false;
            this.DtEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtEmprestimo.Location = new System.Drawing.Point(290, 129);
            this.DtEmprestimo.Name = "DtEmprestimo";
            this.DtEmprestimo.Size = new System.Drawing.Size(91, 20);
            this.DtEmprestimo.TabIndex = 47;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(214, 9);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 49;
            this.lbEndereco.Text = "Endereço";
            // 
            // cbxEndereco
            // 
            this.cbxEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEndereco.FormattingEnabled = true;
            this.cbxEndereco.Location = new System.Drawing.Point(217, 25);
            this.cbxEndereco.Name = "cbxEndereco";
            this.cbxEndereco.Size = new System.Drawing.Size(264, 21);
            this.cbxEndereco.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 184);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(469, 173);
            this.listView1.TabIndex = 52;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormEmprestarMidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 399);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.lbDataDevolucao);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.cbxMidia);
            this.Controls.Add(this.DtDevolucao);
            this.Controls.Add(this.cbxInterprete);
            this.Controls.Add(this.cbxApelido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApelido);
            this.Name = "FormEmprestarMidia";
            this.Text = "Emprestar Midia";
            this.Load += new System.EventHandler(this.FormEmprestarMidia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxInterprete;
        private System.Windows.Forms.ComboBox cbxApelido;
        private System.Windows.Forms.RadioButton radioMusica;
        private System.Windows.Forms.RadioButton radioAlbum;
        private System.Windows.Forms.Label lbMusica;
        private System.Windows.Forms.Label lbTipoMidia;
        private System.Windows.Forms.Label lbDataDevolucao;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.ComboBox cbxMidia;
        private System.Windows.Forms.DateTimePicker DtDevolucao;
        private System.Windows.Forms.ComboBox cbxAlbum;
        private System.Windows.Forms.ComboBox cbxMusica;
        private System.Windows.Forms.Label lbDataEmprestimo;
        private System.Windows.Forms.DateTimePicker DtEmprestimo;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.ComboBox cbxEndereco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}