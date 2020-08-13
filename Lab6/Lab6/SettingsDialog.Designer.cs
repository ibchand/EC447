namespace Lab6
{
	partial class SettingsDialog
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
			this.lb_out = new System.Windows.Forms.ListBox();
			this.lb_fill = new System.Windows.Forms.ListBox();
			this.lb_width = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.d_ok = new System.Windows.Forms.Button();
			this.d_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_out
			// 
			this.lb_out.FormattingEnabled = true;
			this.lb_out.Items.AddRange(new object[] {
            "No Outline",
            "Black",
            "Red",
            "Blue",
            "Green"});
			this.lb_out.Location = new System.Drawing.Point(30, 62);
			this.lb_out.Name = "lb_out";
			this.lb_out.Size = new System.Drawing.Size(66, 69);
			this.lb_out.TabIndex = 0;
			// 
			// lb_fill
			// 
			this.lb_fill.FormattingEnabled = true;
			this.lb_fill.Items.AddRange(new object[] {
            "No Fill",
            "Black",
            "Red",
            "Blue",
            "Green"});
			this.lb_fill.Location = new System.Drawing.Point(133, 62);
			this.lb_fill.Name = "lb_fill";
			this.lb_fill.Size = new System.Drawing.Size(66, 69);
			this.lb_fill.TabIndex = 1;
			// 
			// lb_width
			// 
			this.lb_width.FormattingEnabled = true;
			this.lb_width.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
			this.lb_width.Location = new System.Drawing.Point(235, 62);
			this.lb_width.Name = "lb_width";
			this.lb_width.Size = new System.Drawing.Size(117, 134);
			this.lb_width.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Outline/Pen Color";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(133, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Fill Color";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(235, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Pen Width";
			// 
			// d_ok
			// 
			this.d_ok.Location = new System.Drawing.Point(195, 229);
			this.d_ok.Name = "d_ok";
			this.d_ok.Size = new System.Drawing.Size(75, 23);
			this.d_ok.TabIndex = 6;
			this.d_ok.Text = "OK";
			this.d_ok.UseVisualStyleBackColor = true;
			this.d_ok.Click += new System.EventHandler(this.d_ok_Click);
			// 
			// d_cancel
			// 
			this.d_cancel.Location = new System.Drawing.Point(299, 229);
			this.d_cancel.Name = "d_cancel";
			this.d_cancel.Size = new System.Drawing.Size(75, 23);
			this.d_cancel.TabIndex = 7;
			this.d_cancel.Text = "Cancel";
			this.d_cancel.UseVisualStyleBackColor = true;
			this.d_cancel.Click += new System.EventHandler(this.d_cancel_Click);
			// 
			// SettingsDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 280);
			this.ControlBox = false;
			this.Controls.Add(this.d_cancel);
			this.Controls.Add(this.d_ok);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lb_width);
			this.Controls.Add(this.lb_fill);
			this.Controls.Add(this.lb_out);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.ListBox lb_out;
		public System.Windows.Forms.ListBox lb_fill;
		public System.Windows.Forms.ListBox lb_width;
		public System.Windows.Forms.Button d_ok;
		public System.Windows.Forms.Button d_cancel;
		private System.Windows.Forms.Label label2;
	}
}