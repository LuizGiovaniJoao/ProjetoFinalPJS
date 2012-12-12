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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.LVInterprete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVMusica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVMidia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVDataEmprestimo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVDataDevolucao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbEmprestimo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.cbxApelido.FormattingEnabled = true;
            this.cbxApelido.Location = new System.Drawing.Point(12, 25);
            this.cbxApelido.Name = "cbxApelido";
            this.cbxApelido.Size = new System.Drawing.Size(136, 21);
            this.cbxApelido.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(151, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(293, 9);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(56, 13);
            this.lbEndereco.TabIndex = 4;
            this.lbEndereco.Text = "Endereço:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVInterprete,
            this.LVAlbum,
            this.LVMusica,
            this.LVMidia,
            this.LVDataEmprestimo,
            this.LVDataDevolucao});
            this.listView1.Location = new System.Drawing.Point(12, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(746, 194);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // LVInterprete
            // 
            this.LVInterprete.Text = "Intérprete";
            this.LVInterprete.Width = 111;
            // 
            // LVAlbum
            // 
            this.LVAlbum.Text = "Álbum";
            this.LVAlbum.Width = 127;
            // 
            // LVMusica
            // 
            this.LVMusica.Text = "Música";
            this.LVMusica.Width = 102;
            // 
            // LVMidia
            // 
            this.LVMidia.Text = "Tipo mídia";
            this.LVMidia.Width = 96;
            // 
            // LVDataEmprestimo
            // 
            this.LVDataEmprestimo.Text = "Data do empréstimo";
            this.LVDataEmprestimo.Width = 116;
            // 
            // LVDataDevolucao
            // 
            this.LVDataDevolucao.Text = "Data de devolução";
            this.LVDataDevolucao.Width = 122;
            // 
            // lbEmprestimo
            // 
            this.lbEmprestimo.AutoSize = true;
            this.lbEmprestimo.Location = new System.Drawing.Point(435, 9);
            this.lbEmprestimo.Name = "lbEmprestimo";
            this.lbEmprestimo.Size = new System.Drawing.Size(104, 13);
            this.lbEmprestimo.TabIndex = 8;
            this.lbEmprestimo.Text = "Data de empréstimo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data de Devolução";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(545, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(438, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(101, 20);
            this.textBox3.TabIndex = 12;
            // 
            // FormDevolverMidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 267);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEmprestimo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.cbxApelido);
            this.Controls.Add(this.lbApelido);
            this.Name = "FormDevolverMidia";
            this.Text = "Devolver Midia";
            this.Load += new System.EventHandler(this.FormDevolverMidia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbApelido;
        private System.Windows.Forms.ComboBox cbxApelido;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader LVInterprete;
        private System.Windows.Forms.ColumnHeader LVAlbum;
        private System.Windows.Forms.ColumnHeader LVMusica;
        private System.Windows.Forms.ColumnHeader LVMidia;
        private System.Windows.Forms.Label lbEmprestimo;
        private System.Windows.Forms.ColumnHeader LVDataEmprestimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ColumnHeader LVDataDevolucao;
        private System.Windows.Forms.TextBox textBox3;
    }
}