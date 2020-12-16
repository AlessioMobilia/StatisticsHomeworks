using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation
{
    public partial class GeometricBrownianMotion : Form
    {
        List<int> istrogramsX = new List<int>();
        public Charts chart = new Charts();
        public Charts Histogram1 = new Charts();
        public Charts Histogram2 = new Charts();
        Bitmap b;
        Graphics g;
        double N = 1000;
        double maxY = 100;
        double minX = 0;
        double minY = -10;

        double M = 100;
        double deltaT;
        double sigma = 0.5;
        //double epsilon = 0.01;

        public GeometricBrownianMotion()
        {
            InitializeComponent();
            inizializateChart();
            instogramXUpdate();
            sigma = (double)numericSigma.Value;
            deltaT = 1 / N;
        }

        public void instogramXUpdate()
        {
            istrogramsX.Clear();
            istrogramsX.Add((int)(N - N / 10));
            istrogramsX.Add((int)N / 5);
            istrogramsX.Add((int)N / 3);

        }

        public void inizializateChart()
        {
            //N = (double)numericN.Value;
            //M = (double)numericM.Value;
            //epsilon = (double)numericEpsilon.Value;
            //lambda = (double)numericL.Value;

            this.b = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            this.g = Graphics.FromImage(b);
            this.g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;


            //initialize the chart
            chart.minX = minX;
            chart.minY = minY;
            chart.maxX = N;
            chart.maxY = maxY;


            Histogram1.minX = 1;
            Histogram1.minY = minY;
            Histogram1.maxX = maxY;
            Histogram1.maxY = 100000;


            Histogram2.minX = 1;
            Histogram2.minY = maxY;
            Histogram2.maxX = 5;
            Histogram2.maxY = 100000;


            Histogram1.viewPort = new Rectangle(50, 50, 200, 100);
            Histogram2.viewPort = new Rectangle(280, 50, 200, 100);
            chart.viewPort = new Rectangle(50, 50, 800, 400);

            this.g.Clear(Color.White);

            chart.histrogramYBrush = new SolidBrush(Color.FromArgb(190, Color.DarkRed));
            chart.histrogramPen.Color = Color.WhiteSmoke;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            inizializateChart();
            this.g.Clear(Color.White);
            Random colorRandom = new Random();

            Dictionary<int, Statistics> distributionCollection = new Dictionary<int, Statistics>();
            //Dictionary<int, int> inEpsilon = new Dictionary<int, int>();
            Statistics distanceFromOStat = new Statistics();
            Statistics distanceFromPrevStat = new Statistics();
            Random random = new Random();

            for (int i = 0; i < M; i++)
            {

                List<DataPoint> points = new List<DataPoint>();
                Statistics s = new Statistics();

                distanceFromPrevStat.intervalDim = 1;
                distanceFromOStat.intervalDim = 12;
                double y = 10;
                double jump;

                for (int x = 0; x < N; x++)
                {
                    if (x > 0)
                    {
                        jump = Statistics.GaussianGenerator(random, y * sigma * deltaT, y * sigma * Math.Sqrt(deltaT));
                        y += jump;



                    }




                    points.Add(new DataPoint(x, y));

                    if (istrogramsX.Contains(x))
                    {
                        if (distributionCollection.ContainsKey(x))
                        {
                            distributionCollection[x].OnlineContinuosDistribution(y, 1);
                        }
                        else
                        {
                            Statistics sd = new Statistics();
                            sd.intervalDim = 2;
                            sd.initializeContinuosDistribution(new Interval(0, sd.intervalDim), sd.intervalDim);
                            sd.OnlineContinuosDistribution(y, 1);
                            distributionCollection.Add(x, sd);
                        }
                    }

                }


                Color randomColor = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                chart.linePen.Color = randomColor;
                chart.DrawLine(points, g);


            }


            distanceFromOStat.UpdateFreq();
            distanceFromPrevStat.UpdateFreq();
            //Histogram1.DrawViewport(g);
            //Histogram2.DrawViewport(g);
            //Histogram1.DrawHistogram(distanceFromOStat.distributionCont, g);
            //Histogram2.DrawHistogram(distanceFromPrevStat.distributionCont, g);




            foreach (KeyValuePair<int, Statistics> kv in distributionCollection)
            {
                kv.Value.UpdateFreq();
                chart.DrawHorizzontalRectangles(kv.Value.distributionCont, kv.Key, g);

            }





            chart.drawFont = new Font("Arial", 10, FontStyle.Bold);
            chart.drawFont = new Font("Arial", 8, FontStyle.Regular);

            chart.DrawViewport(g);
            chart.DrawAxis(g);

            pictureBox1.Image = b;

        }

        private void numericSigma_ValueChanged(object sender, EventArgs e)
        {
            sigma = (double)numericSigma.Value;
        }
    }
}
