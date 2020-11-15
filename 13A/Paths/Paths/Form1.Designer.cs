namespace Paths
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericP = new System.Windows.Forms.NumericUpDown();
            this.numericEpsilon = new System.Windows.Forms.NumericUpDown();
            this.numericM = new System.Windows.Forms.NumericUpDown();
            this.numericN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEpsilon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Plot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1721, 671);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // numericP
            // 
            this.numericP.DecimalPlaces = 2;
            this.numericP.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericP.Location = new System.Drawing.Point(117, 36);
            this.numericP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericP.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericP.Name = "numericP";
            this.numericP.Size = new System.Drawing.Size(160, 18);
            this.numericP.TabIndex = 2;
            this.numericP.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericP.ValueChanged += new System.EventHandler(this.numericP_ValueChanged);
            // 
            // numericEpsilon
            // 
            this.numericEpsilon.DecimalPlaces = 2;
            this.numericEpsilon.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericEpsilon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericEpsilon.Location = new System.Drawing.Point(117, 65);
            this.numericEpsilon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericEpsilon.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEpsilon.Name = "numericEpsilon";
            this.numericEpsilon.Size = new System.Drawing.Size(160, 18);
            this.numericEpsilon.TabIndex = 3;
            this.numericEpsilon.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericEpsilon.ValueChanged += new System.EventHandler(this.numericEpsilon_ValueChanged);
            // 
            // numericM
            // 
            this.numericM.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericM.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericM.Location = new System.Drawing.Point(343, 36);
            this.numericM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericM.Name = "numericM";
            this.numericM.Size = new System.Drawing.Size(160, 18);
            this.numericM.TabIndex = 4;
            this.numericM.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericM.ValueChanged += new System.EventHandler(this.numericM_ValueChanged);
            // 
            // numericN
            // 
            this.numericN.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericN.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericN.Location = new System.Drawing.Point(343, 69);
            this.numericN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericN.Name = "numericN";
            this.numericN.Size = new System.Drawing.Size(160, 18);
            this.numericN.TabIndex = 5;
            this.numericN.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericN.ValueChanged += new System.EventHandler(this.numericN_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 11);
            this.label1.TabIndex = 6;
            this.label1.Text = "m:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 11);
            this.label2.TabIndex = 7;
            this.label2.Text = "n:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 11);
            this.label3.TabIndex = 8;
            this.label3.Text = "p:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 11);
            this.label4.TabIndex = 9;
            this.label4.Text = "epsilon:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericEpsilon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1179, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(560, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1755, 817);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Bernoulli";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEpsilon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericP;
        private System.Windows.Forms.NumericUpDown numericEpsilon;
        private System.Windows.Forms.NumericUpDown numericM;
        private System.Windows.Forms.NumericUpDown numericN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

