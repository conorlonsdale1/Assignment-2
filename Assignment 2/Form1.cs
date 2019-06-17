using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, R5, seriesTotal, parallelTotal;
            try
            {
                R1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                R1 = 0;
            }
            try
            {
                R2 = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                R2 = 0;
            }
            try
            {
                R3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                R3 = 0;
            }
            try
            {
                R4 = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                R4 = 0;
            }
            try
            {
                R5 = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                R5 = 0;
            }
            seriesTotal = R1 + R2 + R3 + R4 + R5;
            label6.Text = "seriesTotal =" + seriesTotal;

            if (R1 == 0)
            {
                R1 = double.PositiveInfinity;
            }
            if (R2 == 0)
            {
                R2 = double.PositiveInfinity;
            }
            if (R3 == 0)
            {
                R3 = double.PositiveInfinity;
            }
            if (R4 == 0)
            {
                R4 = double.PositiveInfinity;
            }
            if (R5 == 0)
            {
                R5 = double.PositiveInfinity;
            }
            parallelTotal = 1 / (1/R1 + 1/R2 + 1/R3 + 1/R3 + 1/R4 + 1/R5);
            label7.Text = "parallel Total =" + parallelTotal;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
