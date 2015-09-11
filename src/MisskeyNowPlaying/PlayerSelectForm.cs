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
	public partial class PlayerSelectForm : Form
	{
		public PlayerSelectForm()
		{
			InitializeComponent();

			Response = PlayerType.None;
		}

		public PlayerType Response { private set; get; }

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.Response = PlayerType.WindowsMediaPlayer;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			this.Response = PlayerType.iTunes;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (Response != PlayerType.None)
			{
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
			else
				MessageBox.Show("プレイヤーを選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}
}
