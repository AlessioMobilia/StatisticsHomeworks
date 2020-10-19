namespace ArithmeticMeanCSharp
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
            this.buttonGemerate = new System.Windows.Forms.Button();
            this.TextBoxPeapleInfo = new System.Windows.Forms.RichTextBox();
            this.TextBoxAvg = new System.Windows.Forms.RichTextBox();
            this.PeapleNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.TextBoxDistribution = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PeapleNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGemerate
            // 
            this.buttonGemerate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonGemerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGemerate.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGemerate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonGemerate.Location = new System.Drawing.Point(64, 47);
            this.buttonGemerate.Name = "buttonGemerate";
            this.buttonGemerate.Size = new System.Drawing.Size(87, 38);
            this.buttonGemerate.TabIndex = 0;
            this.buttonGemerate.Text = "Generate";
            this.buttonGemerate.UseVisualStyleBackColor = false;
            this.buttonGemerate.Click += new System.EventHandler(this.buttonGemerate_Click);
            // 
            // TextBoxPeapleInfo
            // 
            this.TextBoxPeapleInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxPeapleInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPeapleInfo.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPeapleInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxPeapleInfo.Location = new System.Drawing.Point(64, 126);
            this.TextBoxPeapleInfo.Name = "TextBoxPeapleInfo";
            this.TextBoxPeapleInfo.ReadOnly = true;
            this.TextBoxPeapleInfo.Size = new System.Drawing.Size(415, 285);
            this.TextBoxPeapleInfo.TabIndex = 1;
            this.TextBoxPeapleInfo.Text = "";
            // 
            // TextBoxAvg
            // 
            this.TextBoxAvg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxAvg.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxAvg.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxAvg.Location = new System.Drawing.Point(64, 94);
            this.TextBoxAvg.Name = "TextBoxAvg";
            this.TextBoxAvg.ReadOnly = true;
            this.TextBoxAvg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TextBoxAvg.Size = new System.Drawing.Size(664, 26);
            this.TextBoxAvg.TabIndex = 2;
            this.TextBoxAvg.Text = "";
            // 
            // PeapleNumber
            // 
            this.PeapleNumber.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PeapleNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PeapleNumber.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PeapleNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.PeapleNumber.Location = new System.Drawing.Point(167, 62);
            this.PeapleNumber.Name = "PeapleNumber";
            this.PeapleNumber.Size = new System.Drawing.Size(101, 22);
            this.PeapleNumber.TabIndex = 3;
            this.PeapleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PeapleNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "N. of People";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonClear.Location = new System.Drawing.Point(645, 47);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(83, 41);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // TextBoxDistribution
            // 
            this.TextBoxDistribution.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxDistribution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDistribution.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxDistribution.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxDistribution.Location = new System.Drawing.Point(485, 126);
            this.TextBoxDistribution.Name = "TextBoxDistribution";
            this.TextBoxDistribution.ReadOnly = true;
            this.TextBoxDistribution.Size = new System.Drawing.Size(243, 285);
            this.TextBoxDistribution.TabIndex = 6;
            this.TextBoxDistribution.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxDistribution);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeapleNumber);
            this.Controls.Add(this.TextBoxAvg);
            this.Controls.Add(this.TextBoxPeapleInfo);
            this.Controls.Add(this.buttonGemerate);
            this.Name = "Form1";
            this.Text = "4_A - Alessio Mobilia";
            ((System.ComponentModel.ISupportInitialize)(this.PeapleNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGemerate;
        private System.Windows.Forms.RichTextBox TextBoxPeapleInfo;
        private System.Windows.Forms.RichTextBox TextBoxAvg;
        private System.Windows.Forms.NumericUpDown PeapleNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RichTextBox TextBoxDistribution;
    }
}

