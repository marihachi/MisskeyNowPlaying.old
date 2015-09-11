using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MSharp;
using NowPlayingLib;
using System.Net.Http;
using System.IO;

namespace MisskeyNowPlaying
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			wmp = null;
			itunes = null;
		}

		private MediaItem NowPlayMedia { set; get; }

		private WindowsMediaPlayer wmp { set; get; }
		private iTunes itunes { set; get; }

		/// <summary>
		/// 曲情報をメインフォームに反映する
		/// </summary>
		private void SetToFormSongInfo(MediaItem media)
		{
			if (media.Artworks.Count > 0)
				pictureBox1.Image = Image.FromStream(media.Artworks[0]);
			else
				pictureBox1.Image = MisskeyNowPlaying.Properties.Resources.noimage;

			label1.Text = string.Format("{0:D2}. {1} - {2}", media.TrackNumber, media.Name, media.Album);
			label2.Text = string.Format("{0}", !string.IsNullOrEmpty(media.Artist) ? media.Artist : media.AlbumArtist);
		}

		/// <summary>
		/// WMPとの連携を初期化します
		/// </summary>
		private async Task<bool> InitalizeWMP()
		{
			wmp = await Task.Run(() =>
			{
				try
				{
					return new WindowsMediaPlayer();
				}
				catch
				{
					return null;
				}
			});
			var isSuccess = false;
			if (wmp != null)
			{
				var media = await wmp.GetCurrentMedia();
				if (media != null)
				{
					NowPlayMedia = media;
					SetToFormSongInfo(media);
				}
				wmp.CurrentMediaChanged += (_, ev) =>
					this.Invoke((MethodInvoker)(() =>
					{
						NowPlayMedia = ev.CurrentMedia;
						SetToFormSongInfo(ev.CurrentMedia);
					}));
				isSuccess = true;
			}
			return isSuccess;
		}

		/// <summary>
		/// iTunesとの連携を初期化します
		/// </summary>
		private async Task<bool> InitalizeiTunes()
		{
			itunes = await Task.Run(() =>
			{
				try
				{
					return new iTunes();
				}
				catch
				{
					return null;
				}
			});
			var isSuccess = false;
			if (itunes != null)
			{
				var media = await itunes.GetCurrentMedia();
				if (media != null)
				{
					NowPlayMedia = media;
					SetToFormSongInfo(media);
				}
				itunes.CurrentMediaChanged += (_, ev) =>
					this.Invoke((MethodInvoker)(() =>
					{
						NowPlayMedia = ev.CurrentMedia;
						SetToFormSongInfo(ev.CurrentMedia);
					}));
				isSuccess = true;
			}
			return isSuccess;
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			menuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());

			var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
			this.Text = string.Format("MisskeyNowPlaying - v{0}", version);

			// Load Setting
			await SettingStorage.Instance.Load();
			if (SettingStorage.Instance.TargetPlayer == PlayerType.None)
			{
				var psf = new PlayerSelectForm();
				if (psf.ShowDialog() == DialogResult.OK)
				{
					SettingStorage.Instance.TargetPlayer = psf.Response;
					await SettingStorage.Instance.Save();
				}
				else
				{
					this.Close();
					return;
				}
			}

			// Cooperate Player
			var playerInfo = "";
			if (SettingStorage.Instance.TargetPlayer == PlayerType.WindowsMediaPlayer)
			{
				if (!await InitalizeWMP())
				{
					if (MessageBox.Show("WMPとの連携に失敗しました。プレイヤーを選択し直しますか？", "質問", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
					{
						var psf = new PlayerSelectForm();
						if (psf.ShowDialog() != DialogResult.OK)
						{
							this.Close();
							return;
						}
						SettingStorage.Instance.TargetPlayer = psf.Response;
						await SettingStorage.Instance.Save();
						Application.Restart();
					}
					else
					{
						this.Close();
						return;
					}
				}
				else
					playerInfo = "WMP";
			}
			else if (SettingStorage.Instance.TargetPlayer == PlayerType.iTunes)
			{
				if (!await InitalizeiTunes())
				{
					if (MessageBox.Show("iTunesとの連携に失敗しました。プレイヤーを選択し直しますか？", "質問", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
					{
						var psf = new PlayerSelectForm();
						if (psf.ShowDialog() != DialogResult.OK)
						{
							this.Close();
							return;
						}
						SettingStorage.Instance.TargetPlayer = psf.Response;
						await SettingStorage.Instance.Save();
						Application.Restart();
					}
					else
					{
						this.Close();
						return;
					}
				}
				else
					playerInfo = "iTunes";
			}
			else
			{
				this.Close();
				return;
			}
			this.Text = string.Format("MisskeyNowPlaying({1}モード) - v{0}", version, playerInfo);

			// Authorize
			if (!SettingStorage.Instance.Account.IsAuthorized)
			{
				await SettingStorage.Instance.Account.StartAuthorize();
				var authform = new AuthForm();
				if (authform.ShowDialog() == DialogResult.OK)
				{
					try
					{
						SettingStorage.Instance.Account = await SettingStorage.Instance.Account.AuthorizePIN(authform.Response);
						await SettingStorage.Instance.Save();
					}
					catch
					{
						MessageBox.Show("認証に失敗しました。", "エラー");
						this.Close();
					}
				}
				else
					this.Close();
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (wmp != null)
				wmp.Dispose();

			if (itunes != null)
				itunes.Dispose();
		}

		private async void postToMisskeyButton_Click(object sender, EventArgs e)
		{
			if (NowPlayMedia == null)
			{
				MessageBox.Show("再生中のメディアがありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			var text = SettingStorage.Instance.PostTextFormat;

			text = text.Replace("<number>", "{0:D2}");
			text = text.Replace("<title>", "{1}");
			text = text.Replace("<artist>", "{2}");
			text = text.Replace("<album>", "{3}");
			text = text.Replace("<playcount>", "{4}");
			text = text.Replace("<usercomment>", "{5}");

			text = string.Format(
				text,
				NowPlayMedia.TrackNumber,
				NowPlayMedia.Name,
				!string.IsNullOrEmpty(NowPlayMedia.Artist) ? NowPlayMedia.Artist : NowPlayMedia.AlbumArtist,
				NowPlayMedia.Album,
				NowPlayMedia.PlayedCount,
				commentBox.Text);

			try
			{
				var res = await SettingStorage.Instance.Account.Request(
					MethodType.POST,
					"status/update",
					new Dictionary<string, string>() {
					{ "text", text }
				});

				if (!string.IsNullOrEmpty(res))
					commentBox.Text = "";
			}
			catch (MSharp.Core.RequestException ex)
			{
				MessageBox.Show(string.Format("リクエストに失敗しました。(詳細: {0})", ex.Message), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (MSharp.Core.ApiException ex)
			{
				MessageBox.Show(string.Format("Misskeyからエラーが返されました。(詳細: {0})", ex.Message), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void settingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new SettingForm().ShowDialog();
		}

		private async void selectPlayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var psf = new PlayerSelectForm();
			if (psf.ShowDialog() != DialogResult.OK)
			{
				this.Close();
				return;
			}

			SettingStorage.Instance.TargetPlayer = psf.Response;

			await SettingStorage.Instance.Save();
			Application.Restart();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
