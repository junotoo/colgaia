namespace Fichas.ficha2
{
    partial class ex1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblPrimo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Inteiro";
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(88, 20);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(108, 20);
            this.txtInt.TabIndex = 1;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(174, 60);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(92, 23);
            this.btnVerifica.TabIndex = 2;
            this.btnVerifica.Text = "Verifica primo";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblPrimo
            // 
            this.lblPrimo.AutoSize = true;
            this.lblPrimo.Location = new System.Drawing.Point(38, 60);
            this.lblPrimo.Name = "lblPrimo";
            this.lblPrimo.Size = new System.Drawing.Size(35, 13);
            this.lblPrimo.TabIndex = 3;
            this.lblPrimo.Text = "label2";
            this.lblPrimo.Visible = false;
            // 
            // ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 95);
            this.Controls.Add(this.lblPrimo);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.label1);
            this.Name = "ex1";
            this.Text = "Verifica se número é primo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lblPrimo;
    }
}