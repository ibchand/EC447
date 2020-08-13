using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Size = new System.Drawing.Size(400, 550);
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			int val_1 = 0;
			int val_2 = 1;
			int val_3 = 0;
			int Height = Font.Height;
			string str;
			g.DrawString("Ibrahim Chand", Font, Brushes.Black, 100, 20);
			str = String.Format("{0}   {1}", 1, val_2);
			g.DrawString(str, Font, Brushes.Black, 100, 40+Height);
			for (int i = 2; i < 31; i++)
			{
				val_3 = val_1 + val_2;
				str = String.Format("{0}   {1}", i, val_3);
				val_1 = val_2;
				val_2 = val_3;
				g.DrawString(str, Font, Brushes.Black, 100, 40 + (Height * i));
			}
		}
	}
}
