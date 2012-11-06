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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_nota = new System.Windows.Forms.CheckBox();
            this.comboBox_Nota = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_midia = new System.Windows.Forms.ComboBox();
            this.dateTime_dataCompra = new System.Windows.Forms.DateTimePicker();
            this.checkBox_midia = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTime_dataAlbum = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_dataCompra = new System.Windows.Forms.CheckBox();
            this.textBox_origemCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Album = new System.Windows.Forms.TextBox();
            this.checkBox_dataAlbum = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_Autor = new System.Windows.Forms.TextBox();
            this.checkBox_origemCompra = new System.Windows.Forms.CheckBox();
            this.textBoxInterprete = new System.Windows.Forms.TextBox();
            this.checkBox_album = new System.Windows.Forms.CheckBox();
            this.checkBoxInterprete = new System.Windows.Forms.CheckBox();
            this.checkBox_Autor = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mídiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(12, 245);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(867, 296);
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
            this.buttonAlterar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterar.Image")));
            this.buttonAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterar.Location = new System.Drawing.Point(723, 547);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemover.Image")));
            this.buttonRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemover.Location = new System.Drawing.Point(804, 547);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 3;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkBox_nota);
            this.groupBox1.Controls.Add(this.comboBox_Nota);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox_midia);
            this.groupBox1.Controls.Add(this.dateTime_dataCompra);
            this.groupBox1.Controls.Add(this.checkBox_midia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTime_dataAlbum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkBox_dataCompra);
            this.groupBox1.Controls.Add(this.textBox_origemCompra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Album);
            this.groupBox1.Controls.Add(this.checkBox_dataAlbum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox_Autor);
            this.groupBox1.Controls.Add(this.checkBox_origemCompra);
            this.groupBox1.Controls.Add(this.textBoxInterprete);
            this.groupBox1.Controls.Add(this.checkBox_album);
            this.groupBox1.Controls.Add(this.checkBoxInterprete);
            this.groupBox1.Controls.Add(this.checkBox_Autor);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(300, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nota";
            // 
            // checkBox_nota
            // 
            this.checkBox_nota.AutoSize = true;
            this.checkBox_nota.Location = new System.Drawing.Point(504, 130);
            this.checkBox_nota.Name = "checkBox_nota";
            this.checkBox_nota.Size = new System.Drawing.Size(15, 14);
            this.checkBox_nota.TabIndex = 21;
            this.checkBox_nota.UseVisualStyleBackColor = true;
            this.checkBox_nota.CheckedChanged += new System.EventHandler(this.checkBox_nota_CheckedChanged);
            // 
            // comboBox_Nota
            // 
            this.comboBox_Nota.Enabled = false;
            this.comboBox_Nota.FormattingEnabled = true;
            this.comboBox_Nota.Items.AddRange(new object[] {
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
            this.comboBox_Nota.Location = new System.Drawing.Point(525, 125);
            this.comboBox_Nota.Name = "comboBox_Nota";
            this.comboBox_Nota.Size = new System.Drawing.Size(48, 24);
            this.comboBox_Nota.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mídia";
            // 
            // comboBox_midia
            // 
            this.comboBox_midia.Enabled = false;
            this.comboBox_midia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_midia.FormattingEnabled = true;
            this.comboBox_midia.Items.AddRange(new object[] {
            "CD",
            "Digital",
            "DVD",
            "K7",
            "Vinil"});
            this.comboBox_midia.Location = new System.Drawing.Point(439, 125);
            this.comboBox_midia.Name = "comboBox_midia";
            this.comboBox_midia.Size = new System.Drawing.Size(59, 24);
            this.comboBox_midia.TabIndex = 6;
            // 
            // dateTime_dataCompra
            // 
            this.dateTime_dataCompra.Enabled = false;
            this.dateTime_dataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_dataCompra.Location = new System.Drawing.Point(439, 81);
            this.dateTime_dataCompra.Name = "dateTime_dataCompra";
            this.dateTime_dataCompra.Size = new System.Drawing.Size(134, 22);
            this.dateTime_dataCompra.TabIndex = 19;
            // 
            // checkBox_midia
            // 
            this.checkBox_midia.AutoSize = true;
            this.checkBox_midia.Location = new System.Drawing.Point(418, 130);
            this.checkBox_midia.Name = "checkBox_midia";
            this.checkBox_midia.Size = new System.Drawing.Size(15, 14);
            this.checkBox_midia.TabIndex = 11;
            this.checkBox_midia.UseVisualStyleBackColor = true;
            this.checkBox_midia.CheckedChanged += new System.EventHandler(this.checkBox_midia_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Data da compra";
            // 
            // dateTime_dataAlbum
            // 
            this.dateTime_dataAlbum.Enabled = false;
            this.dateTime_dataAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_dataAlbum.Location = new System.Drawing.Point(439, 39);
            this.dateTime_dataAlbum.Name = "dateTime_dataAlbum";
            this.dateTime_dataAlbum.Size = new System.Drawing.Size(134, 22);
            this.dateTime_dataAlbum.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data do álbum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Origem da compra";
            // 
            // checkBox_dataCompra
            // 
            this.checkBox_dataCompra.AutoSize = true;
            this.checkBox_dataCompra.Location = new System.Drawing.Point(418, 86);
            this.checkBox_dataCompra.Name = "checkBox_dataCompra";
            this.checkBox_dataCompra.Size = new System.Drawing.Size(15, 14);
            this.checkBox_dataCompra.TabIndex = 10;
            this.checkBox_dataCompra.UseVisualStyleBackColor = true;
            this.checkBox_dataCompra.CheckedChanged += new System.EventHandler(this.checkBox_dataCompra_CheckedChanged);
            // 
            // textBox_origemCompra
            // 
            this.textBox_origemCompra.Enabled = false;
            this.textBox_origemCompra.Location = new System.Drawing.Point(39, 169);
            this.textBox_origemCompra.Name = "textBox_origemCompra";
            this.textBox_origemCompra.Size = new System.Drawing.Size(360, 22);
            this.textBox_origemCompra.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome do álbum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome do autor";
            // 
            // textBox_Album
            // 
            this.textBox_Album.Enabled = false;
            this.textBox_Album.Location = new System.Drawing.Point(39, 125);
            this.textBox_Album.Name = "textBox_Album";
            this.textBox_Album.Size = new System.Drawing.Size(360, 22);
            this.textBox_Album.TabIndex = 14;
            // 
            // checkBox_dataAlbum
            // 
            this.checkBox_dataAlbum.AutoSize = true;
            this.checkBox_dataAlbum.Location = new System.Drawing.Point(418, 42);
            this.checkBox_dataAlbum.Name = "checkBox_dataAlbum";
            this.checkBox_dataAlbum.Size = new System.Drawing.Size(15, 14);
            this.checkBox_dataAlbum.TabIndex = 8;
            this.checkBox_dataAlbum.UseVisualStyleBackColor = true;
            this.checkBox_dataAlbum.CheckedChanged += new System.EventHandler(this.checkBox_dataAlbum_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome do intérprete";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(417, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(498, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox_Autor
            // 
            this.textBox_Autor.Enabled = false;
            this.textBox_Autor.Location = new System.Drawing.Point(39, 81);
            this.textBox_Autor.Name = "textBox_Autor";
            this.textBox_Autor.Size = new System.Drawing.Size(360, 22);
            this.textBox_Autor.TabIndex = 12;
            // 
            // checkBox_origemCompra
            // 
            this.checkBox_origemCompra.AutoSize = true;
            this.checkBox_origemCompra.Location = new System.Drawing.Point(18, 169);
            this.checkBox_origemCompra.Name = "checkBox_origemCompra";
            this.checkBox_origemCompra.Size = new System.Drawing.Size(15, 14);
            this.checkBox_origemCompra.TabIndex = 0;
            this.checkBox_origemCompra.UseVisualStyleBackColor = true;
            this.checkBox_origemCompra.CheckedChanged += new System.EventHandler(this.checkBox_origemCompra_CheckedChanged);
            // 
            // textBoxInterprete
            // 
            this.textBoxInterprete.Enabled = false;
            this.textBoxInterprete.Location = new System.Drawing.Point(39, 37);
            this.textBoxInterprete.Name = "textBoxInterprete";
            this.textBoxInterprete.Size = new System.Drawing.Size(360, 22);
            this.textBoxInterprete.TabIndex = 1;
            // 
            // checkBox_album
            // 
            this.checkBox_album.AutoSize = true;
            this.checkBox_album.Location = new System.Drawing.Point(18, 130);
            this.checkBox_album.Name = "checkBox_album";
            this.checkBox_album.Size = new System.Drawing.Size(15, 14);
            this.checkBox_album.TabIndex = 9;
            this.checkBox_album.UseVisualStyleBackColor = true;
            this.checkBox_album.CheckedChanged += new System.EventHandler(this.checkBox_album_CheckedChanged);
            // 
            // checkBoxInterprete
            // 
            this.checkBoxInterprete.AutoSize = true;
            this.checkBoxInterprete.Location = new System.Drawing.Point(18, 42);
            this.checkBoxInterprete.Name = "checkBoxInterprete";
            this.checkBoxInterprete.Size = new System.Drawing.Size(15, 14);
            this.checkBoxInterprete.TabIndex = 0;
            this.checkBoxInterprete.UseVisualStyleBackColor = true;
            this.checkBoxInterprete.CheckedChanged += new System.EventHandler(this.checkBoxInterprete_CheckedChanged);
            // 
            // checkBox_Autor
            // 
            this.checkBox_Autor.AutoSize = true;
            this.checkBox_Autor.Location = new System.Drawing.Point(18, 86);
            this.checkBox_Autor.Name = "checkBox_Autor";
            this.checkBox_Autor.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Autor.TabIndex = 7;
            this.checkBox_Autor.UseVisualStyleBackColor = true;
            this.checkBox_Autor.CheckedChanged += new System.EventHandler(this.checkBox_Autor_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 198);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(144, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 77);
            this.button6.TabIndex = 3;
            this.button6.Text = "Devolver mídia";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(6, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 77);
            this.button5.TabIndex = 2;
            this.button5.Text = "Empretar mídia\r\n";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(144, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 80);
            this.button4.TabIndex = 1;
            this.button4.Text = "Amigos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(6, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 80);
            this.button3.TabIndex = 0;
            this.button3.Text = "Inserir mídia";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mídiaToolStripMenuItem,
            this.amigoToolStripMenuItem});
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.inserirToolStripMenuItem.Text = "Inserir";
            // 
            // mídiaToolStripMenuItem
            // 
            this.mídiaToolStripMenuItem.Name = "mídiaToolStripMenuItem";
            this.mídiaToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.mídiaToolStripMenuItem.Text = "Mídia";
            // 
            // amigoToolStripMenuItem
            // 
            this.amigoToolStripMenuItem.Name = "amigoToolStripMenuItem";
            this.amigoToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.amigoToolStripMenuItem.Text = "Amigo";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emprestarToolStripMenuItem,
            this.devolverToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // emprestarToolStripMenuItem
            // 
            this.emprestarToolStripMenuItem.Name = "emprestarToolStripMenuItem";
            this.emprestarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.emprestarToolStripMenuItem.Text = "Emprestar";
            // 
            // devolverToolStripMenuItem
            // 
            this.devolverToolStripMenuItem.Name = "devolverToolStripMenuItem";
            this.devolverToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.devolverToolStripMenuItem.Text = "Devolver";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(894, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de acervo musical";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_origemCompra;
        private System.Windows.Forms.DateTimePicker dateTime_dataCompra;
        private System.Windows.Forms.CheckBox checkBox_midia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTime_dataAlbum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_dataCompra;
        private System.Windows.Forms.TextBox textBox_origemCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Album;
        private System.Windows.Forms.CheckBox checkBox_dataAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_Autor;
        private System.Windows.Forms.TextBox textBoxInterprete;
        private System.Windows.Forms.CheckBox checkBox_album;
        private System.Windows.Forms.CheckBox checkBoxInterprete;
        private System.Windows.Forms.CheckBox checkBox_Autor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_nota;
        private System.Windows.Forms.ComboBox comboBox_Nota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_midia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mídiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverToolStripMenuItem;

    }
}