using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Simulation
{
    public class Interval
    {
        public Interval() { }
        public Interval(double start, double end)
        {
            this.start = start;
            this.end = end;
        }




        public double start { get; set; }
        public double trueMean { get; set; }
        public double end { get; set; }
        public int value { get; set; } = 0;
        public double freq { get; set; } = 0;
        public double perc { get; set; } = 0;


    }



    class Statistics
    {
        public int total { get; private set; } = 0;
        public double avg { get; private set; } = 0.0;
        public int count { get; private set; } = 0;
        public Dictionary<string, int> distribution { get; private set; } = new Dictionary<string, int>();
        public List<Interval> distributionCont { get; private set; } = new List<Interval>();
        public double intervalDim { get; set; } = 5;

        public double median = 0;

        private List<double> maxHeap = new List<double>();
        private List<double> minHeap = new List<double>();


        public void OnlineArithmeticMean(double number)
        {
            this.count++;
            this.avg = (this.avg * (count - 1) + number) / count;
        }

        public static int BernoulliGenerator(Random random, double p = 0.5)
        {

            return random.NextDouble() >= p ? 0 : 1;

        }
        public static double UniformGenerator(Random random, double range = 50)
        {
            return random.NextDouble() * range + 1;
        }

        public static double GaussianGenerator(Random random, double mean, double stddev)
        {
            // The method requires sampling from a uniform random of (0,1]
            // but Random.NextDouble() returns a sample of [0,1).
            double x1 = 1 - random.NextDouble();
            double x2 = 1 - random.NextDouble();

            double y1 = Math.Sqrt(-2.0 * Math.Log(x1)) * Math.Cos(2.0 * Math.PI * x2);
            return y1 * stddev + mean;
        }

        public void OnlineMedian(double element)
        {
            if (maxHeap.Count == 0)
            {
                maxHeap.Add(element);
            }
            else
            {
                if (element < maxHeap[0])
                {
                    maxHeap.Add(element);
                }
                else
                {
                    if (element < minHeap[0])
                    {
                        minHeap.Insert(0, element);
                    }
                    else
                    {
                        minHeap.Add(element);
                    }

                }
            }

            while (Math.Abs(maxHeap.Count - minHeap.Count) > 1)
            {
                if (maxHeap.Count > minHeap.Count)
                {
                    double root = maxHeap[0];
                    maxHeap.RemoveAt(0);
                    minHeap.Add(root);
                }
                else
                {
                    double root = minHeap[0];
                    minHeap.RemoveAt(0);
                    maxHeap.Add(root);
                }
            }

            if (maxHeap.Count == minHeap.Count)
            {
                this.median = maxHeap[0] + minHeap[0] / 2;
            }
            else if (maxHeap.Count > minHeap.Count)
            {
                this.median = maxHeap[0];
            }
            else
            {
                this.median = minHeap[0];
            }

        }



        public void OnlineDistribution(string key, int value)
        {
            if (distribution.ContainsKey(key))
            {
                distribution[key] += value;
            }
            else
            {
                distribution.Add(key, value);
            }


        }

        public double[] CalcDisctreteFreq()
        {
            double[] freq = new double[distribution.Count];
            double total = 0.0;
            foreach (KeyValuePair<string, int> kv in distribution)
            {
                total += kv.Value;
            }

            int i = 0;
            foreach (KeyValuePair<string, int> kv in distribution)
            {
                freq[i] = kv.Value / total;
                i++;
            }

            return freq;
        }

        public double[] CalcDisctretePerc()
        {
            double[] perc = new double[distribution.Count];
            double total = 0.0;
            foreach (KeyValuePair<string, int> kv in distribution)
            {
                total += kv.Value;
            }

            int i = 0;
            foreach (KeyValuePair<string, int> kv in distribution)
            {
                perc[i] = (kv.Value * 100) / total;
                i++;
            }

            return perc;
        }

        //initialize the distribution
        public void initializeContinuosDistribution(Interval range, double interval)
        {

            this.intervalDim = interval;
            this.distributionCont.Clear();
            total = range.value;
            range.freq = 1.0;
            range.perc = 100.0;
            this.distributionCont.Add(range);

        }


        public void UpdateFreq()
        {
            //update freq and perc
            foreach (Interval i in distributionCont)
            {
                i.freq = i.value / (double)this.total;
                i.perc = i.freq * 100.00;
            }
        }

        static public List<int[]> ContingencyTable(List<Interval> distributionX, List<Interval> distributionY)
        {
            List<int[]> contingency = new List<int[]>();
            int[] sumX = new int[distributionX.Count];
            int[] sumY = new int[distributionY.Count];
            for (int i = 0; i < distributionX.Count; i++)
            {
                contingency.Add(new int[distributionY.Count + 1]);
                for (int j = 0; j < distributionY.Count; j++)
                {
                    contingency[i][j] = Math.Min(distributionY[j].value, distributionX[i].value);
                    sumX[i] += contingency[i][j];
                    sumY[j] += contingency[i][j];
                }

            }
            for (int i = 0; i < distributionX.Count; i++)
            {
                contingency[i][distributionY.Count] = sumX[i];

            }
            contingency.Add(new int[distributionY.Count + 1]);
            for (int j = 0; j < distributionY.Count; j++)
            {
                contingency[distributionX.Count][j] = sumY[j];
            }

            return contingency;

        }

        // interval [start, end)
        public void OnlineContinuosDistribution(double value, int step)
        {

            Interval range = new Interval();

            this.total += step;
            if (distributionCont.Count == 0) //if the distribution is not initialized then it will be initialized
            {
                range.start = Math.Round(value, MidpointRounding.AwayFromZero);
                range.end = range.start + intervalDim;
                range.value = step;
                this.initializeContinuosDistribution(range, this.intervalDim);
                //Debug.WriteLine("inizialization");
            }
            else
            {


                int q;
                int p = 0; //first index
                int r = distributionCont.Count - 1; //last index

                if (value < distributionCont[p].start)  //add value before the list
                {
                    do
                    {
                        range = new Interval();
                        range.end = distributionCont[p].start;
                        range.start = Math.Round(distributionCont[p].start - intervalDim, 2);
                        if (range.start <= value)
                            range.value = step;
                        else
                            range.value = 0;
                        distributionCont.Insert(0, range);
                        r++;
                        //Debug.WriteLine("add range before");
                    } while (range.start > value);



                }

                else if (value >= distributionCont[r].end) //add value after the list
                {
                    do
                    {

                        range = new Interval();
                        range.start = distributionCont[r].end;
                        range.end = Math.Round(distributionCont[r].end + intervalDim, 2);
                        if (range.end > value)
                            range.value = step;
                        else
                            range.value = 0;
                        distributionCont.Add(range);
                        r++;
                        //Debug.WriteLine("add range after");
                    } while (range.end <= value);
                }



                else // search in the list with a binary search
                {

                    //Debug.WriteLine("search in list");
                    while (p <= r)
                    {
                        q = (p + r) / 2;
                        if (distributionCont[q].end > value)
                        {
                            if (distributionCont[q].start <= value)
                            {
                                distributionCont[q].value += step;
                                distributionCont[q].freq = distributionCont[q].value / this.total;
                                break;
                            }
                            else
                                r = q - 1;
                        }
                        else
                            p = q + 1;
                    }


                }



            }

            range.trueMean += value / range.value;


        }




    }
}
