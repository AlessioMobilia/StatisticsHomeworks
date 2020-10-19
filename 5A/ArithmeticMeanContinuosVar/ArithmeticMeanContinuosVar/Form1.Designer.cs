namespace ArithmeticMeanContinuosVar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.personNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPeaple = new System.Windows.Forms.RichTextBox();
            this.TextBoxDistribution = new System.Windows.Forms.RichTextBox();
            this.TextBoxAvg = new System.Windows.Forms.RichTextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGenerate.Location = new System.Drawing.Point(37, 45);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(124, 39);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // personNumber
            // 
            this.personNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personNumber.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personNumber.Location = new System.Drawing.Point(184, 62);
            this.personNumber.Name = "personNumber";
            this.personNumber.Size = new System.Drawing.Size(120, 16);
            this.personNumber.TabIndex = 1;
            this.personNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.personNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.personNumber.ValueChanged += new System.EventHandler(this.personNumber_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(184, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N. of People";
            // 
            // TextBoxPeaple
            // 
            this.TextBoxPeaple.BackColor = System.Drawing.SystemColors.Menu;
            this.TextBoxPeaple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPeaple.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPeaple.Location = new System.Drawing.Point(37, 126);
            this.TextBoxPeaple.Name = "TextBoxPeaple";
            this.TextBoxPeaple.ReadOnly = true;
            this.TextBoxPeaple.Size = new System.Drawing.Size(370, 305);
            this.TextBoxPeaple.TabIndex = 3;
            this.TextBoxPeaple.Text = "";
            // 
            // TextBoxDistribution
            // 
            this.TextBoxDistribution.BackColor = System.Drawing.SystemColors.Menu;
            this.TextBoxDistribution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDistribution.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxDistribution.Location = new System.Drawing.Point(413, 126);
            this.TextBoxDistribution.Name = "TextBoxDistribution";
            this.TextBoxDistribution.ReadOnly = true;
            this.TextBoxDistribution.Size = new System.Drawing.Size(347, 305);
            this.TextBoxDistribution.TabIndex = 4;
            this.TextBoxDistribution.Text = "";
            // 
            // TextBoxAvg
            // 
            this.TextBoxAvg.BackColor = System.Drawing.SystemColors.Menu;
            this.TextBoxAvg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAvg.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxAvg.Location = new System.Drawing.Point(37, 91);
            this.TextBoxAvg.Name = "TextBoxAvg";
            this.TextBoxAvg.ReadOnly = true;
            this.TextBoxAvg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TextBoxAvg.Size = new System.Drawing.Size(723, 29);
            this.TextBoxAvg.TabIndex = 5;
            this.TextBoxAvg.Text = "";
            // 
            // buttonClear
            // 
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(638, 46);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(122, 38);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.TextBoxAvg);
            this.Controls.Add(this.TextBoxDistribution);
            this.Controls.Add(this.TextBoxPeaple);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personNumber);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "5A - Alessio Mobilia";
            ((System.ComponentModel.ISupportInitialize)(this.personNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.NumericUpDown personNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TextBoxPeaple;
        private System.Windows.Forms.RichTextBox TextBoxDistribution;
        private System.Windows.Forms.RichTextBox TextBoxAvg;
        private System.Windows.Forms.Button buttonClear;
    }
}

