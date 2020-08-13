using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void browseBtn_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
				fileNameTB.Text = openFileDialog1.FileName;
		}

		private void encryptBtn_Click(object sender, EventArgs e)
		{
			string path = fileNameTB.Text;

			if (keyTB.Text == "")
				MessageBox.Show("Please enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				DialogResult result;

				if (File.Exists(path + ".enc"))
				{
					result = MessageBox.Show("Output file exists. Overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.No)
						return;
				}
				if (!File.Exists(path))
				{
					MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				FileStream fin = null;
				FileStream fout = null;
				int rbyte;
				int pos = 0;    //position in key string
				int length = keyTB.Text.Length; //length of key
				byte kbyte, ebyte; //encrypted byte

				try
				{
					fin = new FileStream(path, FileMode.Open);
					fout = new FileStream(path + ".enc", FileMode.Create);

					while ((rbyte = fin.ReadByte()) != -1)
					{
						kbyte = (byte)keyTB.Text[pos];
						ebyte = (byte)(rbyte ^ kbyte);
						fout.WriteByte(ebyte);
						++pos;
						if (pos == length)
							pos = 0;
					}
					MessageBox.Show("Operation completed successfully.");
				}
				catch (Exception ee) { MessageBox.Show("Encryption failed.\n" + ee.Message); }
				finally { if (fin != null) fin.Close(); if (fout != null) fout.Close(); }
			}
		}

		private void decryptBtn_Click(object sender, EventArgs e)
		{
			//Do file writing and stuff again, except in reverse
			//Errors show up on center of screen
			//Error if key is empty: "Please enter a key."
			//Error if fileName is empty: "Not a .enc file."
			//Error if extension of fileName isn't .enc: "Not a .enc file."
			string path = fileNameTB.Text;

			if (keyTB.Text == "")
				MessageBox.Show("Please enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (Path.GetExtension(fileNameTB.Text) != ".enc")
				MessageBox.Show("Not a .enc file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				DialogResult result;
				if (File.Exists(Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path))))
				{
					result = MessageBox.Show("Output file exists. Overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.No)
						return;
				}

				if (!File.Exists(path))
				{
					MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				FileStream fin = null;
				FileStream fout = null;
				int rbyte;
				int pos = 0;    //position in key string
				int length = keyTB.Text.Length; //length of key
				byte kbyte, ebyte; //encrypted byte

				try
				{
					fin = new FileStream(path, FileMode.Open);
					fout = new FileStream(Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path)), FileMode.Create);

					while ((rbyte = fin.ReadByte()) != -1)
					{
						kbyte = (byte)keyTB.Text[pos];
						ebyte = (byte)(rbyte ^ kbyte);
						fout.WriteByte(ebyte);
						++pos;
						if (pos == length)
							pos = 0;
					}
					MessageBox.Show("Operation completed successfully.");
				}
				catch (Exception ee) { MessageBox.Show("Decryption failed.\n" + ee.Message); }
				finally { if (fin != null) fin.Close(); if (fout != null) fout.Close(); }
			}
		}
	}
}
