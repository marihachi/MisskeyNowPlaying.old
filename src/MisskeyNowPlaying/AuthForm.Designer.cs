namespace MisskeyNowPlaying
{
	partial class AuthForm
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
			this.colorBorderPanel1 = new MisskeyNowPlaying.ColorBorderPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.colorBorderPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.ForeColor = System.Drawing.Color.White;
			this.okButton.Location = new System.Drawing.Point(171, 13);
			this.okButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(67, 29);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// colorBorderPanel1
			// 
			this.colorBorderPanel1.BorderColor = System.Drawing.Color.White;
			this.colorBorderPanel1.Controls.Add(this.textBox1);
			this.colorBorderPanel1.Location = new System.Drawing.Point(12, 15);
			this.colorBorderPanel1.Name = "colorBorderPanel1";
			this.colorBorderPanel1.Size = new System.Drawing.Size(153, 26);
			this.colorBorderPanel1.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.YellowGreen;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(3, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(147, 18);
			this.textBox1.TabIndex = 1;
			// 
			// AuthForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.YellowGreen;
			this.ClientSize = new System.Drawing.Size(250, 55);
			this.Controls.Add(this.colorBorderPanel1);
			this.Controls.Add(this.okButton);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AuthForm";
			this.Text = "PINコードを入力";
			this.colorBorderPanel1.ResumeLayout(false);
			this.colorBorderPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox textBox1;
		private MisskeyNowPlaying.ColorBorderPanel colorBorderPanel1;
	}
}