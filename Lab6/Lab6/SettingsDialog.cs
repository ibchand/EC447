using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
	public partial class SettingsDialog : Form
	{
		private int SOut;
		private int SFill;
		private int SWidth;
		public SettingsDialog()
		{
			InitializeComponent();
			lb_out.SelectedIndex = 0;
			lb_fill.SelectedIndex = 0;
			lb_width.SelectedIndex = 0;
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			SOut = lb_out.SelectedIndex;
			SFill = lb_fill.SelectedIndex;
			SWidth = lb_width.SelectedIndex;
		}

		private void d_ok_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void d_cancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			lb_out.SelectedIndex = SOut;
			lb_fill.SelectedIndex = SFill;
			lb_width.SelectedIndex = SWidth;
		}
	}
}
