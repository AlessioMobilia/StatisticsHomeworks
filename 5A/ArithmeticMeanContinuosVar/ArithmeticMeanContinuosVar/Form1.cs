using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticMeanContinuosVar
{
    public partial class Form1 : Form
    {
        Statistics stat = new Statistics();
        public Form1()
        {
            InitializeComponent();
            //inizialize textbox header
            this.TextBoxPeaple.Text = "NAME".PadRight(10) + "| HEIGHT".PadRight(6) + "\n\n";
            this.TextBoxDistribution.Text = "  RANGE HEIGHT".PadRight(16) + "|".PadRight(3) + "N." + "  | ".PadRight(4) + "FREQ.  | ".PadRight(4) + "PERC." + "\n\n";
            interval range = new interval(1.7, 1.8);
            stat.initializeContinuosDistribution(range,0.1);

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.personNumber.Value; i++)
            {
                Person p = RandomPerson.Generate();
                double height = Double.Parse(p.personal.height, CultureInfo.InvariantCulture);


                stat.OnlineArithmeticMean(height); // update average

                //update peaple textbox
                this.TextBoxPeaple.AppendText(p.personal.name.PadRight(10) + "| " + height.ToString("0.00").PadRight(4) + "\n");
                this.TextBoxAvg.Text = " AVERAGE HEIGHT:".PadRight(14) + stat.avg + "\n\n";


                stat.OnlineContinuosDistribution(height, 1);

                //update distribution textbox
                string DistributionText = "  RANGE HEIGHT".PadRight(16) + "|".PadRight(3) + "N." + "  | ".PadRight(4) + "FREQ.  | ".PadRight(4) + "PERC." + "\n\n";
                foreach (var d in stat.distributionCont)
                {
                    DistributionText += "[".PadRight(1) + d.start.ToString("0.00").PadRight(5)+  " -".PadRight(5) + d.end.ToString("0.00").PadRight(3) + ")".PadRight(1) + "|".PadRight(3) + d.value.ToString().PadRight(2) + "  | "+ d.freq.ToString("0.00").PadRight(6) + " | " + d.perc.ToString("0.00").PadRight(6) + " %\n";
                }
                this.TextBoxDistribution.Text = DistributionText; //to avoid flickering i update the text box just one time for iteration

            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            //clear variables
            stat = new Statistics();

            //clear text
            this.TextBoxAvg.Clear();
            //inizialize textbox header
            this.TextBoxPeaple.Text = "NAME".PadRight(10) + "| AGE".PadRight(6) + "| COUNTRY" + "\n\n";
            this.TextBoxDistribution.Text = "  RANGE HEIGHT".PadRight(16) + "|".PadRight(3) + "N." + "  | ".PadRight(4) + "FREQ.  | ".PadRight(4) + "PERC." + "\n\n";

            //initialize distribution again
            interval range = new interval(1.7, 1.8);
            stat.initializeContinuosDistribution(range, 0.1);


        }

        private void personNumber_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
