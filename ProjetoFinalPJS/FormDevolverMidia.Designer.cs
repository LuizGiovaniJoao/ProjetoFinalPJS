namespace ProjetoFinalPJS
{
    partial class FormDevolverMidia
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
            this.lbApelido = new System.Windows.Forms.Label();
            this.cbxApelido = new System.Windows.Forms.ComboBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.listViewDevMidia = new System.Windows.Forms.ListView();
            this.LVInterprete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVMusica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVNidia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVDataEmprestimo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dtDevolucao = new System.Windows.Forms.DateTimePicker();
            this.cbxEndereco = new System.Windows.Forms.ComboBox();
            this.btDevolver = new System.Windows.Forms.Button();
            this.btDevolveTudo = new System.Windows.Forms.Button();
            this.cbxIdEmprestimo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbApelido
            // 
            this.lbApelido.AutoSize = true;
            this.lbApelido.Location = new System.Drawing.Point(12, 9);
            this.lbApelido.Name = "lbApelido";
            this.lbApelido.Size = new System.Drawing.Size(45, 13);
            this.lbApelido.TabIndex = 0;
            this.lbApelido.Text = "Apelido:";
            // 
            // cbxApelido
            // 
            this.cbxApelido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxApelido.FormattingEnabled = true;
            this.cbxApelido.Location = new System.Drawing.Point(12, 25);
            this.cbxApelido.Name = "cbxApelido";
            this.cbxApelido.Size = new System.Drawing.Size(136, 21);
            this.cbxApelido.TabIndex = 1;
            this.cbxApelido.SelectedIndexChanged += new System.EventHandler(this.cbxApelido_SelectedIndexChanged);
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(151, 9);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(56, 13);
            this.lbEndereco.TabIndex = 2;
            this.lbEndereco.Text = "Endereço:";
            // 
            // listViewDevMidia
            // 
            this.listViewDevMidia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDevMidia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVInterprete,
            this.LVAlbum,
            this.LVMusica,
            this.LVNidia,
            this.LVDataEmprestimo});
            this.listViewDevMidia.FullRowSelect = true;
            this.listViewDevMidia.Location = new System.Drawing.Point(12, 52);
            this.listViewDevMidia.Name = "listViewDevMidia";
            this.listViewDevMidia.Size = new System.Drawing.Size(693, 269);
            this.listViewDevMidia.TabIndex = 7;
            this.listViewDevMidia.UseCompatibleStateImageBehavior = false;
            this.listViewDevMidia.View = System.Windows.Forms.View.Details;
            // 
            // LVInterprete
            // 
            this.LVInterprete.Text = "Intérprete";
            this.LVInterprete.Width = 153;
            // 
            // LVAlbum
            // 
            this.LVAlbum.Text = "Álbum";
            this.LVAlbum.Width = 162;
            // 
            // LVMusica
            // 
            this.LVMusica.Text = "Música";
            this.LVMusica.Width = 107;
            // 
            // LVNidia
            // 
            this.LVNidia.Text = "Mídia";
            this.LVNidia.Width = 115;
            // 
            // LVDataEmprestimo
            // 
            this.LVDataEmprestimo.Text = "Data do empréstimo";
            this.LVDataEmprestimo.Width = 158;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data de Devolução:";
            this.label1.Visible = false;
            // 
            // dtDevolucao
            // 
            this.dtDevolucao.Enabled = false;
            this.dtDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDevolucao.Location = new System.Drawing.Point(296, 26);
            this.dtDevolucao.Name = "dtDevolucao";
            this.dtDevolucao.Size = new System.Drawing.Size(101, 20);
            this.dtDevolucao.TabIndex = 11;
            // 
            // cbxEndereco
            // 
            this.cbxEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEndereco.FormattingEnabled = true;
            this.cbxEndereco.Location = new System.Drawing.Point(154, 25);
            this.cbxEndereco.Name = "cbxEndereco";
            this.cbxEndereco.Size = new System.Drawing.Size(136, 21);
            this.cbxEndereco.TabIndex = 13;
            // 
            // btDevolver
            // 
            this.btDevolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDevolver.Location = new System.Drawing.Point(527, 327);
            this.btDevolver.Name = "btDevolver";
            this.btDevolver.Size = new System.Drawing.Size(86, 23);
            this.btDevolver.TabIndex = 16;
            this.btDevolver.Text = "Devolver";
            this.btDevolver.UseVisualStyleBackColor = true;
            this.btDevolver.Click += new System.EventHandler(this.btDevolver_Click);
            // 
            // btDevolveTudo
            // 
            this.btDevolveTudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDevolveTudo.Location = new System.Drawing.Point(619, 327);
            this.btDevolveTudo.Name = "btDevolveTudo";
            this.btDevolveTudo.Size = new System.Drawing.Size(86, 23);
            this.btDevolveTudo.TabIndex = 17;
            this.btDevolveTudo.Text = "Devolver tudo";
            this.btDevolveTudo.UseVisualStyleBackColor = true;
            this.btDevolveTudo.Click += new System.EventHandler(this.btDevolveTudo_Click);
            // 
            // cbxIdEmprestimo
            // 
            this.cbxIdEmprestimo.FormattingEnabled = true;
            this.cbxIdEmprestimo.Location = new System.Drawing.Point(403, 25);
            this.cbxIdEmprestimo.Name = "cbxIdEmprestimo";
            this.cbxIdEmprestimo.Size = new System.Drawing.Size(0, 21);
            this.cbxIdEmprestimo.TabIndex = 15;
            this.cbxIdEmprestimo.Visible = false;
            // 
            // FormDevolverMidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 356);
            this.Controls.Add(this.btDevolver);
            this.Controls.Add(this.btDevolveTudo);
            this.Controls.Add(this.cbxIdEmprestimo);
            this.Controls.Add(this.cbxEndereco);
            this.Controls.Add(this.dtDevolucao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDevMidia);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.cbxApelido);
            this.Controls.Add(this.lbApelido);
            this.MinimumSize = new System.Drawing.Size(733, 394);
            this.Name = "FormDevolverMidia";
            this.Text = "Devolver Midia";
            this.Load += new System.EventHandler(this.FormDevolverMidia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbApelido;
        private System.Windows.Forms.ComboBox cbxApelido;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.ListView listViewDevMidia;
        private System.Windows.Forms.ColumnHeader LVInterprete;
        private System.Windows.Forms.ColumnHeader LVAlbum;
        private System.Windows.Forms.ColumnHeader LVMusica;
        private System.Windows.Forms.ColumnHeader LVDataEmprestimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDevolucao;
        private System.Windows.Forms.ComboBox cbxEndereco;
        private System.Windows.Forms.Button btDevolver;
        private System.Windows.Forms.Button btDevolveTudo;
        private System.Windows.Forms.ColumnHeader LVNidia;
        private System.Windows.Forms.ComboBox cbxIdEmprestimo;
    }
}