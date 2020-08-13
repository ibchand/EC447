using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			//Creates 2D array of Rect objects and assigns value for initial state (White/Black Checkboard and Positioning)
			for (int i = 0; i < 8; i++)
			{
				int yCord = 100 + (i * HEIGHT); //y-Coordinate position of Square
				for (int j = 0; j < 8; j++)
				{
					int xCord = 100 + (j * WIDTH); //x-Coordiante position of Square
					Brush brush;
					if ((i + j) % 2 == 0) //If Even
						brush = Brushes.White; //White Square
					else //If odd
						brush = Brushes.Black; //White Square
					Rectangle newRect = new Rectangle(xCord, yCord, WIDTH, HEIGHT); //Creates a new rectangle at xCord and yCord
					rects[i, j] = new Rect(brush, newRect, Rect.State.Open); //Adds the new rectangle we made to rects array with correct brush
				}
			}
			//What I mean by If Even or If Odd is that the white square i+j values are even and black squares are odd. I use that to determine Brush color. 

			label1.Text = "You have " + QueenCount.ToString() + " queens on the board.";
		}

		void checkBlocked(int i, int j)
		{
			//Column
			for (int y = 0; y < 8; y++)
				rects[i, y].blockCount++;
			//Row
			for (int x = 0; x < 8; x++)
				rects[x, j].blockCount++;

			//DIAGONALS
			int row = i;
			int col = j;
			//Bottom Right
			while (row < 8 && row >= 0 && col < 8 && col >= 0)
			{
				rects[row, col].blockCount++;
				row++; col++;
			}
			row = i;
			col = j;
			//Top Right
			while (row < 8 && row >= 0 && col < 8 && col >= 0)
			{
				rects[row, col].blockCount++;
				row--; col++;
			}
			row = i;
			col = j;
			//Bottom Left
			while (row < 8 && row >= 0 && col < 8 && col >= 0)
			{
				rects[row, col].blockCount++;
				row++; col--;
			}
			row = i;
			col = j;
			//Top Left
			while (row < 8 && row >= 0 && col < 8 && col >= 0)
			{
				rects[row, col].blockCount++;
				row--; col--;
			}

			//rects[i, j].blockCount -= 5;
			//label1.Text = rects[i, j].blockCount.ToString();
		}

		void unBlock(int i, int j)
		{
			//Column
			for (int y = 0; y < 8; y++)
				rects[i, y].blockCount--;
			//Row
			for (int x = 0; x < 8; x++)
				rects[x, j].blockCount--;

			//DIAGONALS
			int row = i;
			int col = j;
			//Bottom Right
			while (row < 8 && row >= 0 && col < 8 && col >= 0)
			{
				rects[row, col].blockCount--;
				row++; col++;
			}
			row = i;
			col = j;
			//Top Right
			while (row < 8 && row >= 0 && col < 8 && col >= 0)
			{
				rects[row, col].blockCount--;
				row--; col++;
			}
			row = i;
			col = j;
			//Bottom Left
			while (row < 8 && row >= 0 && col < 8 && col >= 0)
			{
				rects[row, col].blockCount--;
				row++; col--;
			}
			row = i;
			col = j;
			//Top Left
			while (row < 8 && row >= 0 && col < 8 && col >= 0)
			{
				rects[row, col].blockCount--;
				row--; col--;
			}

			//rects[i, j].blockCount += 5;
			//label1.Text = rects[i, j].blockCount.ToString();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics g = e.Graphics;

			//Create a pen for border of rectangles
			Pen pen = new Pen(Color.Black, 1);
			pen.Alignment = PenAlignment.Inset;

			//Formatting for the string to be vertically and horizontally centered in the rectangle
			StringFormat drawFormat = new StringFormat();
			drawFormat.Alignment = StringAlignment.Center;
			drawFormat.LineAlignment = StringAlignment.Center;

			Font font1 = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);

			if (checkBox1.Checked) //If Hint are On
			{
				for (int i = 0; i < 8; i++) //Rows
				{
					for (int j = 0; j < 8; j++) //Columns
					{
						Rect currRect = rects[i, j];

						if (currRect.blockCount > 0)
						{
							g.FillRectangle(Brushes.Red, currRect.Rectangle); //Draws Square
							g.DrawRectangle(pen, currRect.Rectangle); //Adds Rectangle

							//Adding Letter Q
							if (currRect.state == Rect.State.Queen)
								g.DrawString("Q", font1, Brushes.Black, currRect.Rectangle, drawFormat);
						}
						else
						{
							g.FillRectangle(rects[i, j].Brush, currRect.Rectangle); //Draws Square
							g.DrawRectangle(pen, currRect.Rectangle); //Adds Rectangle

							//Adding Letter Q - Note: Adding a Queen here isn't necessary as we know it's blocked
							//if (currRect.state == Rect.State.Queen)
							//{
							//	if (currRect.Brush == Brushes.White)
							//		g.DrawString("Q", font1, Brushes.Black, currRect.Rectangle, drawFormat);
							//	else
							//		g.DrawString("Q", font1, Brushes.White, currRect.Rectangle, drawFormat);
							//}
						}
					}
				}
			}
			else //If Hints are Off
			{
				for (int i = 0; i < 8; i++) //Rows
				{
					for (int j = 0; j < 8; j++) //Columns
					{
						Rect currRect = rects[i, j];
						g.FillRectangle(rects[i, j].Brush, currRect.Rectangle); //Draws Square
						g.DrawRectangle(pen, currRect.Rectangle); //Adds Rectangle

						//Adding Letter Q
						if (currRect.state == Rect.State.Queen)
						{
							if (currRect.Brush == Brushes.White)
								g.DrawString("Q", font1, Brushes.Black, currRect.Rectangle, drawFormat);
							else
								g.DrawString("Q", font1, Brushes.White, currRect.Rectangle, drawFormat);
						}
					}
				}
			}
			label1.Text = "You have " + QueenCount.ToString() + " queens on the board.";
		}

		protected override void OnMouseClick(MouseEventArgs e)
		{
			base.OnMouseClick(e);
			Point p = new Point(e.X, e.Y);
			for (int i = 0; i < 8; i++) //Rows
			{
				for (int j = 0; j < 8; j++) //Columns
				{
					Rect currRect = rects[i, j];
					if (currRect.Rectangle.Contains(p))
					{
						if (e.Button == MouseButtons.Left)
						{
							if (currRect.state == Rect.State.Open && currRect.blockCount == 0) //If it's open, then change state to Queen, checkBlocked, and invalidate()
							{
								currRect.state = Rect.State.Queen;
								QueenCount++;
								if (QueenCount == 8)
								{
									//victoryDialog dlg = new victoryDialog(); //Instantiates dialog
									//dlg.ShowDialog(); //Shows the dialog
									MessageBox.Show("You did it!");
								}
								checkBlocked(i, j);
								this.Invalidate();
							}
							else System.Media.SystemSounds.Beep.Play(); //If there's already a Queen or it's blocked, play this sound
						}
						else if (e.Button == MouseButtons.Right)
						{
							if (currRect.state == Rect.State.Queen)
							{
								currRect.state = Rect.State.Open;
								QueenCount--;
								unBlock(i, j);
								this.Invalidate();
							}
						}
					}
				}
			}
		}


		private void button1_Click(object sender, EventArgs e)
		{
			//Clear - Set all Rect in rects to be Open and blockCount of 0
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					Rect currRect = rects[i, j];
					currRect.blockCount = 0;
					currRect.state = Rect.State.Open;
				}
			}
			QueenCount = 0;
			this.Invalidate();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.Invalidate();
		}

		private Rect[,] rects = new Rect[8, 8]; //Creates a 2D array of Rectangles
		private const int WIDTH = 50;
		private const int HEIGHT = 50;
		private int QueenCount = 0;

		//private int X = 100; //Starting X Coordinate
		//private int Y = 100; //Starting Y Coordinate
	}

	public class Rect
	{
		public Brush Brush { get; set; }
		public Rectangle Rectangle { get; set; }

		public int blockCount { get; set; }
		public enum State
		{
			Open,
			Queen
		}

		public State state { get; set; }

		public Rect(Brush brush, Rectangle rect, State state)
		{
			this.Brush = brush;
			this.Rectangle = rect;
			this.blockCount = 0;
			this.state = state;
		}
	}
}
