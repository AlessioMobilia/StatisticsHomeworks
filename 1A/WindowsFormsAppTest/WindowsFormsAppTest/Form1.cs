using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        private Color originalColor;

        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "World";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }

        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
            originalColor = this.richTextBox1.BackColor;
            this.richTextBox1.BackColor = Color.Azure;
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {

            this.richTextBox1.BackColor = originalColor;
        }
    }
}
