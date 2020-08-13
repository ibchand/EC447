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

namespace Lab3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		void calculate(int opp)
		{
			double inputVal = 0;
			double resultVal = 0;
			try
			{
				inputVal = Convert.ToDouble(textBox1.Text);
				resultVal = Convert.ToDouble(textBox2.Text);
				switch (opp)
				{
					case 2:
						resultVal = resultVal + inputVal; //ADDITION
						break;
					case 3:
						resultVal = resultVal - inputVal; //SUBTRACTION
						break;
					case 4:
						resultVal = resultVal * inputVal; //MULTIPLICATION
						break;
					case 5:
						resultVal = resultVal / inputVal; //DIVISION
						break;
				}
				if (Double.IsInfinity(resultVal))
					textBox2.Text = "\u221E";
				else
					textBox2.Text = resultVal.ToString("G", CultureInfo.InvariantCulture);
				textBox1.Text = string.Empty;
			}
			catch (Exception fe)
			{
				MessageBox.Show("Invalid or missing value!");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double inputVal = 0;
			try
			{
				inputVal = Convert.ToDouble(textBox1.Text);
				textBox2.Text = inputVal.ToString("G", CultureInfo.InvariantCulture);
				textBox1.Text = string.Empty;
			}
			catch (Exception fe)
			{
				MessageBox.Show("Invalid or missing value!");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//ADDITION
			calculate(2);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//SUBTRACTION
			calculate(3);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			//MULTIPLICATION
			calculate(4);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			//DIVISION
			calculate(5);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
