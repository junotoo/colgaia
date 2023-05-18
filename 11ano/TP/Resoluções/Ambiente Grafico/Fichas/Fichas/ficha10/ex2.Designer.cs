namespace Fichas.ficha10
{
    partial class ex2
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
            this.lstCidade = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtCidades = new System.Windows.Forms.TextBox();
            this.btnAcrescenta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnInicia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCidade
            // 
            this.lstCidade.FormattingEnabled = true;
            this.lstCidade.Location = new System.Drawing.Point(12, 12);
            this.lstCidade.Name = "lstCidade";
            this.lstCidade.Size = new System.Drawing.Size(163, 134);
            this.lstCidade.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(211, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtCidades
            // 
            this.txtCidades.Location = new System.Drawing.Point(12, 170);
            this.txtCidades.Name = "txtCidades";
            this.txtCidades.Size = new System.Drawing.Size(183, 20);
            this.txtCidades.TabIndex = 2;
            // 
            // btnAcrescenta
            // 
            this.btnAcrescenta.Location = new System.Drawing.Point(211, 41);
            this.btnAcrescenta.Name = "btnAcrescenta";
            this.btnAcrescenta.Size = new System.Drawing.Size(75, 23);
            this.btnAcrescenta.TabIndex = 3;
            this.btnAcrescenta.Text = "Acrescenta";
            this.btnAcrescenta.UseVisualStyleBackColor = true;
            this.btnAcrescenta.Click += new System.EventHandler(this.btnAcrescenta_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(211, 70);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 4;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(211, 99);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(75, 23);
            this.btnInicia.TabIndex = 5;
            this.btnInicia.Text = "Inicia";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 214);
            this.Controls.Add(this.btnInicia);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnAcrescenta);
            this.Controls.Add(this.txtCidades);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstCidade);
            this.Name = "ex2";
            this.Text = "ex2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCidade;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtCidades;
        private System.Windows.Forms.Button btnAcrescenta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnInicia;
    }
}