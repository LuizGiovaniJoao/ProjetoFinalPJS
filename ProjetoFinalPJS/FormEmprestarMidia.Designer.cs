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
            this.tbxApelido = new System.Windows.Forms.TextBox();
            this.tbxNomeInterprete = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxApelido
            // 
            this.tbxApelido.Location = new System.Drawing.Point(12, 25);
            this.tbxApelido.Name = "tbxApelido";
            this.tbxApelido.Size = new System.Drawing.Size(219, 20);
            this.tbxApelido.TabIndex = 0;
            // 
            // tbxNomeInterprete
            // 
            this.tbxNomeInterprete.Location = new System.Drawing.Point(237, 25);
            this.tbxNomeInterprete.Name = "tbxNomeInterprete";
            this.tbxNomeInterprete.Size = new System.Drawing.Size(290, 20);
            this.tbxNomeInterprete.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do intérprete:";
            // 
            // FormEmprestarMidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.tbxNomeInterprete);
            this.Controls.Add(this.tbxApelido);
            this.Name = "FormEmprestarMidia";
            this.Text = "Emprestar Midia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxApelido;
        private System.Windows.Forms.TextBox tbxNomeInterprete;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label label1;
    }
}