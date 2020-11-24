using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantelli
{
    public partial class Form1 : Form
    {

        public Charts chart = new Charts();
        Bitmap b;
        Graphics g;

        public double range = 80;
        public int nValues = 1;
        public int nSamples = 50;
        public Form1()
        {
            InitializeComponent();
            inizializateChart();
        }

        private Dictionary<double,double> CDF(Statistics means,double step, double min, double max)
        {
            
            double x = min;
            Dictionary<double, double> points = new Dictionary<double, double>();
            
            do
            {
                double sum = 0;
                x += step;
                foreach(Interval m in means.distributionCont)
                {
                    if (m.end <= x)
                    {
                        sum += m.freq;
                    }

                }
                points.Add(x,sum);
               
            } while(x<max);

            return points;
        }

        public void inizializateChart()
        {

            this.b = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            this.g = Graphics.FromImage(b);
            this.g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;


            //initialize the chart
            chart.minX = 0;
            chart.minY = 0;
            chart.maxX = range;
            chart.maxY = 1;


            chart.viewPort = new Rectangle(50, 50, 800, 400);

            this.g.Clear(Color.White);

            //chart.histrogramYBrush = new SolidBrush(Color.FromArgb(190, Color.DarkRed));
            chart.histrogramPen.Color = Color.DarkSeaGreen;

        }

        public void UpdateChart()
        {


            this.g.Clear(Color.White);
            Random random = new Random();
            List<Statistics> samples = new List<Statistics>();
            for (int j = 0; j < nSamples; j++)
            {
                Statistics stat = new Statistics();
                for (int i = 0; i < nValues; i++)
                {
                    double value = Statistics.UniformGenerator(random, range);
                    stat.intervalDim = 1;
                    stat.OnlineContinuosDistribution(value, 1);
                    stat.OnlineArithmeticMean(value);
                }
                samples.Add(stat);
            }

            Statistics st = new Statistics();
            foreach (Statistics s in samples)
            {

                st.intervalDim = 1;
                st.OnlineContinuosDistribution(s.avg, 1);
                st.OnlineArithmeticMean(s.avg);
            }

            st.UpdateFreq();
            double avg = st.avg;

            Dictionary<double, double> points = CDF(st, 1, 0, range);

            
            chart.DrawHistogram(st.distributionCont, g);
            chart.DrawLadder(points, g);
            chart.DrawViewport(g);
            chart.DrawAxis(g);
            chart.drawXLabel(4, g);
            chart.drawYLabel(0.1, g);

            pictureBox1.Image = b;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            UpdateChart();
            nValues += 2* nValues;
            if (nValues>= 400)
            {
                timer1.Stop();
                nValues = 1;
            }
        }
    }
}
