using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integration
{
    public partial class Form1 : Form
    {

        public Charts chart = new Charts();
        public Charts chart2 = new Charts();
        Bitmap b;
        Graphics g;

        Double minX = 0;
        Double maxX = 20;
        
        Double minY = 0;
        Double maxY = 400;

        Double step = 0.1;
        int interval = 5;

        public Form1()
        {
            InitializeComponent();

            this.b = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            this.g = Graphics.FromImage(b);
            this.g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            labelXMax.Text = maxX.ToString();
            labelXMin.Text = minX.ToString();

            //initialize the chart
            chart.minX = minX;
            chart.minY = minY;
            chart.maxX = maxX;
            chart.maxY = maxY;

            chart.viewPort = new Rectangle(100,10,300,500);


            chart2.minX = minX;
            chart2.minY = minY;
            chart2.maxX = maxX;
            chart2.maxY = maxY;

            chart2.viewPort = new Rectangle(570, 10, 300, 500);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.g.Clear(Color.White);
            //draw chart
            UpdateCharts();

            timer1.Start();




        }

        private void UpdateCharts()
        {
            labelIntervals.Text = interval.ToString();
            chart.DrawViewport(g);
            chart.DrawAxis(g);
            chart.DrawFunction(function, minX, maxX, step, g);
            chart2.DrawViewport(g);
            chart2.DrawAxis(g);
            chart2.DrawFunction(function, minX, maxX, step, g);
            List<Interval> rectangles = NaiveIntegral(function, minX, maxX, interval, chart);
            chart.DrawHistogram(rectangles,rectangles.Count,g);
            List<Interval> rectanglesY = NaiveIntegralLebesgue(functionInverse, minY, maxY, interval, chart);
            chart2.DrawHorizzontalRectangles(rectanglesY, g);
            pictureBox1.Image = b;
        }

        public List<Interval> NaiveIntegral(Func<double, double> f, double minX, double maxX, int intervalNumber, Charts chart)
        {
            double x = minX;
            double sum = 0;
            double y, x2, b, X, area,h;
            double step = (maxX - minX) / intervalNumber;
            List<Interval> rectangles = new List<Interval>();

            do
            {
                x2 = x + step;
                b = x2 - x;
                X = x + (step/2) ;
                h =  f(X);
                area = b * h;
                sum += area;
                rectangles.Add(new Interval(x,x2, (int)(h*chart.viewPort.Height/chart.maxY)));
                x += step;
                

            } while (x2 <= maxX);

            this.labelRiemann.Text = sum.ToString();
            return rectangles;
        }

        public List<Interval> NaiveIntegralLebesgue(Func<double, double> f, double minY, double maxY, int intervalNumber, Charts chart)
        {
            double y = minY;
            double sum = 0;
            double x, y2, b, Y, area, h;
            double step = (maxY - minY) / intervalNumber;
            List<Interval> rectangles = new List<Interval>();

            do
            {
                y2 = y + step;
                h = y2 - y;
                Y = y + (step/2);
                b = maxX - f(Y);
                area = b * h;
                sum += area;
                rectangles.Add(new Interval(y, y2, (int)(f(Y) * chart.viewPort.Width / chart.maxX)));
                y += step;


            } while (y2 <= maxY);

            this.labelLebesgue.Text = sum.ToString();
            return rectangles;
        }



        private double function(double x)
        {
            return Math.Pow(x,2);
        }

        private double functionInverse(double y)
        {
            return Math.Sqrt(y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.g.Clear(Color.White);
            interval += interval;
            UpdateCharts();
            if (interval >= 1000)
            {
                interval = 5;
                timer1.Stop();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
