namespace Lab6
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.set_btn = new System.Windows.Forms.Button();
			this.gb_1 = new System.Windows.Forms.GroupBox();
			this.rb_elip = new System.Windows.Forms.RadioButton();
			this.rb_rect = new System.Windows.Forms.RadioButton();
			this.rb_line = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gb_1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(618, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.undoToolStripMenuItem.Text = "Undo";
			this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.set_btn);
			this.panel1.Controls.Add(this.gb_1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(618, 74);
			this.panel1.TabIndex = 1;
			// 
			// set_btn
			// 
			this.set_btn.Location = new System.Drawing.Point(282, 27);
			this.set_btn.Name = "set_btn";
			this.set_btn.Size = new System.Drawing.Size(75, 23);
			this.set_btn.TabIndex = 1;
			this.set_btn.Text = "Settings";
			this.set_btn.UseVisualStyleBackColor = true;
			this.set_btn.Click += new System.EventHandler(this.set_btn_Click);
			// 
			// gb_1
			// 
			this.gb_1.BackColor = System.Drawing.Color.White;
			this.gb_1.Controls.Add(this.rb_elip);
			this.gb_1.Controls.Add(this.rb_rect);
			this.gb_1.Controls.Add(this.rb_line);
			this.gb_1.Location = new System.Drawing.Point(39, 13);
			this.gb_1.Name = "gb_1";
			this.gb_1.Size = new System.Drawing.Size(237, 45);
			this.gb_1.TabIndex = 0;
			this.gb_1.TabStop = false;
			this.gb_1.Text = "Draw";
			// 
			// rb_elip
			// 
			this.rb_elip.AutoSize = true;
			this.rb_elip.Location = new System.Drawing.Point(149, 20);
			this.rb_elip.Name = "rb_elip";
			this.rb_elip.Size = new System.Drawing.Size(55, 17);
			this.rb_elip.TabIndex = 2;
			this.rb_elip.TabStop = true;
			this.rb_elip.Text = "Ellipse";
			this.rb_elip.UseVisualStyleBackColor = true;
			// 
			// rb_rect
			// 
			this.rb_rect.AutoSize = true;
			this.rb_rect.Location = new System.Drawing.Point(69, 20);
			this.rb_rect.Name = "rb_rect";
			this.rb_rect.Size = new System.Drawing.Size(74, 17);
			this.rb_rect.TabIndex = 1;
			this.rb_rect.TabStop = true;
			this.rb_rect.Text = "Rectangle";
			this.rb_rect.UseVisualStyleBackColor = true;
			// 
			// rb_line
			// 
			this.rb_line.AutoSize = true;
			this.rb_line.Location = new System.Drawing.Point(18, 20);
			this.rb_line.Name = "rb_line";
			this.rb_line.Size = new System.Drawing.Size(45, 17);
			this.rb_line.TabIndex = 0;
			this.rb_line.TabStop = true;
			this.rb_line.Text = "Line";
			this.rb_line.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 98);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(618, 411);
			this.panel2.TabIndex = 2;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 509);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lab 6 - Ibrahim Chand";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.gb_1.ResumeLayout(false);
			this.gb_1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button set_btn;
		private System.Windows.Forms.GroupBox gb_1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rb_elip;
		private System.Windows.Forms.RadioButton rb_rect;
		private System.Windows.Forms.RadioButton rb_line;
	}
}

