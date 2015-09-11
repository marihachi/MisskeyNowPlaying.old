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
	public partial class AuthForm : Form
	{
		public AuthForm()
		{
			InitializeComponent();

			Response = "";
		}

		public string Response { private set; get; }

		private void okButton_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				this.Response = textBox1.Text;
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
			else
				MessageBox.Show("PINコードを入力してください", "エラー");
		}
	}
}
