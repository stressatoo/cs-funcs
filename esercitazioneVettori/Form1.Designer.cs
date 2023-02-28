namespace esercitazioneVettori
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEsegui = new System.Windows.Forms.Button();
            this.txtGiorni = new System.Windows.Forms.TextBox();
            this.txtTotParz_Arance = new System.Windows.Forms.TextBox();
            this.txtTotParz_Mandarini = new System.Windows.Forms.TextBox();
            this.txtTotale = new System.Windows.Forms.TextBox();
            this.txtMaxArance = new System.Windows.Forms.TextBox();
            this.txtMaxMandarini = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(203, 119);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(75, 23);
            this.btnEsegui.TabIndex = 0;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // txtGiorni
            // 
            this.txtGiorni.Location = new System.Drawing.Point(121, 38);
            this.txtGiorni.Name = "txtGiorni";
            this.txtGiorni.Size = new System.Drawing.Size(100, 20);
            this.txtGiorni.TabIndex = 1;
            // 
            // txtTotParz_Arance
            // 
            this.txtTotParz_Arance.Location = new System.Drawing.Point(212, 169);
            this.txtTotParz_Arance.Name = "txtTotParz_Arance";
            this.txtTotParz_Arance.Size = new System.Drawing.Size(100, 20);
            this.txtTotParz_Arance.TabIndex = 2;
            // 
            // txtTotParz_Mandarini
            // 
            this.txtTotParz_Mandarini.Location = new System.Drawing.Point(212, 195);
            this.txtTotParz_Mandarini.Name = "txtTotParz_Mandarini";
            this.txtTotParz_Mandarini.Size = new System.Drawing.Size(100, 20);
            this.txtTotParz_Mandarini.TabIndex = 3;
            // 
            // txtTotale
            // 
            this.txtTotale.Location = new System.Drawing.Point(212, 221);
            this.txtTotale.Name = "txtTotale";
            this.txtTotale.Size = new System.Drawing.Size(100, 20);
            this.txtTotale.TabIndex = 4;
            // 
            // txtMaxArance
            // 
            this.txtMaxArance.Location = new System.Drawing.Point(212, 247);
            this.txtMaxArance.Name = "txtMaxArance";
            this.txtMaxArance.Size = new System.Drawing.Size(100, 20);
            this.txtMaxArance.TabIndex = 5;
            // 
            // txtMaxMandarini
            // 
            this.txtMaxMandarini.Location = new System.Drawing.Point(212, 273);
            this.txtMaxMandarini.Name = "txtMaxMandarini";
            this.txtMaxMandarini.Size = new System.Drawing.Size(100, 20);
            this.txtMaxMandarini.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 359);
            this.Controls.Add(this.txtMaxMandarini);
            this.Controls.Add(this.txtMaxArance);
            this.Controls.Add(this.txtTotale);
            this.Controls.Add(this.txtTotParz_Mandarini);
            this.Controls.Add(this.txtTotParz_Arance);
            this.Controls.Add(this.txtGiorni);
            this.Controls.Add(this.btnEsegui);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.TextBox txtGiorni;
        private System.Windows.Forms.TextBox txtTotParz_Arance;
        private System.Windows.Forms.TextBox txtTotParz_Mandarini;
        private System.Windows.Forms.TextBox txtTotale;
        private System.Windows.Forms.TextBox txtMaxArance;
        private System.Windows.Forms.TextBox txtMaxMandarini;
    }
}

