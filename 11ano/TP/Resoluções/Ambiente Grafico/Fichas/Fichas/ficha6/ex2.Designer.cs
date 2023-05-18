namespace Fichas.ficha6
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
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtDiasSemana = new System.Windows.Forms.RadioButton();
            this.rbtMeses = new System.Windows.Forms.RadioButton();
            this.rbtEstacoes = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(26, 75);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(287, 160);
            this.lstResultados.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtEstacoes);
            this.groupBox1.Controls.Add(this.rbtMeses);
            this.groupBox1.Controls.Add(this.rbtDiasSemana);
            this.groupBox1.Location = new System.Drawing.Point(16, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtDiasSemana
            // 
            this.rbtDiasSemana.AutoSize = true;
            this.rbtDiasSemana.Location = new System.Drawing.Point(10, 24);
            this.rbtDiasSemana.Name = "rbtDiasSemana";
            this.rbtDiasSemana.Size = new System.Drawing.Size(103, 17);
            this.rbtDiasSemana.TabIndex = 0;
            this.rbtDiasSemana.TabStop = true;
            this.rbtDiasSemana.Text = "Dias da Semana";
            this.rbtDiasSemana.UseVisualStyleBackColor = true;
            this.rbtDiasSemana.CheckedChanged += new System.EventHandler(this.rbtDiasSemanas_CheckedChanged);
            // 
            // rbtMeses
            // 
            this.rbtMeses.AutoSize = true;
            this.rbtMeses.Location = new System.Drawing.Point(119, 24);
            this.rbtMeses.Name = "rbtMeses";
            this.rbtMeses.Size = new System.Drawing.Size(56, 17);
            this.rbtMeses.TabIndex = 1;
            this.rbtMeses.TabStop = true;
            this.rbtMeses.Text = "Meses";
            this.rbtMeses.UseVisualStyleBackColor = true;
            this.rbtMeses.CheckedChanged += new System.EventHandler(this.rbtMeses_CheckedChanged);
            // 
            // rbtEstacoes
            // 
            this.rbtEstacoes.AutoSize = true;
            this.rbtEstacoes.Location = new System.Drawing.Point(191, 24);
            this.rbtEstacoes.Name = "rbtEstacoes";
            this.rbtEstacoes.Size = new System.Drawing.Size(106, 17);
            this.rbtEstacoes.TabIndex = 2;
            this.rbtEstacoes.TabStop = true;
            this.rbtEstacoes.Text = "Estações do Ano";
            this.rbtEstacoes.UseVisualStyleBackColor = true;
            this.rbtEstacoes.CheckedChanged += new System.EventHandler(this.rbtEstacoes_CheckedChanged);
            // 
            // ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 247);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstResultados);
            this.Name = "ex2";
            this.Text = "ex2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtEstacoes;
        private System.Windows.Forms.RadioButton rbtMeses;
        private System.Windows.Forms.RadioButton rbtDiasSemana;
    }
}