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
			await SettingStorage.Instance.Save();

			this.Close();
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			textBox1.Text = SettingStorage.Instance.PostTextFormat;
		}
	}
}
