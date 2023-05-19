namespace Fichas.ficha10
{
    partial class ex5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkordem = new System.Windows.Forms.CheckBox();
            this.chkDebito = new System.Windows.Forms.CheckBox();
            this.chkCredito = new System.Windows.Forms.CheckBox();
            this.chkPrazo = new System.Windows.Forms.CheckBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPrazo);
            this.groupBox1.Controls.Add(this.chkCredito);
            this.groupBox1.Controls.Add(this.chkDebito);
            this.groupBox1.Controls.Add(this.chkordem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Boxes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkordem
            // 
            this.chkordem.AutoSize = true;
            this.chkordem.Location = new System.Drawing.Point(6, 19);
            this.chkordem.Name = "chkordem";
            this.chkordem.Size = new System.Drawing.Size(88, 17);
            this.chkordem.TabIndex = 0;
            this.chkordem.Text = "Conta Ordem";
            this.chkordem.UseVisualStyleBackColor = true;
            // 
            // chkDebito
            // 
            this.chkDebito.AutoSize = true;
            this.chkDebito.Location = new System.Drawing.Point(6, 42);
            this.chkDebito.Name = "chkDebito";
            this.chkDebito.Size = new System.Drawing.Size(91, 17);
            this.chkDebito.TabIndex = 1;
            this.chkDebito.Text = "Cartao Debito";
            this.chkDebito.UseVisualStyleBackColor = true;
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Location = new System.Drawing.Point(92, 42);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(93, 17);
            this.chkCredito.TabIndex = 2;
            this.chkCredito.Text = "Cartao Credito";
            this.chkCredito.UseVisualStyleBackColor = true;
            // 
            // chkPrazo
            // 
            this.chkPrazo.AutoSize = true;
            this.chkPrazo.Location = new System.Drawing.Point(92, 19);
            this.chkPrazo.Name = "chkPrazo";
            this.chkPrazo.Size = new System.Drawing.Size(84, 17);
            this.chkPrazo.TabIndex = 3;
            this.chkPrazo.Text = "Conta Prazo";
            this.chkPrazo.UseVisualStyleBackColor = true;
            this.chkPrazo.CheckedChanged += new System.EventHandler(this.chkPrazo_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(15, 134);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(10, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "-";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(12, 91);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 2;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // ex5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 196);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ex5";
            this.Text = "ex5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPrazo;
        private System.Windows.Forms.CheckBox chkCredito;
        private System.Windows.Forms.CheckBox chkDebito;
        private System.Windows.Forms.CheckBox chkordem;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnResultado;
    }
}