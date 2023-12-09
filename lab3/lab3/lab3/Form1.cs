using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        double percentage = 0.1;
        double result = 1.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double num3 = Convert.ToDouble(textBox3.Text);
            result = ((num1 + num2) / num3);
            textBox4.Text = result.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            percentage = 0.1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            percentage = 0.2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            percentage = 0.5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = (result * percentage).ToString();
        }
    }
}
