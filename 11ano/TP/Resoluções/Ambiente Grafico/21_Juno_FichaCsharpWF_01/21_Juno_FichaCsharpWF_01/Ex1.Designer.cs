namespace _21_Juno_FichaCsharpWF_01
{
    partial class Ex1
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
            this.lblNoddy = new System.Windows.Forms.Label();
            this.btnQuem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNoddy
            // 
            this.lblNoddy.AutoSize = true;
            this.lblNoddy.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoddy.Location = new System.Drawing.Point(88, 25);
            this.lblNoddy.Name = "lblNoddy";
            this.lblNoddy.Size = new System.Drawing.Size(176, 38);
            this.lblNoddy.TabIndex = 1;
            this.lblNoddy.Text = "Sou o Noddy";
            this.lblNoddy.Visible = false;
            // 
            // btnQuem
            // 
            this.btnQuem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnQuem.Location = new System.Drawing.Point(93, 119);
            this.btnQuem.Name = "btnQuem";
            this.btnQuem.Size = new System.Drawing.Size(171, 39);
            this.btnQuem.TabIndex = 2;
            this.btnQuem.Text = "Quem sou eu?";
            this.btnQuem.UseVisualStyleBackColor = true;
            this.btnQuem.Click += new System.EventHandler(this.btnQuem_Click);
            // 
            // Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 202);
            this.Controls.Add(this.btnQuem);
            this.Controls.Add(this.lblNoddy);
            this.Name = "Ex1";
            this.Text = "Ex1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoddy;
        private System.Windows.Forms.Button btnQuem;
    }
}