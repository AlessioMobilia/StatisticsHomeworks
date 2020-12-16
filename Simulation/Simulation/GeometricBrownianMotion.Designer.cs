namespace Simulation
{
    partial class GeometricBrownianMotion
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
            this.numericSigma = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sigma:";
            // 
            // numericSigma
            // 
            this.numericSigma.DecimalPlaces = 3;
            this.numericSigma.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericSigma.Location = new System.Drawing.Point(249, 28);
            this.numericSigma.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericSigma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericSigma.Name = "numericSigma";
            this.numericSigma.Size = new System.Drawing.Size(120, 20);
            this.numericSigma.TabIndex = 6;
            this.numericSigma.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericSigma.ValueChanged += new System.EventHandler(this.numericSigma_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1346, 648);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Plot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GeometricBrownianMotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 735);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericSigma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "GeometricBrownianMotion";
            this.Text = "GeometricBrownianMotion";
            ((System.ComponentModel.ISupportInitialize)(this.numericSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericSigma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}