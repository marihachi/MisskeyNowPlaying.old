using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Json;

namespace MisskeyNowPlaying
{
	class SettingStorage
	{
		public static SettingStorage Instance
		{
			get
			{
				if (instance == null)
					instance = new SettingStorage();
				return instance;
			}
		}
		private static SettingStorage instance;

		private SettingStorage()
		{
			Account = new MSharp.Misskey(Config.Appkey, new Uri("http://api.misskey.xyz/"));
			PostTextFormat = "<number>. <title> / <artist> - <album> (played: <playcount>)\r\n<usercomment>";
			TargetPlayer = PlayerType.None;
			IsAutoPost = false;
			AutoPostInterval = 10;
        }

		/// <summary>
		/// Misskey連携情報
		/// </summary>
		public MSharp.Misskey Account { set; get; }

		/// <summary>
		/// 投稿する内容の書式
		/// </summary>
		public string PostTextFormat { set; get; }

		/// <summary>
		/// 対象のプレイヤー
		/// </summary>
		public PlayerType TargetPlayer { set; get; }

		/// <summary>
		/// 自動投稿をするかどうか
		/// </summary>
		public bool IsAutoPost { set; get; }

		/// <summary>
		/// 自動投稿までのインターバル
		/// </summary>
		public int AutoPostInterval { set; get; }

		/// <summary>
		/// 設定を保存します
		/// </summary>
		public async Task Save()
		{
			await Task.Run(() =>
			{
				// Serialize
				var json = new JsonObject();
				JsonPrimitive element;

				JsonPrimitive.TryCreate(Account.BaseUrl, out element);
				json.Add("BaseUrl", element);

				JsonPrimitive.TryCreate(Account.UserKey, out element);
				json.Add("UserKey", element);

				JsonPrimitive.TryCreate(PostTextFormat, out element);
				json.Add("PostTextFormat", element);

				JsonPrimitive.TryCreate((int)TargetPlayer, out element);
				json.Add("TargetPlayer", element);

				JsonPrimitive.TryCreate(IsAutoPost, out element);
				json.Add("IsAutoPost", element);

				JsonPrimitive.TryCreate(AutoPostInterval, out element);
				json.Add("AutoPostInterval", element);

				// Save
				using (var sw = new System.IO.StreamWriter("setting.json"))
				{
					json.Save(sw);
				}
			});
		}

		/// <summary>
		/// 設定を読み込みます
		/// </summary>
		public async Task Load()
		{
			await await Task.Factory.StartNew(async () =>
			{
				if (!System.IO.File.Exists("setting.json"))
				{
					await this.Save();
				}
				using (var sr = new System.IO.StreamReader("setting.json"))
				{
					// Load
					var j = JsonObject.Load(sr).AsDynamic();

					if (j.UserKey != null)
						Account = new MSharp.Misskey(Account.AppKey, j.UserKey.Value, null);

					if (!string.IsNullOrEmpty(j.BaseUrl.Value))
						Account.BaseUrl = new Uri(j.BaseUrl.Value);

					if (j.PostTextFormat != null)
						PostTextFormat = j.PostTextFormat.Value;

					if (j.TargetPlayer.Value != null)
						TargetPlayer = (PlayerType)j.TargetPlayer.Value;

					if (j.IsAutoPost != null)
						IsAutoPost = j.IsAutoPost.Value;

					if (j.AutoPostInterval != null)
						AutoPostInterval = j.AutoPostInterval.Value;
				}
			});
		}
	}
}
