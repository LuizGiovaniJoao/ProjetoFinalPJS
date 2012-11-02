namespace ProjetoFinalPJS
{
    partial class FormCadastrarMidia
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
            this.textBoxInterprete = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxOrigemCompra = new System.Windows.Forms.TextBox();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.textBoxObsevacoes = new System.Windows.Forms.TextBox();
            this.dateTimePickerAlbum = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCompra = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMidia = new System.Windows.Forms.ComboBox();
            this.comboBoxNota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInterprete
            // 
            this.textBoxInterprete.Location = new System.Drawing.Point(15, 25);
            this.textBoxInterprete.Name = "textBoxInterprete";
            this.textBoxInterprete.Size = new System.Drawing.Size(539, 20);
            this.textBoxInterprete.TabIndex = 0;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(15, 64);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(536, 20);
            this.textBoxAutor.TabIndex = 1;
            // 
            // textBoxOrigemCompra
            // 
            this.textBoxOrigemCompra.Location = new System.Drawing.Point(18, 181);
            this.textBoxOrigemCompra.Name = "textBoxOrigemCompra";
            this.textBoxOrigemCompra.Size = new System.Drawing.Size(536, 20);
            this.textBoxOrigemCompra.TabIndex = 2;
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(18, 103);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(536, 20);
            this.textBoxAlbum.TabIndex = 3;
            // 
            // textBoxObsevacoes
            // 
            this.textBoxObsevacoes.Location = new System.Drawing.Point(18, 260);
            this.textBoxObsevacoes.Multiline = true;
            this.textBoxObsevacoes.Name = "textBoxObsevacoes";
            this.textBoxObsevacoes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxObsevacoes.Size = new System.Drawing.Size(536, 40);
            this.textBoxObsevacoes.TabIndex = 4;
            // 
            // dateTimePickerAlbum
            // 
            this.dateTimePickerAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAlbum.Location = new System.Drawing.Point(18, 142);
            this.dateTimePickerAlbum.Name = "dateTimePickerAlbum";
            this.dateTimePickerAlbum.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerAlbum.TabIndex = 5;
            // 
            // dateTimePickerCompra
            // 
            this.dateTimePickerCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCompra.Location = new System.Drawing.Point(155, 142);
            this.dateTimePickerCompra.Name = "dateTimePickerCompra";
            this.dateTimePickerCompra.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerCompra.TabIndex = 6;
            // 
            // comboBoxMidia
            // 
            this.comboBoxMidia.FormattingEnabled = true;
            this.comboBoxMidia.Items.AddRange(new object[] {
            "Vinil",
            "K7",
            "CD",
            "DVD",
            "Digital"});
            this.comboBoxMidia.Location = new System.Drawing.Point(18, 220);
            this.comboBoxMidia.Name = "comboBoxMidia";
            this.comboBoxMidia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMidia.TabIndex = 7;
            // 
            // comboBoxNota
            // 
            this.comboBoxNota.FormattingEnabled = true;
            this.comboBoxNota.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.comboBoxNota.Location = new System.Drawing.Point(155, 220);
            this.comboBoxNota.Name = "comboBoxNota";
            this.comboBoxNota.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNota.TabIndex = 8;
            this.comboBoxNota.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome do intérprete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome do Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome do álbum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data do álbum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data da Compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Origem da compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo de mídia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Observações\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nota";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(316, 315);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 18;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(478, 315);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 19;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(397, 315);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 20;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            // 
            // FormCadastrarMidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 353);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNota);
            this.Controls.Add(this.comboBoxMidia);
            this.Controls.Add(this.dateTimePickerCompra);
            this.Controls.Add(this.dateTimePickerAlbum);
            this.Controls.Add(this.textBoxObsevacoes);
            this.Controls.Add(this.textBoxAlbum);
            this.Controls.Add(this.textBoxOrigemCompra);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxInterprete);
            this.Name = "FormCadastrarMidia";
            this.Text = "Cadastrar Mídia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInterprete;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxOrigemCompra;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.TextBox textBoxObsevacoes;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlbum;
        private System.Windows.Forms.DateTimePicker dateTimePickerCompra;
        private System.Windows.Forms.ComboBox comboBoxMidia;
        private System.Windows.Forms.ComboBox comboBoxNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonGravar;
    }
}