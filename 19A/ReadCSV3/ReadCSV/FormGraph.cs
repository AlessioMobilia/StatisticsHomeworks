using ReadCSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace ReadCSV2
{
    public partial class Chart : Form
    {

        public  List<DataPoint> points = Form1.points;
        public List<Interval> distributionX = Form1.distributionX;
        public List<Interval> distributionY = Form1.distributionY;
        public double medianX = Form1.medianX;
        public double medianY = Form1.medianY;
        public double firstX3quartile = Form1.firstX3quartile;
        public double thirdX3quartile = Form1.thirdX3quartile;
        public double firstY3quartile = Form1.firstY3quartile;
        public double thirdY3quartile = Form1.thirdY3quartile;
        int totalX = Form1.totalX;
        int totalY = Form1.totalY;
        List<int[]> contingency;
        public Charts chart = new Charts();
        public Charts tableChart = new Charts();

        Bitmap b;
        Graphics g;
        double maxX = -900000;
        double maxY = -900000;
        double minX = 0;
        double minY = 0;

        //options
        bool histogramX = false;
        bool histogramY = false;
        bool pointLabel = false;
        bool intervalLabel = true;
        bool trueMeanX = true;
        bool trueMeanY = true;
        bool rugPlot = true;
        bool scatterPlot = true;
        bool contingencyTable = true;

        Rectangle defaultViewport = new Rectangle(50, 20, 600, 300);

        public Chart()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.White;

            histogramX = checkBox1.Checked;
            histogramY = checkBoxHistogramY.Checked;
            pointLabel = checkBoxPointLabel.Checked;
            intervalLabel = checkBoxIntervalLabel.Checked;
            trueMeanX = checkBoxTrueMean.Checked;
            trueMeanY = trueMeanX;
            rugPlot = checkBox2.Checked;
            scatterPlot = checkBoxScatterPlot.Checked;
            contingencyTable = checkBoxContingency.Checked;



            foreach (DataPoint p in points)
            {
                if (p.X > maxX)
                    maxX = p.X;
                if (p.X < minX)
                    minX = p.X;

                if (p.Y > maxY)
                    maxY = p.Y;
                if (p.Y < minY)
                    minY = p.Y;

            }

            contingency = Statistics.ContingencyTable(distributionX, distributionY);



            //draw Graph
            inizializateChart();
            UpdateChart();


        }

        public void inizializateChart()
        {

            this.b = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            this.g = Graphics.FromImage(b);
            this.g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;


            //initialize the chart
            chart.minX = minX;
            chart.minY = minY;
            chart.maxX = maxX;
            chart.maxY = maxY;

            //set offset to show all points
            double ChangeX = (maxX-minX) * 40 / defaultViewport.Width;
            double ChangeY = (maxY - minY)*ChangeX /(maxX - minX);
            chart.minX -= ChangeX;
            chart.minY -= ChangeY;

            chart.viewPort = new Rectangle(defaultViewport.Location,defaultViewport.Size);


            //initialize the table
            tableChart.minX = minX;
            tableChart.minY = minY;
            tableChart.maxX = maxX;
            tableChart.maxY = maxY;
            tableChart.viewPort = new Rectangle(50, 340, 600, 300);
        }

        public void UpdateChart()
        {
            this.g.Clear(Color.White);

            //draw chart
            chart.DrawViewport(g);
            if(scatterPlot)
                chart.DrawPoints(points, g,pointLabel);
            if (rugPlot)
                chart.DrawRugPlot(points, g);
            if (trueMeanX)
                chart.DrawTrueMeanX(distributionX, g);
            if (trueMeanY)
                chart.DrawTrueMeanY(distributionY, g);
            chart.DrawAxis(g);
            if (intervalLabel)
                chart.DrawRangeLabel(distributionX, distributionY, g);
            if (histogramX)
                chart.DrawHistogram(distributionX, totalX, g);
            if (histogramY)
                chart.DrawYHistogram(distributionY, totalY, g);


            chart.drawHorizzontalLine(medianY, "", g);
            chart.drawVerticalLine(medianX, g);
            chart.drawHorizzontalLine(firstY3quartile, "", g);
            chart.drawVerticalLine(firstX3quartile, g);
            chart.drawHorizzontalLine(thirdY3quartile, "", g);
            chart.drawVerticalLine(thirdX3quartile, g);


            //draw table
            if (contingencyTable)
            {    
                tableChart.DrawTable(contingency, distributionX, distributionY, g);
            }
            
            pictureBox1.Image = b;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            histogramX = checkBox1.Checked;
            UpdateChart();

        }

        private void buttonColorHistX_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                chart.histrogramBrush= new SolidBrush(Color.FromArgb(60, colorDialog.Color));
                UpdateChart();
            }
        }

        private void buttonColorHistY_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                chart.histrogramYBrush = new SolidBrush(Color.FromArgb(60, colorDialog.Color));
                UpdateChart();
            }

        }

        private void buttonFontLabel_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                chart.drawFont = fontDialog1.Font;
                UpdateChart();
            }
        }

        private void checkBoxPointLabel_CheckedChanged(object sender, EventArgs e)
        {
            pointLabel = checkBoxPointLabel.Checked;
            UpdateChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                chart.fontBrush.Color = colorDialog.Color;
                UpdateChart();
            }

        }

        private void checkBoxHistogramY_CheckedChanged(object sender, EventArgs e)
        {
            histogramY = checkBoxHistogramY.Checked;
            UpdateChart();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                chart.viewPortPen.Color = colorDialog.Color;
                UpdateChart();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message;
            const string caption = "Done";
            


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            sfd.FileName = "Chart.png";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }

                try
                {
                    pictureBox1.Image.Save(sfd.FileName, format);
                    message = "Image saved succesfully";
                }
                catch
                {
                    message ="Impossible save the image";
                }
                var result = MessageBox.Show(message, caption);
            }
        }



        private void checkBoxTrueMean_CheckedChanged(object sender, EventArgs e)
        {
            trueMeanX = checkBoxTrueMean.Checked;
            trueMeanY = trueMeanX;
            UpdateChart();
        }

        private void buttonColorTrueMean_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                chart.trueMeanPen.Color = colorDialog.Color;
                UpdateChart();
            }


        }

        private void checkBoxIntervalLabel_CheckedChanged(object sender, EventArgs e)
        {
            intervalLabel = checkBoxIntervalLabel.Checked;
            UpdateChart();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            rugPlot = checkBox2.Checked;
            UpdateChart();
        }

        private void buttonColorRugPlot_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                chart.RugPen.Color = colorDialog.Color;
                UpdateChart();
            }

        }

        private void checkBoxScatterPlot_CheckedChanged(object sender, EventArgs e)
        {
            scatterPlot = checkBoxScatterPlot.Checked;
            UpdateChart();

        }

        private void buttonColorPoints_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                chart.pointBrush = new SolidBrush(colorDialog.Color);
                UpdateChart();
            }
        }

        private void checkBoxContingency_CheckedChanged(object sender, EventArgs e)
        {

            contingencyTable = checkBoxContingency.Checked;
            UpdateChart();

        }

        private void buttonFontTable_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                tableChart.tableFont = fontDialog1.Font;
                UpdateChart();
            }
        }



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            chart.MouseDown(e);
            tableChart.MouseDown(e);

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            chart.MouseMove(e);
            tableChart.MouseMove(e);
            UpdateChart();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            chart.MouseUp(e);
            tableChart.MouseUp(e);
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            chart.MouseWheel(e);
            tableChart.MouseWheel(e);
            UpdateChart();

        }



        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.Focus();
        }

        private void buttonColorFontTable_Click(object sender, EventArgs e)
        {

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                tableChart.fontBrush.Color =colorDialog.Color;
                UpdateChart();
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                tableChart.tablePen.Brush = new SolidBrush(colorDialog.Color);
                UpdateChart();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int height = chart.viewPort.Height;
            chart.viewPort = new Rectangle(chart.viewPort.X, chart.viewPort.Y, height * (int)(maxX / maxY), height);
            UpdateChart();
        }

        private void buttonViewPortReset_Click(object sender, EventArgs e)
        {
            chart.viewPort = new Rectangle(defaultViewport.Location, defaultViewport.Size);
            UpdateChart();
        }
    }
}
