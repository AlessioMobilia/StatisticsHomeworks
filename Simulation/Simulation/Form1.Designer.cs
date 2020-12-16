namespace Simulation
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
            this.buttonBM = new System.Windows.Forms.Button();
            this.buttonPoisson = new System.Windows.Forms.Button();
            this.buttonGBM = new System.Windows.Forms.Button();
            this.buttonMean = new System.Windows.Forms.Button();
            this.buttonOU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBM
            // 
            this.buttonBM.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBM.Location = new System.Drawing.Point(12, 133);
            this.buttonBM.Name = "buttonBM";
            this.buttonBM.Size = new System.Drawing.Size(167, 39);
            this.buttonBM.TabIndex = 1;
            this.buttonBM.Text = "Brownian Motion";
            this.buttonBM.UseVisualStyleBackColor = true;
            this.buttonBM.Click += new System.EventHandler(this.buttonBM_Click);
            // 
            // buttonPoisson
            // 
            this.buttonPoisson.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoisson.Location = new System.Drawing.Point(201, 73);
            this.buttonPoisson.Name = "buttonPoisson";
            this.buttonPoisson.Size = new System.Drawing.Size(178, 39);
            this.buttonPoisson.TabIndex = 3;
            this.buttonPoisson.Text = "Poisson Jump Process";
            this.buttonPoisson.UseVisualStyleBackColor = true;
            this.buttonPoisson.Click += new System.EventHandler(this.buttonPoisson_Click);
            // 
            // buttonGBM
            // 
            this.buttonGBM.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGBM.Location = new System.Drawing.Point(12, 70);
            this.buttonGBM.Name = "buttonGBM";
            this.buttonGBM.Size = new System.Drawing.Size(167, 45);
            this.buttonGBM.TabIndex = 4;
            this.buttonGBM.Text = "Geometric Brownian Motion";
            this.buttonGBM.UseVisualStyleBackColor = true;
            this.buttonGBM.Click += new System.EventHandler(this.buttonGBM_Click);
            // 
            // buttonMean
            // 
            this.buttonMean.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMean.Location = new System.Drawing.Point(201, 133);
            this.buttonMean.Name = "buttonMean";
            this.buttonMean.Size = new System.Drawing.Size(178, 38);
            this.buttonMean.TabIndex = 5;
            this.buttonMean.Text = "Glivenko-Cantelli";
            this.buttonMean.UseVisualStyleBackColor = true;
            this.buttonMean.Click += new System.EventHandler(this.buttonMean_Click);
            // 
            // buttonOU
            // 
            this.buttonOU.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOU.Location = new System.Drawing.Point(104, 12);
            this.buttonOU.Name = "buttonOU";
            this.buttonOU.Size = new System.Drawing.Size(178, 39);
            this.buttonOU.TabIndex = 6;
            this.buttonOU.Text = "Ornstein-Uhlenbeck";
            this.buttonOU.UseVisualStyleBackColor = true;
            this.buttonOU.Click += new System.EventHandler(this.buttonOU_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 193);
            this.Controls.Add(this.buttonOU);
            this.Controls.Add(this.buttonMean);
            this.Controls.Add(this.buttonGBM);
            this.Controls.Add(this.buttonPoisson);
            this.Controls.Add(this.buttonBM);
            this.Name = "Form1";
            this.Text = "Simulation Program";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBM;
        private System.Windows.Forms.Button buttonPoisson;
        private System.Windows.Forms.Button buttonGBM;
        private System.Windows.Forms.Button buttonMean;
        private System.Windows.Forms.Button buttonOU;
    }
}

