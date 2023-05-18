namespace Fichas.ficha10
{
    partial class ex3
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
            this.lst1 = new System.Windows.Forms.ListBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAcrescenta = new System.Windows.Forms.Button();
            this.btnJunta = new System.Windows.Forms.Button();
            this.Seleccoes = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(12, 12);
            this.lst1.Name = "lst1";
            this.lst1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst1.Size = new System.Drawing.Size(134, 95);
            this.lst1.TabIndex = 0;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(262, 24);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(170, 24);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAcrescenta
            // 
            this.btnAcrescenta.Location = new System.Drawing.Point(170, 53);
            this.btnAcrescenta.Name = "btnAcrescenta";
            this.btnAcrescenta.Size = new System.Drawing.Size(75, 23);
            this.btnAcrescenta.TabIndex = 3;
            this.btnAcrescenta.Text = "Acrescenta";
            this.btnAcrescenta.UseVisualStyleBackColor = true;
            this.btnAcrescenta.Click += new System.EventHandler(this.btnAcrescenta_Click);
            // 
            // btnJunta
            // 
            this.btnJunta.Location = new System.Drawing.Point(170, 82);
            this.btnJunta.Name = "btnJunta";
            this.btnJunta.Size = new System.Drawing.Size(75, 23);
            this.btnJunta.TabIndex = 4;
            this.btnJunta.Text = "Junta";
            this.btnJunta.UseVisualStyleBackColor = true;
            this.btnJunta.Click += new System.EventHandler(this.btnJunta_Click);
            // 
            // Seleccoes
            // 
            this.Seleccoes.AutoSize = true;
            this.Seleccoes.Location = new System.Drawing.Point(259, 58);
            this.Seleccoes.Name = "Seleccoes";
            this.Seleccoes.Size = new System.Drawing.Size(60, 13);
            this.Seleccoes.TabIndex = 5;
            this.Seleccoes.Text = "Seleccoes:";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(259, 82);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(10, 13);
            this.lblSelect.TabIndex = 6;
            this.lblSelect.Text = "-";
            // 
            // ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 129);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.Seleccoes);
            this.Controls.Add(this.btnJunta);
            this.Controls.Add(this.btnAcrescenta);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lst1);
            this.Name = "ex3";
            this.Text = "ex3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAcrescenta;
        private System.Windows.Forms.Button btnJunta;
        private System.Windows.Forms.Label Seleccoes;
        private System.Windows.Forms.Label lblSelect;
    }
}