namespace _21_Juno_FichaCsharpWF_01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx4 = new System.Windows.Forms.Button();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEx1
            // 
            this.btnEx1.Location = new System.Drawing.Point(55, 36);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(186, 31);
            this.btnEx1.TabIndex = 0;
            this.btnEx1.Text = "Ex1";
            this.btnEx1.UseVisualStyleBackColor = true;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            // 
            // btnEx4
            // 
            this.btnEx4.Location = new System.Drawing.Point(55, 147);
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(186, 31);
            this.btnEx4.TabIndex = 1;
            this.btnEx4.Text = "Ex4";
            this.btnEx4.UseVisualStyleBackColor = true;
            // 
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(55, 110);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(186, 31);
            this.btnEx3.TabIndex = 2;
            this.btnEx3.Text = "Ex3";
            this.btnEx3.UseVisualStyleBackColor = true;
            // 
            // btnEx2
            // 
            this.btnEx2.Location = new System.Drawing.Point(55, 73);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(186, 31);
            this.btnEx2.TabIndex = 3;
            this.btnEx2.Text = "Ex2";
            this.btnEx2.UseVisualStyleBackColor = true;
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(198, 213);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(89, 31);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 256);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnEx2);
            this.Controls.Add(this.btnEx3);
            this.Controls.Add(this.btnEx4);
            this.Controls.Add(this.btnEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx4;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnFechar;
    }
}

