namespace MisskeyNowPlaying
{
	partial class SettingForm
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
			this.okButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.colorBorderPanel1 = new MisskeyNowPlaying.ColorBorderPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.colorBorderPanel2 = new MisskeyNowPlaying.ColorBorderPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.colorBorderPanel3 = new MisskeyNowPlaying.ColorBorderPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.colorBorderPanel1.SuspendLayout();
			this.colorBorderPanel2.SuspendLayout();
			this.colorBorderPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.ForeColor = System.Drawing.Color.White;
			this.okButton.Location = new System.Drawing.Point(405, 327);
			this.okButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(67, 29);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "投稿する内容";
			// 
			// colorBorderPanel1
			// 
			this.colorBorderPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colorBorderPanel1.Controls.Add(this.label3);
			this.colorBorderPanel1.Controls.Add(this.label2);
			this.colorBorderPanel1.Controls.Add(this.colorBorderPanel2);
			this.colorBorderPanel1.Location = new System.Drawing.Point(13, 13);
			this.colorBorderPanel1.Name = "colorBorderPanel1";
			this.colorBorderPanel1.Size = new System.Drawing.Size(459, 198);
			this.colorBorderPanel1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(226, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(218, 54);
			this.label3.TabIndex = 5;
			this.label3.Text = "<album> : アルバム名\r\n<playcount> : 今までの再生回数\r\n<usercomment> : 付加したコメント";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 72);
			this.label2.TabIndex = 4;
			this.label2.Text = "使用可能タグ一覧\r\n<number> : トラック番号\r\n<title> : 曲名\r\n<artist> : アーティスト名";
			// 
			// colorBorderPanel2
			// 
			this.colorBorderPanel2.BorderColor = System.Drawing.Color.White;
			this.colorBorderPanel2.Controls.Add(this.textBox1);
			this.colorBorderPanel2.Location = new System.Drawing.Point(14, 22);
			this.colorBorderPanel2.Name = "colorBorderPanel2";
			this.colorBorderPanel2.Size = new System.Drawing.Size(430, 79);
			this.colorBorderPanel2.TabIndex = 3;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.BackColor = System.Drawing.Color.YellowGreen;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(1, 1);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBox1.Size = new System.Drawing.Size(428, 77);
			this.textBox1.TabIndex = 1;
			this.textBox1.WordWrap = false;
			// 
			// colorBorderPanel3
			// 
			this.colorBorderPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colorBorderPanel3.Controls.Add(this.label5);
			this.colorBorderPanel3.Controls.Add(this.numericUpDown1);
			this.colorBorderPanel3.Controls.Add(this.checkBox1);
			this.colorBorderPanel3.Location = new System.Drawing.Point(13, 226);
			this.colorBorderPanel3.Name = "colorBorderPanel3";
			this.colorBorderPanel3.Size = new System.Drawing.Size(459, 94);
			this.colorBorderPanel3.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 18);
			this.label5.TabIndex = 1;
			this.label5.Text = "投稿されるまでの時間:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BackColor = System.Drawing.Color.YellowGreen;
			this.numericUpDown1.ForeColor = System.Drawing.Color.White;
			this.numericUpDown1.Location = new System.Drawing.Point(157, 36);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(47, 25);
			this.numericUpDown1.TabIndex = 2;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(14, 13);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(219, 22);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "曲が変わった時に自動的に投稿する";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 218);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 18);
			this.label4.TabIndex = 5;
			this.label4.Text = "自動投稿";
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.YellowGreen;
			this.ClientSize = new System.Drawing.Size(484, 369);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.colorBorderPanel3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.colorBorderPanel1);
			this.Controls.Add(this.okButton);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingForm";
			this.Text = "設定";
			this.Load += new System.EventHandler(this.SettingForm_Load);
			this.colorBorderPanel1.ResumeLayout(false);
			this.colorBorderPanel1.PerformLayout();
			this.colorBorderPanel2.ResumeLayout(false);
			this.colorBorderPanel2.PerformLayout();
			this.colorBorderPanel3.ResumeLayout(false);
			this.colorBorderPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button okButton;
		private MisskeyNowPlaying.ColorBorderPanel colorBorderPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private MisskeyNowPlaying.ColorBorderPanel colorBorderPanel2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private ColorBorderPanel colorBorderPanel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}