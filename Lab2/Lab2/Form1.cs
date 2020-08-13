using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
	public partial class Form1 : Form
	{
		private int x = -1;
		private int y = -1;
		private ArrayList coordinates = new ArrayList();
		public Form1()
		{
			InitializeComponent();
		}

		//Override the base class OnPaint in this derived class
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			const int WIDTH = 15;
			const int HEIGHT = 15;
			Graphics g = e.Graphics;
			//https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics.drawline?view=dotnet-plat-ext-3.1#System_Drawing_Graphics_DrawLine_System_Drawing_Pen_System_Drawing_Point_System_Drawing_Point_
			//Used this documentation to help with drawing lines
			Pen blackPen = new Pen(Color.Black, 1);
			Point point1 = new Point(-1,-1);
			Point point2 = new Point(-1,-1);
			Point nullPoint = new Point(-1, -1);

			//If Show Lines is enabled, draw the lines between the dots
			if ((button1.Text).Equals("Hide Lines"))
			{
				foreach (Point p in this.coordinates)
				{
					if (point1 == nullPoint)
						point1 = p;
					else
					{
						point2 = p;
						g.DrawLine(blackPen, point1, point2);
						point1 = point2;
					}
				}
			}
			//Draw red circles
			foreach (Point p in this.coordinates)
				g.FillEllipse(Brushes.Red, p.X - WIDTH / 2, p.Y - HEIGHT / 2, WIDTH, HEIGHT);

		}

		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Point p = new Point(e.X, e.Y);
				this.coordinates.Add(p);
				this.Invalidate(); //Invalidate effectively tells Windows a region is no longer valid and needs to be updated, or "repainted"
			}
			else if (e.Button == MouseButtons.Right)
			{
				coordinates.Clear(); //Clear the ArrayList coordinates and then Invalidate so screen is cleared
				this.Invalidate();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if ((button1.Text).Equals("Show Lines"))
				button1.Text = "Hide Lines";
			else
				button1.Text = "Show Lines";
			this.Invalidate();
		}
	}
}
