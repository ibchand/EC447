using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
	public partial class Form1 : Form
	{
		SettingsDialog dlg = new SettingsDialog();
		//public string outline { get; set; }
		//public string fill { get; set; }
		//public int width { get; set; }
		private int SetOut = 0;
		private int SetFill = 0;
		private int SetWidth = 0;
		private ArrayList Shapes = new ArrayList();
		private Point point_click_1 = new Point(-1,-1);
		private Point point_click_2 = new Point(-1,-1);
		private Point nullpoint = new Point(-1, -1);
		private int diameter = 10;

		public Form1()
		{
			InitializeComponent();
		}

		Point GetTopLeft(Point p1, Point p2, int width)
		{
			//Same
			if (p1 == p2)
				return p1;
			//p1 = TopLeft		p2 = BottomRight
			else if (p1.X < p2.X && p1.Y < p2.Y)
				return p1;
			//p1 = BottomRight	p2 = TopLeft
			else if (p1.X > p2.X && p1.Y > p2.Y)
				return p2;
			//p1 = BottomLeft	p2 = TopRight
			else if (p1.X < p2.X && p1.Y > p2.Y)
				return new Point(p2.X - width, p2.Y);
			//p1 = TopRight		p2 = BottomLeft
			else if (p1.X > p2.X && p1.Y < p2.Y)
				return new Point(p1.X - width, p1.Y);

			return p1; //Default
		}

		void GetSettings(ref Pen pen, ref Brush brush)
		{
			//Switch statement creates Pen by checking Outline/Pen color and taking the Width
			switch (SetOut)
			{
				case 0:
					pen = null;
					break;
				case 1:
					pen = new Pen(Brushes.Black, SetWidth);
					break;
				case 2:
					pen = new Pen(Brushes.Red, SetWidth);
					break;
				case 3:
					pen = new Pen(Brushes.Blue, SetWidth);
					break;
				case 4:
					pen = new Pen(Brushes.Green, SetWidth);
					break;
			}

			switch (SetFill)
			{
				case 0:
					brush = null;
					break;
				case 1:
					brush = Brushes.Black;
					break;
				case 2:
					brush = Brushes.Red;
					break;
				case 3:
					brush = Brushes.Blue;
					break;
				case 4:
					brush = Brushes.Green;
					break;
			}
		}

		private void set_btn_Click(object sender, EventArgs e)
		{
			dlg.ShowDialog();
			if (dlg.DialogResult == DialogResult.OK)
			{
				SetOut = dlg.lb_out.SelectedIndex;
				SetFill = dlg.lb_fill.SelectedIndex;
				SetWidth = dlg.lb_width.SelectedIndex + 1; //Index starts at 0, but width starts at 1, so add 1
			}
			//else
			//{
			//	dlg.lb_out.SelectedIndex = SetOut;
			//	dlg.lb_fill.SelectedIndex = SetFill;
			//	dlg.lb_width.SelectedIndex = SetWidth - 1;
			//}
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			if (point_click_1 != nullpoint)
				g.FillEllipse(Brushes.Black, point_click_1.X - diameter / 2, point_click_1.Y - diameter / 2, diameter, diameter);

			foreach (MyShape currShape in Shapes)
			{
				currShape.Draw(g);
			}
		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			//Either left or right click
			if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
			{
				if (point_click_1 == nullpoint)
				{
					point_click_1 = new Point(e.X, e.Y);
					panel2.Invalidate();
				}
				else //Second Click
				{
					point_click_2 = new Point(e.X, e.Y);
					//Now take settings and then create appropriate object and then add it to Shapes :)
					Pen pen = null;
					Brush brush = null;
					GetSettings(ref pen, ref brush);

					if (pen == null && brush == null)
					{
						MessageBox.Show("Fill and or pen/outline color must be selected.", "", MessageBoxButtons.OK);
						point_click_1 = nullpoint;
						panel2.Invalidate();
					}
					else
					{
						if (rb_line.Checked)
						{
							if (pen != null)
								Shapes.Add(new Line(pen, point_click_1, point_click_2));
						}
						else
						{
							int width = Math.Abs(point_click_1.X - point_click_2.X);
							int height = Math.Abs(point_click_1.Y - point_click_2.Y);
							Point TopLeft = GetTopLeft(point_click_1, point_click_2, width);
							Rectangle NewRect = new Rectangle(TopLeft.X, TopLeft.Y, width, height);

							if (rb_rect.Checked)
								Shapes.Add(new Rect(pen, brush, NewRect));
							else if (rb_elip.Checked)
								Shapes.Add(new Elip(pen, brush, NewRect));
						}
						panel2.Invalidate();
						point_click_1 = nullpoint;
					}
				}
			}
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Shapes.Clear();
			panel2.Invalidate();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Shapes.Count > 0)
			{
				Shapes.RemoveAt(Shapes.Count - 1);
				panel2.Invalidate();
			}
		}
	}
}
