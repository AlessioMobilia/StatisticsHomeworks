using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaiveArithmeticMean
{
    public partial class Form1 : Form
    {
        public List<List<Double>> datasetlist = new List<List<Double>>();
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonTest1_Click(object sender, EventArgs e)
        {
            this.TextBoxResult.AppendText("----------------------------------------------\n");
            this.TextBoxResult.AppendText("TEST 1\n");
            List < Double > dataset = new List<Double>();

            dataset.Add(20);
            dataset.Add(20);

            PrintTest(dataset);
            
            
        }



        private void button2_Click(object sender, EventArgs e)
        {

            this.TextBoxResult.AppendText("----------------------------------------------\n");
            this.TextBoxResult.AppendText("TEST 2\n");
            List<Double> dataset = new List<Double>();

            dataset.Add(1E300);
            dataset.Add(10);
            dataset.Add(10);
            dataset.Add(-1E300);

            PrintTest(dataset);

        }



        private void button3_Click(object sender, EventArgs e)
        {

            this.TextBoxResult.AppendText("----------------------------------------------\n");
            this.TextBoxResult.AppendText("TEST 3\n");
            List<Double> dataset = new List<Double>();

            dataset.Add(10.2);
            dataset.Add(-10.1);

            PrintTest(dataset);

        }




        private void button4_Click(object sender, EventArgs e)
        {

            this.TextBoxResult.AppendText("----------------------------------------------\n");
            this.TextBoxResult.AppendText("TEST 4\n");
            List<Double> dataset = new List<Double>();

            dataset.Add(1.0);
            dataset.Add(1.110223E-16);
            dataset.Add(-1.110223E-16);

            PrintTest(dataset);



        }



        private void button5_Click(object sender, EventArgs e)
        {


            this.TextBoxResult.AppendText("----------------------------------------------\n");
            this.TextBoxResult.AppendText("TEST 4\n");
            List<Double> dataset = new List<Double>();

            dataset.Add(10000.0);
            dataset.Add(3.14159);
            dataset.Add(2.71828);

            PrintTest(dataset);

        }






        private void PrintTest(List<double> dataset)
        {
            this.TextBoxResult.Clear();

            this.TextBoxResult.AppendText("------------ NAIVE ------------\n");
            double count = 0;
            foreach (double data in dataset)
            {
                count++;
                this.TextBoxResult.AppendText("n. " + count.ToString().PadRight(10) + data.ToString() + "\n");
            }
            double avg = Statistics.NaiveArithmeticMean(dataset);
            double sum = Statistics.NaiveSum(dataset);
            this.TextBoxResult.AppendText("\n");           
            this.TextBoxResult.AppendText("Sum".PadRight(13) + sum + "\n");
            this.TextBoxResult.AppendText("Mean".PadRight(13) + avg + "\n");
            this.TextBoxResult.AppendText("------------------------\n");



            this.TextBoxResult.AppendText("------------ KNUTH ------------\n");
            count = 0;
            Statistics stat = new Statistics();
            foreach (double data in dataset)
            {
                count++;
                this.TextBoxResult.AppendText("n. " + count.ToString().PadRight(10) + data.ToString() + "\n");
                stat.OnlineArithmeticMean(data);
            }
            avg = stat.avg;
            this.TextBoxResult.AppendText("\n");
            this.TextBoxResult.AppendText("Mean".PadRight(13) + avg + "\n");
            this.TextBoxResult.AppendText("------------------------\n");



            this.TextBoxResult.AppendText("------------ KAHAN ------------\n");
            count = 0;
            foreach (double data in dataset)
            {
                count++;
                this.TextBoxResult.AppendText("n. " + count.ToString().PadRight(10) + data.ToString() + "\n");
            }
            avg = Statistics.KahanArithmeticMean(dataset);
            sum = Statistics.KahanSum(dataset);
            this.TextBoxResult.AppendText("\n");
            this.TextBoxResult.AppendText("Sum".PadRight(13) + sum + "\n");
            this.TextBoxResult.AppendText("Mean".PadRight(13) + avg + "\n");
            this.TextBoxResult.AppendText("------------------------\n");


            this.TextBoxResult.AppendText("------------ NEUMAIER ------------\n");
            count = 0;
            foreach (double data in dataset)
            {
                count++;
                this.TextBoxResult.AppendText("n. " + count.ToString().PadRight(10) + data.ToString() + "\n");
            }
            avg = Statistics.NeumaierArithmeticMean(dataset);
            sum = Statistics.NeumaierSum(dataset);
            this.TextBoxResult.AppendText("\n");
            this.TextBoxResult.AppendText("Sum".PadRight(13) + sum + "\n");
            this.TextBoxResult.AppendText("Mean".PadRight(13) + avg + "\n");
            this.TextBoxResult.AppendText("------------------------\n");




            this.TextBoxResult.AppendText("------------ ARRAY METHODS ------------\n");
            count = 0;
            foreach (double data in dataset)
            {
                count++;
                this.TextBoxResult.AppendText("n. " + count.ToString().PadRight(10) + data.ToString() + "\n");
            }
            var arr = dataset.ToArray();
            avg = arr.Average();
            sum = arr.Sum();
            this.TextBoxResult.AppendText("\n");
            this.TextBoxResult.AppendText("Sum".PadRight(13) + sum + "\n");
            this.TextBoxResult.AppendText("Mean".PadRight(13) + avg + "\n");
            this.TextBoxResult.AppendText("------------------------\n");




        }




    }
}
