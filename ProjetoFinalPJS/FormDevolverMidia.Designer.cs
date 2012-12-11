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
            this.cbxApelido.Size = new System.Drawing.Size(121, 21);
            this.cbxApelido.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(136, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(261, 9);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(56, 13);
            this.lbEndereco.TabIndex = 4;
            this.lbEndereco.Text = "Endereço:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(369, 191);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormDevolverMidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 357);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.cbxApelido);
            this.Controls.Add(this.lbApelido);
            this.Name = "FormDevolverMidia";
            this.Text = "Devolver Midia";
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
    }
}