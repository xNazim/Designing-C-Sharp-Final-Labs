using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int operation = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            String result;
            if (operation == 1)
            {
                result = (num1 + num2).ToString();
            }
            else if (operation == 2)
            {
                result = (num1 - num2).ToString();
            }
            else if (operation == 3)
            {
                result = (num1 * num2).ToString();
            }
            else {
                result = (num1 / num2).ToString();
            }
            textBox3.Text = result;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                changeRadios(1);
                operation = 1;
            }
        }

        private void changeRadios(int n) {
            if (n != 1) {
                radioButton1.Checked = false;
            }
            if (n != 2) {
                radioButton2.Checked = false;
            }
            if (n != 3) {
                radioButton3.Checked = false;
            }
            if (n != 4) {
                radioButton4.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                changeRadios(2);
                operation = 2;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                changeRadios(3);
                operation = 3;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                changeRadios(4);
                operation = 4;
            }
        }
    }
}
