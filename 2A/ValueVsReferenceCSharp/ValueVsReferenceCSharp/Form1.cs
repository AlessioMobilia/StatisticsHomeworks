using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueVsReferenceCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            number = 1111111;
            Overwirite(number);
            this.richTextBox1.AppendText(number.ToString() + "\n");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Student a = new Student();
            a.name = "Pippo";
            Overwirite(a);
            this.richTextBox1.AppendText(a.name + "\n");
        }


        private void Overwirite(int var)
        {
            var = 999999999;
        }

        static void Overwirite(Student var)
        {
            var.name = "9999999";
        }

        private class Student
        {
            public string name;
        }
    }
}
