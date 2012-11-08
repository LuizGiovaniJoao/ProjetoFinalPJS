namespace ProjetoFinalPJS
{
    partial class FormListaAmigos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaAmigos));
            this.dGridViewListaNomes = new System.Windows.Forms.DataGridView();
            this.gbxPesquisaNome = new System.Windows.Forms.GroupBox();
            this.pbxLupa = new System.Windows.Forms.PictureBox();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.lbPesquisaNome = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewListaNomes)).BeginInit();
            this.gbxPesquisaNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridViewListaNomes
            // 
            this.dGridViewListaNomes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dGridViewListaNomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewListaNomes.Location = new System.Drawing.Point(12, 81);
            this.dGridViewListaNomes.Name = "dGridViewListaNomes";
            this.dGridViewListaNomes.Size = new System.Drawing.Size(705, 309);
            this.dGridViewListaNomes.TabIndex = 0;
            // 
            // gbxPesquisaNome
            // 
            this.gbxPesquisaNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPesquisaNome.Controls.Add(this.pbxLupa);
            this.gbxPesquisaNome.Controls.Add(this.txtPesquisaNome);
            this.gbxPesquisaNome.Controls.Add(this.lbPesquisaNome);
            this.gbxPesquisaNome.Location = new System.Drawing.Point(12, 12);
            this.gbxPesquisaNome.Name = "gbxPesquisaNome";
            this.gbxPesquisaNome.Size = new System.Drawing.Size(705, 63);
            this.gbxPesquisaNome.TabIndex = 1;
            this.gbxPesquisaNome.TabStop = false;
            // 
            // pbxLupa
            // 
            this.pbxLupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLupa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbxLupa.Image = ((System.Drawing.Image)(resources.GetObject("pbxLupa.Image")));
            this.pbxLupa.Location = new System.Drawing.Point(678, 29);
            this.pbxLupa.Name = "pbxLupa";
            this.pbxLupa.Size = new System.Drawing.Size(18, 18);
            this.pbxLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLupa.TabIndex = 2;
            this.pbxLupa.TabStop = false;
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisaNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPesquisaNome.Location = new System.Drawing.Point(9, 28);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(690, 20);
            this.txtPesquisaNome.TabIndex = 1;
            // 
            // lbPesquisaNome
            // 
            this.lbPesquisaNome.AutoSize = true;
            this.lbPesquisaNome.Location = new System.Drawing.Point(6, 12);
            this.lbPesquisaNome.Name = "lbPesquisaNome";
            this.lbPesquisaNome.Size = new System.Drawing.Size(35, 13);
            this.lbPesquisaNome.TabIndex = 0;
            this.lbPesquisaNome.Text = "Nome";
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlterar.Location = new System.Drawing.Point(480, 405);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btRemover
            // 
            this.btRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemover.Image = ((System.Drawing.Image)(resources.GetObject("btRemover.Image")));
            this.btRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRemover.Location = new System.Drawing.Point(561, 405);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 4;
            this.btRemover.Text = "Remover";
            this.btRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRemover.UseVisualStyleBackColor = true;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionar.Image")));
            this.btAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdicionar.Location = new System.Drawing.Point(642, 405);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 5;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // FormListaAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 440);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.gbxPesquisaNome);
            this.Controls.Add(this.dGridViewListaNomes);
            this.Name = "FormListaAmigos";
            this.Text = "Lista de Amigos";
            this.Load += new System.EventHandler(this.FormListaAmigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewListaNomes)).EndInit();
            this.gbxPesquisaNome.ResumeLayout(false);
            this.gbxPesquisaNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLupa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridViewListaNomes;
        private System.Windows.Forms.GroupBox gbxPesquisaNome;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label lbPesquisaNome;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.PictureBox pbxLupa;
    }
}