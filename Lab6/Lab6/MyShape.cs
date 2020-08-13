using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class MyShape
	{
		public Pen pen { get; set; } //Used in Line and when there's an outline for Rect and Elip
		public Brush brush { get; set; } //Only used when there's a fill for Rect and Elip
		public Point point1 { get; set; } //Only needed for Line
		public Point point2 { get; set; } //Only needed for Line
		public Rectangle rectangle { get; set; } //Only needed for Rect and Elip

		public virtual void Draw(Graphics g_in)
		{

		}
	}

	class Line : MyShape
	{
		public Line(Pen pen_in, Point point1_in, Point point2_in)
		{
			pen = pen_in;
			point1 = point1_in;
			point2 = point2_in;
		}

		public override void Draw(Graphics g_in)
		{
			base.Draw(g_in);
			g_in.DrawLine(pen, point1, point2);
		}
	}

	class Rect : MyShape
	{
		public Rect(Pen pen_in, Brush brush_in, Rectangle rectangle_in)
		{
			pen = pen_in;
			brush = brush_in;
			rectangle = rectangle_in;
		}

		public override void Draw(Graphics g_in)
		{
			base.Draw(g_in);
			if (brush != null)
				g_in.FillRectangle(brush, rectangle);
			if (pen != null)
				g_in.DrawRectangle(pen, rectangle);
		}
	}

	class Elip : MyShape
	{
		public Elip(Pen pen_in, Brush brush_in, Rectangle rectangle_in)
		{
			pen = pen_in;
			brush = brush_in;
			rectangle = rectangle_in;
		}

		public override void Draw(Graphics g_in)
		{
			base.Draw(g_in);
			if (brush != null)
				g_in.FillEllipse(brush, rectangle);
			if (pen != null)
				g_in.DrawEllipse(pen, rectangle);
		}
	}
}
