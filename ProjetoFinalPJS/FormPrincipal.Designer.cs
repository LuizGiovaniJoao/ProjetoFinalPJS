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
            this.listViewMidia = new System.Windows.Forms.ListView();
            this.Musica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Interprete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.origemCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.obsevacoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.midia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.situacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAlterar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.gpbxFiltro = new System.Windows.Forms.GroupBox();
            this.lbNota = new System.Windows.Forms.Label();
            this.checkBox_nota = new System.Windows.Forms.CheckBox();
            this.cbxNota = new System.Windows.Forms.ComboBox();
            this.lbMidia = new System.Windows.Forms.Label();
            this.cbxMidia = new System.Windows.Forms.ComboBox();
            this.dateTimeDataCompra = new System.Windows.Forms.DateTimePicker();
            this.checkBox_midia = new System.Windows.Forms.CheckBox();
            this.lbDtCompra = new System.Windows.Forms.Label();
            this.dateTimeDataAlbum = new System.Windows.Forms.DateTimePicker();
            this.lbDtAlbum = new System.Windows.Forms.Label();
            this.lbOrigemCompra = new System.Windows.Forms.Label();
            this.checkBox_dataCompra = new System.Windows.Forms.CheckBox();
            this.tbxOrigemCompra = new System.Windows.Forms.TextBox();
            this.lbNomeAlbum = new System.Windows.Forms.Label();
            this.lbNomeAutor = new System.Windows.Forms.Label();
            this.tbxAlbum = new System.Windows.Forms.TextBox();
            this.checkBox_dataAlbum = new System.Windows.Forms.CheckBox();
            this.lbInterprete = new System.Windows.Forms.Label();
            this.btTodos = new System.Windows.Forms.Button();
            this.btFiltral = new System.Windows.Forms.Button();
            this.tbxAutor = new System.Windows.Forms.TextBox();
            this.checkBox_origemCompra = new System.Windows.Forms.CheckBox();
            this.tbxInterprete = new System.Windows.Forms.TextBox();
            this.checkBox_album = new System.Windows.Forms.CheckBox();
            this.checkBoxInterprete = new System.Windows.Forms.CheckBox();
            this.checkBox_Autor = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btDevolverMidia = new System.Windows.Forms.Button();
            this.btEmprestarMidia = new System.Windows.Forms.Button();
            this.btCadAmigo = new System.Windows.Forms.Button();
            this.btCadMidia = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mídiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbxFiltro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMidia
            // 
            this.listViewMidia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMidia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Musica,
            this.album,
            this.Autor,
            this.Interprete,
            this.dataAlbum,
            this.dataCompra,
            this.origemCompra,
            this.obsevacoes,
            this.midia,
            this.nota,
            this.situacao});
            this.listViewMidia.FullRowSelect = true;
            this.listViewMidia.GridLines = true;
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
            this.listViewMidia.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.listViewMidia.Location = new System.Drawing.Point(12, 245);
            this.listViewMidia.Name = "listViewMidia";
            this.listViewMidia.ShowGroups = false;
            this.listViewMidia.Size = new System.Drawing.Size(867, 296);
            this.listViewMidia.TabIndex = 1;
            this.listViewMidia.UseCompatibleStateImageBehavior = false;
            this.listViewMidia.View = System.Windows.Forms.View.Details;
            // 
            // Musica
            // 
            this.Musica.Text = "Música";
            this.Musica.Width = 80;
            // 
            // album
            // 
            this.album.Text = "Álbum";
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.Width = 75;
            // 
            // Interprete
            // 
            this.Interprete.Text = "Intérprete";
            this.Interprete.Width = 85;
            // 
            // dataAlbum
            // 
            this.dataAlbum.Text = "Data do Álbum";
            this.dataAlbum.Width = 90;
            // 
            // dataCompra
            // 
            this.dataCompra.Text = "Data da Compra";
            this.dataCompra.Width = 93;
            // 
            // origemCompra
            // 
            this.origemCompra.Text = "Origem da Compra";
            this.origemCompra.Width = 107;
            // 
            // obsevacoes
            // 
            this.obsevacoes.Text = "Observações";
            this.obsevacoes.Width = 80;
            // 
            // midia
            // 
            this.midia.Text = "Tipo de Mídia";
            this.midia.Width = 87;
            // 
            // nota
            // 
            this.nota.Text = "Nota";
            // 
            // situacao
            // 
            this.situacao.Text = "Situação";
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlterar.Location = new System.Drawing.Point(723, 547);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemover.Image = ((System.Drawing.Image)(resources.GetObject("btRemover.Image")));
            this.btRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRemover.Location = new System.Drawing.Point(804, 547);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 3;
            this.btRemover.Text = "Remover";
            this.btRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRemover.UseVisualStyleBackColor = true;
            // 
            // gpbxFiltro
            // 
            this.gpbxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbxFiltro.BackColor = System.Drawing.SystemColors.Control;
            this.gpbxFiltro.Controls.Add(this.lbNota);
            this.gpbxFiltro.Controls.Add(this.checkBox_nota);
            this.gpbxFiltro.Controls.Add(this.cbxNota);
            this.gpbxFiltro.Controls.Add(this.lbMidia);
            this.gpbxFiltro.Controls.Add(this.cbxMidia);
            this.gpbxFiltro.Controls.Add(this.dateTimeDataCompra);
            this.gpbxFiltro.Controls.Add(this.checkBox_midia);
            this.gpbxFiltro.Controls.Add(this.lbDtCompra);
            this.gpbxFiltro.Controls.Add(this.dateTimeDataAlbum);
            this.gpbxFiltro.Controls.Add(this.lbDtAlbum);
            this.gpbxFiltro.Controls.Add(this.lbOrigemCompra);
            this.gpbxFiltro.Controls.Add(this.checkBox_dataCompra);
            this.gpbxFiltro.Controls.Add(this.tbxOrigemCompra);
            this.gpbxFiltro.Controls.Add(this.lbNomeAlbum);
            this.gpbxFiltro.Controls.Add(this.lbNomeAutor);
            this.gpbxFiltro.Controls.Add(this.tbxAlbum);
            this.gpbxFiltro.Controls.Add(this.checkBox_dataAlbum);
            this.gpbxFiltro.Controls.Add(this.lbInterprete);
            this.gpbxFiltro.Controls.Add(this.btTodos);
            this.gpbxFiltro.Controls.Add(this.btFiltral);
            this.gpbxFiltro.Controls.Add(this.tbxAutor);
            this.gpbxFiltro.Controls.Add(this.checkBox_origemCompra);
            this.gpbxFiltro.Controls.Add(this.tbxInterprete);
            this.gpbxFiltro.Controls.Add(this.checkBox_album);
            this.gpbxFiltro.Controls.Add(this.checkBoxInterprete);
            this.gpbxFiltro.Controls.Add(this.checkBox_Autor);
            this.gpbxFiltro.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxFiltro.Location = new System.Drawing.Point(300, 27);
            this.gpbxFiltro.Name = "gpbxFiltro";
            this.gpbxFiltro.Size = new System.Drawing.Size(579, 198);
            this.gpbxFiltro.TabIndex = 4;
            this.gpbxFiltro.TabStop = false;
            this.gpbxFiltro.Text = "Filtro";
            // 
            // lbNota
            // 
            this.lbNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNota.AutoSize = true;
            this.lbNota.Location = new System.Drawing.Point(522, 106);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(30, 16);
            this.lbNota.TabIndex = 22;
            this.lbNota.Text = "Nota";
            // 
            // checkBox_nota
            // 
            this.checkBox_nota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_nota.AutoSize = true;
            this.checkBox_nota.Location = new System.Drawing.Point(504, 130);
            this.checkBox_nota.Name = "checkBox_nota";
            this.checkBox_nota.Size = new System.Drawing.Size(15, 14);
            this.checkBox_nota.TabIndex = 21;
            this.checkBox_nota.UseVisualStyleBackColor = true;
            this.checkBox_nota.CheckedChanged += new System.EventHandler(this.checkBox_nota_CheckedChanged);
            // 
            // cbxNota
            // 
            this.cbxNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxNota.Enabled = false;
            this.cbxNota.FormattingEnabled = true;
            this.cbxNota.Items.AddRange(new object[] {
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
            this.cbxNota.Location = new System.Drawing.Point(525, 125);
            this.cbxNota.Name = "cbxNota";
            this.cbxNota.Size = new System.Drawing.Size(48, 24);
            this.cbxNota.TabIndex = 20;
            // 
            // lbMidia
            // 
            this.lbMidia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMidia.AutoSize = true;
            this.lbMidia.Location = new System.Drawing.Point(436, 106);
            this.lbMidia.Name = "lbMidia";
            this.lbMidia.Size = new System.Drawing.Size(33, 16);
            this.lbMidia.TabIndex = 5;
            this.lbMidia.Text = "Mídia";
            // 
            // cbxMidia
            // 
            this.cbxMidia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMidia.Enabled = false;
            this.cbxMidia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxMidia.FormattingEnabled = true;
            this.cbxMidia.Items.AddRange(new object[] {
            "CD",
            "Digital",
            "DVD",
            "K7",
            "Vinil"});
            this.cbxMidia.Location = new System.Drawing.Point(439, 125);
            this.cbxMidia.Name = "cbxMidia";
            this.cbxMidia.Size = new System.Drawing.Size(59, 24);
            this.cbxMidia.TabIndex = 6;
            // 
            // dateTimeDataCompra
            // 
            this.dateTimeDataCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDataCompra.Enabled = false;
            this.dateTimeDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataCompra.Location = new System.Drawing.Point(439, 81);
            this.dateTimeDataCompra.Name = "dateTimeDataCompra";
            this.dateTimeDataCompra.Size = new System.Drawing.Size(134, 22);
            this.dateTimeDataCompra.TabIndex = 19;
            this.dateTimeDataCompra.Value = new System.DateTime(2012, 12, 1, 0, 0, 0, 0);
            // 
            // checkBox_midia
            // 
            this.checkBox_midia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_midia.AutoSize = true;
            this.checkBox_midia.Location = new System.Drawing.Point(418, 130);
            this.checkBox_midia.Name = "checkBox_midia";
            this.checkBox_midia.Size = new System.Drawing.Size(15, 14);
            this.checkBox_midia.TabIndex = 11;
            this.checkBox_midia.UseVisualStyleBackColor = true;
            this.checkBox_midia.CheckedChanged += new System.EventHandler(this.checkBox_midia_CheckedChanged);
            // 
            // lbDtCompra
            // 
            this.lbDtCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDtCompra.AutoSize = true;
            this.lbDtCompra.Location = new System.Drawing.Point(436, 62);
            this.lbDtCompra.Name = "lbDtCompra";
            this.lbDtCompra.Size = new System.Drawing.Size(83, 16);
            this.lbDtCompra.TabIndex = 16;
            this.lbDtCompra.Text = "Data da compra";
            // 
            // dateTimeDataAlbum
            // 
            this.dateTimeDataAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDataAlbum.Enabled = false;
            this.dateTimeDataAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataAlbum.Location = new System.Drawing.Point(439, 39);
            this.dateTimeDataAlbum.Name = "dateTimeDataAlbum";
            this.dateTimeDataAlbum.Size = new System.Drawing.Size(134, 22);
            this.dateTimeDataAlbum.TabIndex = 18;
            this.dateTimeDataAlbum.Value = new System.DateTime(2012, 12, 1, 0, 0, 0, 0);
            // 
            // lbDtAlbum
            // 
            this.lbDtAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDtAlbum.AutoSize = true;
            this.lbDtAlbum.Location = new System.Drawing.Point(436, 20);
            this.lbDtAlbum.Name = "lbDtAlbum";
            this.lbDtAlbum.Size = new System.Drawing.Size(76, 16);
            this.lbDtAlbum.TabIndex = 17;
            this.lbDtAlbum.Text = "Data do álbum";
            // 
            // lbOrigemCompra
            // 
            this.lbOrigemCompra.AutoSize = true;
            this.lbOrigemCompra.Location = new System.Drawing.Point(39, 150);
            this.lbOrigemCompra.Name = "lbOrigemCompra";
            this.lbOrigemCompra.Size = new System.Drawing.Size(95, 16);
            this.lbOrigemCompra.TabIndex = 17;
            this.lbOrigemCompra.Text = "Origem da compra";
            // 
            // checkBox_dataCompra
            // 
            this.checkBox_dataCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_dataCompra.AutoSize = true;
            this.checkBox_dataCompra.Location = new System.Drawing.Point(418, 86);
            this.checkBox_dataCompra.Name = "checkBox_dataCompra";
            this.checkBox_dataCompra.Size = new System.Drawing.Size(15, 14);
            this.checkBox_dataCompra.TabIndex = 10;
            this.checkBox_dataCompra.UseVisualStyleBackColor = true;
            this.checkBox_dataCompra.CheckedChanged += new System.EventHandler(this.checkBox_dataCompra_CheckedChanged);
            // 
            // tbxOrigemCompra
            // 
            this.tbxOrigemCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOrigemCompra.Enabled = false;
            this.tbxOrigemCompra.Location = new System.Drawing.Point(39, 169);
            this.tbxOrigemCompra.Name = "tbxOrigemCompra";
            this.tbxOrigemCompra.Size = new System.Drawing.Size(360, 22);
            this.tbxOrigemCompra.TabIndex = 15;
            // 
            // lbNomeAlbum
            // 
            this.lbNomeAlbum.AutoSize = true;
            this.lbNomeAlbum.Location = new System.Drawing.Point(39, 106);
            this.lbNomeAlbum.Name = "lbNomeAlbum";
            this.lbNomeAlbum.Size = new System.Drawing.Size(82, 16);
            this.lbNomeAlbum.TabIndex = 14;
            this.lbNomeAlbum.Text = "Nome do álbum";
            // 
            // lbNomeAutor
            // 
            this.lbNomeAutor.AutoSize = true;
            this.lbNomeAutor.Location = new System.Drawing.Point(39, 62);
            this.lbNomeAutor.Name = "lbNomeAutor";
            this.lbNomeAutor.Size = new System.Drawing.Size(78, 16);
            this.lbNomeAutor.TabIndex = 13;
            this.lbNomeAutor.Text = "Nome do autor";
            // 
            // tbxAlbum
            // 
            this.tbxAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAlbum.Enabled = false;
            this.tbxAlbum.Location = new System.Drawing.Point(39, 125);
            this.tbxAlbum.Name = "tbxAlbum";
            this.tbxAlbum.Size = new System.Drawing.Size(360, 22);
            this.tbxAlbum.TabIndex = 14;
            // 
            // checkBox_dataAlbum
            // 
            this.checkBox_dataAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_dataAlbum.AutoSize = true;
            this.checkBox_dataAlbum.Location = new System.Drawing.Point(418, 42);
            this.checkBox_dataAlbum.Name = "checkBox_dataAlbum";
            this.checkBox_dataAlbum.Size = new System.Drawing.Size(15, 14);
            this.checkBox_dataAlbum.TabIndex = 8;
            this.checkBox_dataAlbum.UseVisualStyleBackColor = true;
            this.checkBox_dataAlbum.CheckedChanged += new System.EventHandler(this.checkBox_dataAlbum_CheckedChanged);
            // 
            // lbInterprete
            // 
            this.lbInterprete.AutoSize = true;
            this.lbInterprete.Location = new System.Drawing.Point(39, 18);
            this.lbInterprete.Name = "lbInterprete";
            this.lbInterprete.Size = new System.Drawing.Size(98, 16);
            this.lbInterprete.TabIndex = 12;
            this.lbInterprete.Text = "Nome do intérprete";
            // 
            // btTodos
            // 
            this.btTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTodos.Image = ((System.Drawing.Image)(resources.GetObject("btTodos.Image")));
            this.btTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTodos.Location = new System.Drawing.Point(417, 169);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(75, 23);
            this.btTodos.TabIndex = 5;
            this.btTodos.Text = "Todos";
            this.btTodos.UseVisualStyleBackColor = true;
            this.btTodos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btFiltral
            // 
            this.btFiltral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFiltral.Image = ((System.Drawing.Image)(resources.GetObject("btFiltral.Image")));
            this.btFiltral.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFiltral.Location = new System.Drawing.Point(498, 169);
            this.btFiltral.Name = "btFiltral";
            this.btFiltral.Size = new System.Drawing.Size(75, 23);
            this.btFiltral.TabIndex = 6;
            this.btFiltral.Text = "Filtrar";
            this.btFiltral.UseVisualStyleBackColor = true;
            this.btFiltral.Click += new System.EventHandler(this.btFiltral_Click);
            // 
            // tbxAutor
            // 
            this.tbxAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAutor.Enabled = false;
            this.tbxAutor.Location = new System.Drawing.Point(39, 81);
            this.tbxAutor.Name = "tbxAutor";
            this.tbxAutor.Size = new System.Drawing.Size(360, 22);
            this.tbxAutor.TabIndex = 12;
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
            // tbxInterprete
            // 
            this.tbxInterprete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxInterprete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxInterprete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxInterprete.Enabled = false;
            this.tbxInterprete.Location = new System.Drawing.Point(39, 37);
            this.tbxInterprete.Name = "tbxInterprete";
            this.tbxInterprete.Size = new System.Drawing.Size(360, 22);
            this.tbxInterprete.TabIndex = 1;
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
            this.groupBox2.Controls.Add(this.btDevolverMidia);
            this.groupBox2.Controls.Add(this.btEmprestarMidia);
            this.groupBox2.Controls.Add(this.btCadAmigo);
            this.groupBox2.Controls.Add(this.btCadMidia);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 198);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // btDevolverMidia
            // 
            this.btDevolverMidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btDevolverMidia.Image = ((System.Drawing.Image)(resources.GetObject("btDevolverMidia.Image")));
            this.btDevolverMidia.Location = new System.Drawing.Point(144, 106);
            this.btDevolverMidia.Name = "btDevolverMidia";
            this.btDevolverMidia.Size = new System.Drawing.Size(132, 77);
            this.btDevolverMidia.TabIndex = 3;
            this.btDevolverMidia.Text = "Devolver mídia";
            this.btDevolverMidia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDevolverMidia.UseVisualStyleBackColor = true;
            this.btDevolverMidia.Click += new System.EventHandler(this.button6_Click);
            // 
            // btEmprestarMidia
            // 
            this.btEmprestarMidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btEmprestarMidia.Image = ((System.Drawing.Image)(resources.GetObject("btEmprestarMidia.Image")));
            this.btEmprestarMidia.Location = new System.Drawing.Point(6, 106);
            this.btEmprestarMidia.Name = "btEmprestarMidia";
            this.btEmprestarMidia.Size = new System.Drawing.Size(132, 77);
            this.btEmprestarMidia.TabIndex = 2;
            this.btEmprestarMidia.Text = "Emprestar mídia\r\n";
            this.btEmprestarMidia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEmprestarMidia.UseVisualStyleBackColor = true;
            this.btEmprestarMidia.Click += new System.EventHandler(this.button5_Click);
            // 
            // btCadAmigo
            // 
            this.btCadAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btCadAmigo.Image = ((System.Drawing.Image)(resources.GetObject("btCadAmigo.Image")));
            this.btCadAmigo.Location = new System.Drawing.Point(144, 20);
            this.btCadAmigo.Name = "btCadAmigo";
            this.btCadAmigo.Size = new System.Drawing.Size(132, 80);
            this.btCadAmigo.TabIndex = 1;
            this.btCadAmigo.Text = "Amigos";
            this.btCadAmigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadAmigo.UseVisualStyleBackColor = true;
            this.btCadAmigo.Click += new System.EventHandler(this.button4_Click);
            // 
            // btCadMidia
            // 
            this.btCadMidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadMidia.ForeColor = System.Drawing.Color.Black;
            this.btCadMidia.Image = ((System.Drawing.Image)(resources.GetObject("btCadMidia.Image")));
            this.btCadMidia.Location = new System.Drawing.Point(6, 20);
            this.btCadMidia.Name = "btCadMidia";
            this.btCadMidia.Size = new System.Drawing.Size(132, 80);
            this.btCadMidia.TabIndex = 0;
            this.btCadMidia.Text = "Inserir mídia";
            this.btCadMidia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadMidia.UseVisualStyleBackColor = true;
            this.btCadMidia.Click += new System.EventHandler(this.button3_Click);
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
            this.Controls.Add(this.gpbxFiltro);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.listViewMidia);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de acervo musical";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.gpbxFiltro.ResumeLayout(false);
            this.gpbxFiltro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMidia;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.GroupBox gpbxFiltro;
        private System.Windows.Forms.CheckBox checkBox_origemCompra;
        private System.Windows.Forms.DateTimePicker dateTimeDataCompra;
        private System.Windows.Forms.CheckBox checkBox_midia;
        private System.Windows.Forms.Label lbDtCompra;
        private System.Windows.Forms.DateTimePicker dateTimeDataAlbum;
        private System.Windows.Forms.Label lbDtAlbum;
        private System.Windows.Forms.Label lbOrigemCompra;
        private System.Windows.Forms.CheckBox checkBox_dataCompra;
        private System.Windows.Forms.TextBox tbxOrigemCompra;
        private System.Windows.Forms.Label lbNomeAlbum;
        private System.Windows.Forms.Label lbNomeAutor;
        private System.Windows.Forms.TextBox tbxAlbum;
        private System.Windows.Forms.CheckBox checkBox_dataAlbum;
        private System.Windows.Forms.Label lbInterprete;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btFiltral;
        private System.Windows.Forms.TextBox tbxAutor;
        private System.Windows.Forms.TextBox tbxInterprete;
        private System.Windows.Forms.CheckBox checkBox_album;
        private System.Windows.Forms.CheckBox checkBoxInterprete;
        private System.Windows.Forms.CheckBox checkBox_Autor;
        private System.Windows.Forms.Label lbNota;
        private System.Windows.Forms.CheckBox checkBox_nota;
        private System.Windows.Forms.ComboBox cbxNota;
        private System.Windows.Forms.Label lbMidia;
        private System.Windows.Forms.ComboBox cbxMidia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDevolverMidia;
        private System.Windows.Forms.Button btEmprestarMidia;
        private System.Windows.Forms.Button btCadAmigo;
        private System.Windows.Forms.Button btCadMidia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mídiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Interprete;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader album;
        private System.Windows.Forms.ColumnHeader dataCompra;
        private System.Windows.Forms.ColumnHeader origemCompra;
        private System.Windows.Forms.ColumnHeader midia;
        private System.Windows.Forms.ColumnHeader obsevacoes;
        private System.Windows.Forms.ColumnHeader nota;
        private System.Windows.Forms.ColumnHeader Musica;
        private System.Windows.Forms.ColumnHeader situacao;
        private System.Windows.Forms.ColumnHeader dataAlbum;

    }
}