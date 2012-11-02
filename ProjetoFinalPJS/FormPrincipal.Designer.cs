namespace ProjetoFinalPJS
{
    partial class FormPrincipal
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Vinil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("K7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("CD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("DVD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Digital", System.Windows.Forms.HorizontalAlignment.Left);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Cadastrar = new System.Windows.Forms.TabPage();
            this.Movimentacao = new System.Windows.Forms.TabPage();
            this.buttonAddMidia = new System.Windows.Forms.Button();
            this.buttonAddAmigo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.interprete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.origemCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.midia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.obsevacoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Cadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cadastrar);
            this.tabControl1.Controls.Add(this.Movimentacao);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 64);
            this.tabControl1.TabIndex = 0;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Controls.Add(this.buttonAddAmigo);
            this.Cadastrar.Controls.Add(this.buttonAddMidia);
            this.Cadastrar.Location = new System.Drawing.Point(4, 22);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastrar.Size = new System.Drawing.Size(859, 38);
            this.Cadastrar.TabIndex = 0;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            // 
            // Movimentacao
            // 
            this.Movimentacao.Location = new System.Drawing.Point(4, 22);
            this.Movimentacao.Name = "Movimentacao";
            this.Movimentacao.Padding = new System.Windows.Forms.Padding(3);
            this.Movimentacao.Size = new System.Drawing.Size(859, 38);
            this.Movimentacao.TabIndex = 1;
            this.Movimentacao.Text = "Movimentaçao";
            this.Movimentacao.UseVisualStyleBackColor = true;
            // 
            // buttonAddMidia
            // 
            this.buttonAddMidia.Location = new System.Drawing.Point(6, 9);
            this.buttonAddMidia.Name = "buttonAddMidia";
            this.buttonAddMidia.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMidia.TabIndex = 0;
            this.buttonAddMidia.Text = "Midia";
            this.buttonAddMidia.UseVisualStyleBackColor = true;
            // 
            // buttonAddAmigo
            // 
            this.buttonAddAmigo.Location = new System.Drawing.Point(87, 9);
            this.buttonAddAmigo.Name = "buttonAddAmigo";
            this.buttonAddAmigo.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAmigo.TabIndex = 1;
            this.buttonAddAmigo.Text = "Amigo";
            this.buttonAddAmigo.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numero,
            this.interprete,
            this.autor,
            this.album,
            this.dataCompra,
            this.origemCompra,
            this.midia,
            this.obsevacoes,
            this.nota});
            listViewGroup1.Header = "Vinil";
            listViewGroup1.Name = "Vinil";
            listViewGroup2.Header = "K7";
            listViewGroup2.Name = "K7";
            listViewGroup3.Header = "CD";
            listViewGroup3.Name = "CD";
            listViewGroup4.Header = "DVD";
            listViewGroup4.Name = "DVD";
            listViewGroup5.Header = "Digital";
            listViewGroup5.Name = "Digital";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.listView1.Location = new System.Drawing.Point(12, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(867, 253);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Numero
            // 
            this.Numero.Text = "Número";
            // 
            // interprete
            // 
            this.interprete.Text = "Intérprete";
            // 
            // autor
            // 
            this.autor.Text = "Autor";
            // 
            // album
            // 
            this.album.Text = "Álbum";
            // 
            // dataCompra
            // 
            this.dataCompra.Text = "Data da Compra";
            // 
            // origemCompra
            // 
            this.origemCompra.Text = "Origem da Compra";
            // 
            // midia
            // 
            this.midia.Text = "Tipo de Mídia";
            // 
            // obsevacoes
            // 
            this.obsevacoes.Text = "Observações";
            // 
            // nota
            // 
            this.nota.Text = "Nota";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(723, 389);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(804, 389);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 3;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 424);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPrincipal";
            this.Text = "Controle de acervo musical";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.Cadastrar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Cadastrar;
        private System.Windows.Forms.TabPage Movimentacao;
        private System.Windows.Forms.Button buttonAddAmigo;
        private System.Windows.Forms.Button buttonAddMidia;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Numero;
        private System.Windows.Forms.ColumnHeader interprete;
        private System.Windows.Forms.ColumnHeader autor;
        private System.Windows.Forms.ColumnHeader album;
        private System.Windows.Forms.ColumnHeader dataCompra;
        private System.Windows.Forms.ColumnHeader origemCompra;
        private System.Windows.Forms.ColumnHeader midia;
        private System.Windows.Forms.ColumnHeader obsevacoes;
        private System.Windows.Forms.ColumnHeader nota;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonRemover;

    }
}