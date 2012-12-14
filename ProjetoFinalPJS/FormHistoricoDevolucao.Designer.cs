namespace ProjetoFinalPJS
{
    partial class FormHistoricoDevolucao
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
            this.dGVHistoricoDevolucao = new System.Windows.Forms.DataGridView();
            this.lbHistorico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHistoricoDevolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVHistoricoDevolucao
            // 
            this.dGVHistoricoDevolucao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVHistoricoDevolucao.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGVHistoricoDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHistoricoDevolucao.Location = new System.Drawing.Point(12, 25);
            this.dGVHistoricoDevolucao.Name = "dGVHistoricoDevolucao";
            this.dGVHistoricoDevolucao.Size = new System.Drawing.Size(728, 312);
            this.dGVHistoricoDevolucao.TabIndex = 0;
            // 
            // lbHistorico
            // 
            this.lbHistorico.AutoSize = true;
            this.lbHistorico.Location = new System.Drawing.Point(12, 9);
            this.lbHistorico.Name = "lbHistorico";
            this.lbHistorico.Size = new System.Drawing.Size(121, 13);
            this.lbHistorico.TabIndex = 1;
            this.lbHistorico.Text = "Histórico de devoluções";
            // 
            // FormHistoricoDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 349);
            this.Controls.Add(this.lbHistorico);
            this.Controls.Add(this.dGVHistoricoDevolucao);
            this.Name = "FormHistoricoDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHistoricoDevolucao";
            this.Load += new System.EventHandler(this.FormHistoricoDevolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVHistoricoDevolucao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVHistoricoDevolucao;
        private System.Windows.Forms.Label lbHistorico;
    }
}