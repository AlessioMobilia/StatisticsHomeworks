using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticMeanCSharp
{
    public partial class Form1 : Form
    {
        Statistics stat = new Statistics();

        public Form1()
        {
            InitializeComponent();

            //inizialize textbox header
            this.TextBoxPeapleInfo.Text = "NAME".PadRight(10)+"| AGE".PadRight(6)+ "| COUNTRY"+"\n\n";
            this.TextBoxDistribution.Text = "COUNTRY".PadRight(10) + "|".PadRight(3) + "N. PEOPLES" + "\n\n";

        }

        private void buttonGemerate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <this.PeapleNumber.Value; i++)
            {
                Person p = RandomPerson.Generate();


                stat.OnlineArithmeticMean(p.personal.age); // update average

                //update peaple textbox
                this.TextBoxPeapleInfo.AppendText(p.personal.name.PadRight(10)+"| " + p.personal.age.ToString().PadRight(4) + "| " + p.personal.country + "\n");              
                this.TextBoxAvg.Text = " AVERAGE AGE:".PadRight(14)+stat.avg+ "\n" + "\n";
                
                
                stat.OnlineDistribution(p.personal.country, 1); //update distribution values


                //update distribution textbox
                string DistributionText = "COUNTRY".PadRight(10) + "|".PadRight(3) + "N. PEOPLES" + "\n\n";
                foreach (var d in stat.distribution)
                {
                    DistributionText += d.Key.PadRight(10) + "|".PadRight(3) + d.Value + "\n";
                }
                this.TextBoxDistribution.Text=DistributionText; //to avoid flickering i update the text box just one time for iteration

            }
            
            




        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clear variables
            stat = new Statistics();

            //clear text
            this.TextBoxAvg.Clear();
            //inizialize textbox header
            this.TextBoxPeapleInfo.Text = "NAME".PadRight(10) + "| AGE".PadRight(6) + "| COUNTRY" + "\n\n";
            this.TextBoxDistribution.Text = "COUNTRY".PadRight(10) + "|".PadRight(3) + "N. PEOPLES" + "\n\n";


        }
    }
}
