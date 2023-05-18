namespace Fichas.ficha3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCogumelos = new System.Windows.Forms.CheckBox();
            this.chkFiambre = new System.Windows.Forms.CheckBox();
            this.chkPepp = new System.Windows.Forms.CheckBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbParme = new System.Windows.Forms.RadioButton();
            this.rdbMoz = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbFina = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fichas.Properties.Resources.MicrosoftTeams_image;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCogumelos);
            this.groupBox1.Controls.Add(this.chkFiambre);
            this.groupBox1.Controls.Add(this.chkPepp);
            this.groupBox1.Location = new System.Drawing.Point(196, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredientes";
            // 
            // chkCogumelos
            // 
            this.chkCogumelos.AutoSize = true;
            this.chkCogumelos.Location = new System.Drawing.Point(6, 67);
            this.chkCogumelos.Name = "chkCogumelos";
            this.chkCogumelos.Size = new System.Drawing.Size(78, 17);
            this.chkCogumelos.TabIndex = 5;
            this.chkCogumelos.Text = "Cogumelos";
            this.chkCogumelos.UseVisualStyleBackColor = true;
            // 
            // chkFiambre
            // 
            this.chkFiambre.AutoSize = true;
            this.chkFiambre.Location = new System.Drawing.Point(6, 44);
            this.chkFiambre.Name = "chkFiambre";
            this.chkFiambre.Size = new System.Drawing.Size(63, 17);
            this.chkFiambre.TabIndex = 4;
            this.chkFiambre.Text = "Fiambre";
            this.chkFiambre.UseVisualStyleBackColor = true;
            // 
            // chkPepp
            // 
            this.chkPepp.AutoSize = true;
            this.chkPepp.Location = new System.Drawing.Point(6, 21);
            this.chkPepp.Name = "chkPepp";
            this.chkPepp.Size = new System.Drawing.Size(74, 17);
            this.chkPepp.TabIndex = 3;
            this.chkPepp.Text = "Pepperoni";
            this.chkPepp.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(133, 292);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(132, 43);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verifica Encomenda";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbParme);
            this.groupBox2.Controls.Add(this.rdbMoz);
            this.groupBox2.Location = new System.Drawing.Point(196, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 69);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredientes";
            // 
            // rdbParme
            // 
            this.rdbParme.AutoSize = true;
            this.rdbParme.Location = new System.Drawing.Point(6, 42);
            this.rdbParme.Name = "rdbParme";
            this.rdbParme.Size = new System.Drawing.Size(72, 17);
            this.rdbParme.TabIndex = 3;
            this.rdbParme.TabStop = true;
            this.rdbParme.Text = "Parmesão";
            this.rdbParme.UseVisualStyleBackColor = true;
            // 
            // rdbMoz
            // 
            this.rdbMoz.AutoSize = true;
            this.rdbMoz.Location = new System.Drawing.Point(6, 19);
            this.rdbMoz.Name = "rdbMoz";
            this.rdbMoz.Size = new System.Drawing.Size(73, 17);
            this.rdbMoz.TabIndex = 2;
            this.rdbMoz.TabStop = true;
            this.rdbMoz.Text = "Mozzarela";
            this.rdbMoz.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbNormal);
            this.groupBox3.Controls.Add(this.rdbFina);
            this.groupBox3.Location = new System.Drawing.Point(21, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 69);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingredientes";
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Location = new System.Drawing.Point(6, 42);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbNormal.TabIndex = 3;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            // 
            // rdbFina
            // 
            this.rdbFina.AutoSize = true;
            this.rdbFina.Location = new System.Drawing.Point(6, 19);
            this.rdbFina.Name = "rdbFina";
            this.rdbFina.Size = new System.Drawing.Size(45, 17);
            this.rdbFina.TabIndex = 2;
            this.rdbFina.TabStop = true;
            this.rdbFina.Text = "Fina";
            this.rdbFina.UseVisualStyleBackColor = true;
            // 
            // ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 362);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ex2";
            this.Text = "ex2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.CheckBox chkCogumelos;
        private System.Windows.Forms.CheckBox chkFiambre;
        private System.Windows.Forms.CheckBox chkPepp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbMoz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbFina;
        private System.Windows.Forms.RadioButton rdbParme;
        private System.Windows.Forms.RadioButton rdbNormal;
    }
}