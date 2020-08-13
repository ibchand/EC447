namespace Lab5
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
			this.fileName = new System.Windows.Forms.Label();
			this.fileNameTB = new System.Windows.Forms.TextBox();
			this.key = new System.Windows.Forms.Label();
			this.keyTB = new System.Windows.Forms.TextBox();
			this.browseBtn = new System.Windows.Forms.Button();
			this.encryptBtn = new System.Windows.Forms.Button();
			this.decryptBtn = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// fileName
			// 
			this.fileName.AutoSize = true;
			this.fileName.Location = new System.Drawing.Point(26, 28);
			this.fileName.Name = "fileName";
			this.fileName.Size = new System.Drawing.Size(57, 13);
			this.fileName.TabIndex = 0;
			this.fileName.Text = "File Name:";
			// 
			// fileNameTB
			// 
			this.fileNameTB.Location = new System.Drawing.Point(26, 44);
			this.fileNameTB.Name = "fileNameTB";
			this.fileNameTB.Size = new System.Drawing.Size(281, 20);
			this.fileNameTB.TabIndex = 1;
			// 
			// key
			// 
			this.key.AutoSize = true;
			this.key.Location = new System.Drawing.Point(26, 92);
			this.key.Name = "key";
			this.key.Size = new System.Drawing.Size(28, 13);
			this.key.TabIndex = 2;
			this.key.Text = "Key:";
			// 
			// keyTB
			// 
			this.keyTB.Location = new System.Drawing.Point(26, 108);
			this.keyTB.Name = "keyTB";
			this.keyTB.Size = new System.Drawing.Size(100, 20);
			this.keyTB.TabIndex = 3;
			// 
			// browseBtn
			// 
			this.browseBtn.Location = new System.Drawing.Point(330, 42);
			this.browseBtn.Name = "browseBtn";
			this.browseBtn.Size = new System.Drawing.Size(53, 23);
			this.browseBtn.TabIndex = 4;
			this.browseBtn.Text = "Browse";
			this.browseBtn.UseVisualStyleBackColor = true;
			this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
			// 
			// encryptBtn
			// 
			this.encryptBtn.Location = new System.Drawing.Point(26, 154);
			this.encryptBtn.Name = "encryptBtn";
			this.encryptBtn.Size = new System.Drawing.Size(75, 23);
			this.encryptBtn.TabIndex = 5;
			this.encryptBtn.Text = "Encrypt";
			this.encryptBtn.UseVisualStyleBackColor = true;
			this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
			// 
			// decryptBtn
			// 
			this.decryptBtn.Location = new System.Drawing.Point(127, 154);
			this.decryptBtn.Name = "decryptBtn";
			this.decryptBtn.Size = new System.Drawing.Size(75, 23);
			this.decryptBtn.TabIndex = 6;
			this.decryptBtn.Text = "Decrypt";
			this.decryptBtn.UseVisualStyleBackColor = true;
			this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "All files (*.*)|*.*|Encrypted files (*.enc)|*.enc";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 209);
			this.Controls.Add(this.decryptBtn);
			this.Controls.Add(this.encryptBtn);
			this.Controls.Add(this.browseBtn);
			this.Controls.Add(this.keyTB);
			this.Controls.Add(this.key);
			this.Controls.Add(this.fileNameTB);
			this.Controls.Add(this.fileName);
			this.Name = "Form1";
			this.Text = "File Encrypt/Decrypt by Ibrahim Chand";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label fileName;
		private System.Windows.Forms.TextBox fileNameTB;
		private System.Windows.Forms.Label key;
		private System.Windows.Forms.TextBox keyTB;
		private System.Windows.Forms.Button browseBtn;
		private System.Windows.Forms.Button encryptBtn;
		private System.Windows.Forms.Button decryptBtn;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

