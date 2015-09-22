using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisskeyNowPlaying
{
	public partial class SettingForm : Form
	{
		public SettingForm()
		{
			InitializeComponent();
		}

		private async void okButton_Click(object sender, EventArgs e)
		{
			SettingStorage.Instance.PostTextFormat = textBox1.Text;
			SettingStorage.Instance.IsAutoPost = checkBox1.Checked;
			SettingStorage.Instance.AutoPostInterval = (int)numericUpDown1.Value;
			await SettingStorage.Instance.Save();

			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			textBox1.Text = SettingStorage.Instance.PostTextFormat;
			checkBox1.Checked = SettingStorage.Instance.IsAutoPost;
            numericUpDown1.Enabled = SettingStorage.Instance.IsAutoPost;
			numericUpDown1.Value = SettingStorage.Instance.AutoPostInterval;
        }

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDown1.Enabled = checkBox1.Checked;
        }
	}
}
