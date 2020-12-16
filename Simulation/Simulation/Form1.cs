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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonGBM_Click(object sender, EventArgs e)
        {

            GeometricBrownianMotion Form = new GeometricBrownianMotion();
            Form.Show();

        }

        private void buttonOU_Click(object sender, EventArgs e)
        {
            Ornstain Form = new Ornstain();
            Form.Show();
        }

        private void buttonPoisson_Click(object sender, EventArgs e)
        {
            Poisson Form = new Poisson();
            Form.Show();
        }

        private void buttonBM_Click(object sender, EventArgs e)
        {
            BrownianMotion Form = new BrownianMotion();
            Form.Show();
        }

        private void buttonMean_Click(object sender, EventArgs e)
        {
            Cantelli Form = new Cantelli();
            Form.Show();
        }
    }
}
