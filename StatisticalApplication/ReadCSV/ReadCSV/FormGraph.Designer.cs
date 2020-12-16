namespace ReadCSV2
{
    partial class Chart
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
            this.CheckPercentage = new System.Windows.Forms.CheckBox();
            this.buttonViewPortReset = new System.Windows.Forms.Button();
            this.buttonProportions = new System.Windows.Forms.Button();
            this.buttonColorTable = new System.Windows.Forms.Button();
            this.buttonColorFontTable = new System.Windows.Forms.Button();
            this.buttonFontTable = new System.Windows.Forms.Button();
            this.checkBoxContingency = new System.Windows.Forms.CheckBox();
            this.buttonColorPoints = new System.Windows.Forms.Button();
            this.checkBoxScatterPlot = new System.Windows.Forms.CheckBox();
            this.buttonColorRugPlot = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBoxIntervalLabel = new System.Windows.Forms.CheckBox();
            this.buttonColorTrueMean = new System.Windows.Forms.Button();
            this.checkBoxTrueMean = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxHistogramY = new System.Windows.Forms.CheckBox();
            this.buttonColorLabel = new System.Windows.Forms.Button();
            this.checkBoxPointLabel = new System.Windows.Forms.CheckBox();
            this.buttonFontLabel = new System.Windows.Forms.Button();
            this.buttonColorHistY = new System.Windows.Forms.Button();
            this.buttonColorHistX = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(14, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1158, 900);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CheckPercentage);
            this.groupBox1.Controls.Add(this.buttonViewPortReset);
            this.groupBox1.Controls.Add(this.buttonProportions);
            this.groupBox1.Controls.Add(this.buttonColorTable);
            this.groupBox1.Controls.Add(this.buttonColorFontTable);
            this.groupBox1.Controls.Add(this.buttonFontTable);
            this.groupBox1.Controls.Add(this.checkBoxContingency);
            this.groupBox1.Controls.Add(this.buttonColorPoints);
            this.groupBox1.Controls.Add(this.checkBoxScatterPlot);
            this.groupBox1.Controls.Add(this.buttonColorRugPlot);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBoxIntervalLabel);
            this.groupBox1.Controls.Add(this.buttonColorTrueMean);
            this.groupBox1.Controls.Add(this.checkBoxTrueMean);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxHistogramY);
            this.groupBox1.Controls.Add(this.buttonColorLabel);
            this.groupBox1.Controls.Add(this.checkBoxPointLabel);
            this.groupBox1.Controls.Add(this.buttonFontLabel);
            this.groupBox1.Controls.Add(this.buttonColorHistY);
            this.groupBox1.Controls.Add(this.buttonColorHistX);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(1178, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(190, 845);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // CheckPercentage
            // 
            this.CheckPercentage.AutoSize = true;
            this.CheckPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckPercentage.Location = new System.Drawing.Point(3, 567);
            this.CheckPercentage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckPercentage.Name = "CheckPercentage";
            this.CheckPercentage.Size = new System.Drawing.Size(115, 19);
            this.CheckPercentage.TabIndex = 21;
            this.CheckPercentage.Text = "Percentage";
            this.CheckPercentage.UseVisualStyleBackColor = true;
            this.CheckPercentage.CheckedChanged += new System.EventHandler(this.CheckPercentage_CheckedChanged);
            // 
            // buttonViewPortReset
            // 
            this.buttonViewPortReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewPortReset.Location = new System.Drawing.Point(3, 768);
            this.buttonViewPortReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonViewPortReset.Name = "buttonViewPortReset";
            this.buttonViewPortReset.Size = new System.Drawing.Size(173, 31);
            this.buttonViewPortReset.TabIndex = 20;
            this.buttonViewPortReset.Text = "Reset ViewPort";
            this.buttonViewPortReset.UseVisualStyleBackColor = true;
            this.buttonViewPortReset.Click += new System.EventHandler(this.buttonViewPortReset_Click);
            // 
            // buttonProportions
            // 
            this.buttonProportions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProportions.Location = new System.Drawing.Point(3, 729);
            this.buttonProportions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonProportions.Name = "buttonProportions";
            this.buttonProportions.Size = new System.Drawing.Size(171, 31);
            this.buttonProportions.TabIndex = 19;
            this.buttonProportions.Text = "Set Data ratio";
            this.buttonProportions.UseVisualStyleBackColor = true;
            this.buttonProportions.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // buttonColorTable
            // 
            this.buttonColorTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorTable.Location = new System.Drawing.Point(2, 671);
            this.buttonColorTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonColorTable.Name = "buttonColorTable";
            this.buttonColorTable.Size = new System.Drawing.Size(175, 31);
            this.buttonColorTable.TabIndex = 18;
            this.buttonColorTable.Text = "Color Table";
            this.buttonColorTable.UseVisualStyleBackColor = true;
            this.buttonColorTable.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonColorFontTable
            // 
            this.buttonColorFontTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorFontTable.Location = new System.Drawing.Point(3, 632);
            this.buttonColorFontTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonColorFontTable.Name = "buttonColorFontTable";
            this.buttonColorFontTable.Size = new System.Drawing.Size(174, 31);
            this.buttonColorFontTable.TabIndex = 17;
            this.buttonColorFontTable.Text = "Color Font Table";
            this.buttonColorFontTable.UseVisualStyleBackColor = true;
            this.buttonColorFontTable.Click += new System.EventHandler(this.buttonColorFontTable_Click);
            // 
            // buttonFontTable
            // 
            this.buttonFontTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFontTable.Location = new System.Drawing.Point(3, 592);
            this.buttonFontTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFontTable.Name = "buttonFontTable";
            this.buttonFontTable.Size = new System.Drawing.Size(174, 31);
            this.buttonFontTable.TabIndex = 16;
            this.buttonFontTable.Text = "Font Table";
            this.buttonFontTable.UseVisualStyleBackColor = true;
            this.buttonFontTable.Click += new System.EventHandler(this.buttonFontTable_Click);
            // 
            // checkBoxContingency
            // 
            this.checkBoxContingency.AutoSize = true;
            this.checkBoxContingency.Checked = true;
            this.checkBoxContingency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxContingency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxContingency.Location = new System.Drawing.Point(3, 544);
            this.checkBoxContingency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxContingency.Name = "checkBoxContingency";
            this.checkBoxContingency.Size = new System.Drawing.Size(169, 19);
            this.checkBoxContingency.TabIndex = 15;
            this.checkBoxContingency.Text = "Contigency Table";
            this.checkBoxContingency.UseVisualStyleBackColor = true;
            this.checkBoxContingency.CheckedChanged += new System.EventHandler(this.checkBoxContingency_CheckedChanged);
            // 
            // buttonColorPoints
            // 
            this.buttonColorPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorPoints.Location = new System.Drawing.Point(3, 55);
            this.buttonColorPoints.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonColorPoints.Name = "buttonColorPoints";
            this.buttonColorPoints.Size = new System.Drawing.Size(178, 31);
            this.buttonColorPoints.TabIndex = 14;
            this.buttonColorPoints.Text = "Color Points";
            this.buttonColorPoints.UseVisualStyleBackColor = true;
            this.buttonColorPoints.Click += new System.EventHandler(this.buttonColorPoints_Click);
            // 
            // checkBoxScatterPlot
            // 
            this.checkBoxScatterPlot.AutoSize = true;
            this.checkBoxScatterPlot.Checked = true;
            this.checkBoxScatterPlot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScatterPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxScatterPlot.Location = new System.Drawing.Point(5, 24);
            this.checkBoxScatterPlot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxScatterPlot.Name = "checkBoxScatterPlot";
            this.checkBoxScatterPlot.Size = new System.Drawing.Size(133, 19);
            this.checkBoxScatterPlot.TabIndex = 13;
            this.checkBoxScatterPlot.Text = "Scatter Plot";
            this.checkBoxScatterPlot.UseVisualStyleBackColor = true;
            this.checkBoxScatterPlot.CheckedChanged += new System.EventHandler(this.checkBoxScatterPlot_CheckedChanged);
            // 
            // buttonColorRugPlot
            // 
            this.buttonColorRugPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorRugPlot.Location = new System.Drawing.Point(5, 485);
            this.buttonColorRugPlot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonColorRugPlot.Name = "buttonColorRugPlot";
            this.buttonColorRugPlot.Size = new System.Drawing.Size(174, 31);
            this.buttonColorRugPlot.TabIndex = 12;
            this.buttonColorRugPlot.Text = "Color Rug Plot";
            this.buttonColorRugPlot.UseVisualStyleBackColor = true;
            this.buttonColorRugPlot.Click += new System.EventHandler(this.buttonColorRugPlot_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(5, 456);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 19);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Rug Plot";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxIntervalLabel
            // 
            this.checkBoxIntervalLabel.AutoSize = true;
            this.checkBoxIntervalLabel.Checked = true;
            this.checkBoxIntervalLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIntervalLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxIntervalLabel.Location = new System.Drawing.Point(3, 427);
            this.checkBoxIntervalLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxIntervalLabel.Name = "checkBoxIntervalLabel";
            this.checkBoxIntervalLabel.Size = new System.Drawing.Size(151, 19);
            this.checkBoxIntervalLabel.TabIndex = 10;
            this.checkBoxIntervalLabel.Text = "Interval Label";
            this.checkBoxIntervalLabel.UseMnemonic = false;
            this.checkBoxIntervalLabel.UseVisualStyleBackColor = true;
            this.checkBoxIntervalLabel.CheckedChanged += new System.EventHandler(this.checkBoxIntervalLabel_CheckedChanged);
            // 
            // buttonColorTrueMean
            // 
            this.buttonColorTrueMean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorTrueMean.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonColorTrueMean.Location = new System.Drawing.Point(7, 388);
            this.buttonColorTrueMean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonColorTrueMean.Name = "buttonColorTrueMean";
            this.buttonColorTrueMean.Size = new System.Drawing.Size(173, 31);
            this.buttonColorTrueMean.TabIndex = 9;
            this.buttonColorTrueMean.Text = "Color True Mean";
            this.buttonColorTrueMean.UseVisualStyleBackColor = true;
            this.buttonColorTrueMean.Click += new System.EventHandler(this.buttonColorTrueMean_Click);
            // 
            // checkBoxTrueMean
            // 
            this.checkBoxTrueMean.AutoSize = true;
            this.checkBoxTrueMean.Checked = true;
            this.checkBoxTrueMean.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTrueMean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxTrueMean.Location = new System.Drawing.Point(2, 359);
            this.checkBoxTrueMean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxTrueMean.Name = "checkBoxTrueMean";
            this.checkBoxTrueMean.Size = new System.Drawing.Size(151, 19);
            this.checkBoxTrueMean.TabIndex = 8;
            this.checkBoxTrueMean.Text = "True Mean Line";
            this.checkBoxTrueMean.UseVisualStyleBackColor = true;
            this.checkBoxTrueMean.CheckedChanged += new System.EventHandler(this.checkBoxTrueMean_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(5, 807);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Color ViewPort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBoxHistogramY
            // 
            this.checkBoxHistogramY.AutoSize = true;
            this.checkBoxHistogramY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxHistogramY.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHistogramY.Location = new System.Drawing.Point(5, 291);
            this.checkBoxHistogramY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxHistogramY.Name = "checkBoxHistogramY";
            this.checkBoxHistogramY.Size = new System.Drawing.Size(124, 19);
            this.checkBoxHistogramY.TabIndex = 6;
            this.checkBoxHistogramY.Text = "Histogram Y";
            this.checkBoxHistogramY.UseVisualStyleBackColor = true;
            this.checkBoxHistogramY.CheckedChanged += new System.EventHandler(this.checkBoxHistogramY_CheckedChanged);
            // 
            // buttonColorLabel
            // 
            this.buttonColorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonColorLabel.Location = new System.Drawing.Point(3, 161);
            this.buttonColorLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonColorLabel.Name = "buttonColorLabel";
            this.buttonColorLabel.Size = new System.Drawing.Size(179, 31);
            this.buttonColorLabel.TabIndex = 5;
            this.buttonColorLabel.Text = "Color label";
            this.buttonColorLabel.UseVisualStyleBackColor = true;
            this.buttonColorLabel.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxPointLabel
            // 
            this.checkBoxPointLabel.AutoSize = true;
            this.checkBoxPointLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPointLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPointLabel.Location = new System.Drawing.Point(7, 93);
            this.checkBoxPointLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPointLabel.Name = "checkBoxPointLabel";
            this.checkBoxPointLabel.Size = new System.Drawing.Size(151, 19);
            this.checkBoxPointLabel.TabIndex = 4;
            this.checkBoxPointLabel.Text = "Points\' Labels";
            this.checkBoxPointLabel.UseVisualStyleBackColor = true;
            this.checkBoxPointLabel.CheckedChanged += new System.EventHandler(this.checkBoxPointLabel_CheckedChanged);
            // 
            // buttonFontLabel
            // 
            this.buttonFontLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFontLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFontLabel.Location = new System.Drawing.Point(5, 123);
            this.buttonFontLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFontLabel.Name = "buttonFontLabel";
            this.buttonFontLabel.Size = new System.Drawing.Size(177, 31);
            this.buttonFontLabel.TabIndex = 3;
            this.buttonFontLabel.Text = "Font label";
            this.buttonFontLabel.UseVisualStyleBackColor = true;
            this.buttonFontLabel.Click += new System.EventHandler(this.buttonFontLabel_Click);
            // 
            // buttonColorHistY
            // 
            this.buttonColorHistY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorHistY.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonColorHistY.Location = new System.Drawing.Point(6, 320);
            this.buttonColorHistY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonColorHistY.Name = "buttonColorHistY";
            this.buttonColorHistY.Size = new System.Drawing.Size(174, 31);
            this.buttonColorHistY.TabIndex = 2;
            this.buttonColorHistY.Text = "Color Histogram Y";
            this.buttonColorHistY.UseVisualStyleBackColor = true;
            this.buttonColorHistY.Click += new System.EventHandler(this.buttonColorHistY_Click);
            // 
            // buttonColorHistX
            // 
            this.buttonColorHistX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorHistX.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonColorHistX.Location = new System.Drawing.Point(5, 252);
            this.buttonColorHistX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonColorHistX.Name = "buttonColorHistX";
            this.buttonColorHistX.Size = new System.Drawing.Size(174, 31);
            this.buttonColorHistX.TabIndex = 1;
            this.buttonColorHistX.Text = "Color Histogram X";
            this.buttonColorHistX.UseVisualStyleBackColor = true;
            this.buttonColorHistX.Click += new System.EventHandler(this.buttonColorHistX_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(5, 223);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Histrogram X";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1178, 871);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 933);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Chart";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonColorHistY;
        private System.Windows.Forms.Button buttonColorHistX;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button buttonFontLabel;
        private System.Windows.Forms.CheckBox checkBoxPointLabel;
        private System.Windows.Forms.Button buttonColorLabel;
        private System.Windows.Forms.CheckBox checkBoxHistogramY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxTrueMean;
        private System.Windows.Forms.Button buttonColorTrueMean;
        private System.Windows.Forms.CheckBox checkBoxIntervalLabel;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button buttonColorRugPlot;
        private System.Windows.Forms.CheckBox checkBoxScatterPlot;
        private System.Windows.Forms.Button buttonColorPoints;
        private System.Windows.Forms.CheckBox checkBoxContingency;
        private System.Windows.Forms.Button buttonColorFontTable;
        private System.Windows.Forms.Button buttonFontTable;
        private System.Windows.Forms.Button buttonColorTable;
        private System.Windows.Forms.Button buttonProportions;
        private System.Windows.Forms.Button buttonViewPortReset;
        private System.Windows.Forms.CheckBox CheckPercentage;
    }
}