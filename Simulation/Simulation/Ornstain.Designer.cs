namespace Simulation
{
    partial class Ornstain
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
            this.numericP = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericTheta = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericSigma = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTheta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericP
            // 
            this.numericP.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericP.Location = new System.Drawing.Point(669, 24);
            this.numericP.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericP.Name = "numericP";
            this.numericP.Size = new System.Drawing.Size(120, 20);
            this.numericP.TabIndex = 15;
            this.numericP.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericP.ValueChanged += new System.EventHandler(this.numericP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "P: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Theta:";
            // 
            // numericTheta
            // 
            this.numericTheta.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTheta.Location = new System.Drawing.Point(469, 26);
            this.numericTheta.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericTheta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTheta.Name = "numericTheta";
            this.numericTheta.Size = new System.Drawing.Size(120, 20);
            this.numericTheta.TabIndex = 12;
            this.numericTheta.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericTheta.ValueChanged += new System.EventHandler(this.numericTheta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sigma:";
            // 
            // numericSigma
            // 
            this.numericSigma.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSigma.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericSigma.Location = new System.Drawing.Point(243, 26);
            this.numericSigma.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericSigma.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericSigma.Name = "numericSigma";
            this.numericSigma.Size = new System.Drawing.Size(120, 20);
            this.numericSigma.TabIndex = 10;
            this.numericSigma.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericSigma.ValueChanged += new System.EventHandler(this.numericSigma_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1346, 648);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Plot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ornstain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 726);
            this.Controls.Add(this.numericP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericTheta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericSigma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Ornstain";
            this.Text = "BrownianMotion";
            ((System.ComponentModel.ISupportInitialize)(this.numericP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTheta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericTheta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericSigma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}