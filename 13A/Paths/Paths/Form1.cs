using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paths
{
    public partial class Form1 : Form
    {

        List<int> istrogramsX = new List<int>();
        public Charts chart = new Charts();
        Bitmap b;
        Graphics g;
        double N = 500;
        double maxY = 1;
        double minX = 0;
        double minY = 0;
        double p = 0.5;
        double M = 100;
        double epsilon = 0.01;

        public Form1()
        {



            InitializeComponent();
            inizializateChart();
            instogramXUpdate();



        }
        public void instogramXUpdate()
        {
            istrogramsX.Clear();
            istrogramsX.Add((int)(N - N/ 10));
            istrogramsX.Add((int)N / 5);
            istrogramsX.Add((int)N / 3);

        }

        public void inizializateChart()
        {
            N = (double)numericN.Value;
            M = (double)numericM.Value;
            epsilon = (double)numericEpsilon.Value;
            p = (double)numericP.Value;

            this.b = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            this.g = Graphics.FromImage(b);
            this.g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;


            //initialize the chart
            chart.minX = minX;
            chart.minY = minY;
            chart.maxX = N;
            chart.maxY = maxY;
            

            chart.viewPort = new Rectangle(50, 50, 1000, 400);

            this.g.Clear(Color.White);

            chart.histrogramYBrush = new SolidBrush(Color.FromArgb(190, Color.DarkRed));
            chart.histrogramPen.Color = Color.WhiteSmoke;

        }

        public void UpdateChart()
        {
            this.g.Clear(Color.White);

            //draw chart
            chart.DrawViewport(g);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.g.Clear(Color.White);
            Random colorRandom = new Random();
            
            Dictionary<int, Statistics> distributionCollection = new Dictionary<int, Statistics>();
            Dictionary<int, int> inEpsilon = new Dictionary<int, int>();
            Random random = new Random();
            for (int i = 0; i < M; i++)
            {
                
                List<DataPoint> points = new List<DataPoint>();
                Statistics s = new Statistics();
                
                for (int x = 0; x < N; x++)
                {
                    double b = Statistics.BearnoulliGenerator(random,p);
                    s.OnlineArithmeticMean(b);
                    double y = s.avg;
                    points.Add(new DataPoint(x, y));

                    if (y >= p - epsilon && y <= p + epsilon)
                    {
                        if (istrogramsX.Contains(x))
                        {
                            if (distributionCollection.ContainsKey(x))
                            {
                                distributionCollection[x].OnlineContinuosDistribution(y, 1);
                            }
                            else
                            {
                                Statistics sd = new Statistics();
                                sd.intervalDim = 0.01;
                                sd.initializeContinuosDistribution(new Interval(p- sd.intervalDim, p+ sd.intervalDim), sd.intervalDim);
                                sd.OnlineContinuosDistribution(y, 1);
                                distributionCollection.Add(x, sd);
                            }

                        
                            if (inEpsilon.ContainsKey(x))
                            {
                                inEpsilon[x]++;
                            }
                            else
                            {
                                inEpsilon.Add(x, 1);
                            }
                        }
                    }

                }


                Color randomColor = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                chart.linePen.Color = randomColor;
                chart.DrawLine(points, g);
                

            }



            chart.drawHorizzontalLine(p, "p", g);
            chart.drawHorizzontalLine(p + epsilon, "p + Ɛ", g);
            chart.drawHorizzontalLine(p - epsilon, "p - Ɛ", g);

            foreach (KeyValuePair<int, Statistics> kv in distributionCollection)
            {
                kv.Value.UpdateFreq();
                chart.DrawHorizzontalRectangles(kv.Value.distributionCont, kv.Key, g);

            }

            
            


            chart.drawFont = new Font("Arial", 10, FontStyle.Bold);
            foreach (KeyValuePair<int, int> kv in inEpsilon)
            {
                chart.drawLabel(kv.Key, p-0.2, kv.Value.ToString(), g);

            }
            chart.drawFont = new Font("Arial", 8, FontStyle.Regular);

            chart.DrawViewport(g);
            pictureBox1.Image = b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericM_ValueChanged(object sender, EventArgs e)
        {

            M = (double)numericM.Value;

        }

        private void numericN_ValueChanged(object sender, EventArgs e)
        {
            N = (double)numericN.Value;
            instogramXUpdate();
            chart.maxX = N;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericP_ValueChanged(object sender, EventArgs e)
        {

            p = (double)numericP.Value;
        }

        private void numericEpsilon_ValueChanged(object sender, EventArgs e)
        {

            epsilon = (double)numericEpsilon.Value;

        }
    }


}
