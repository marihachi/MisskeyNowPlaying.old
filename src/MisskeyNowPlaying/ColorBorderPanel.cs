using System.Drawing;
using System.Windows.Forms;

namespace MisskeyNowPlaying
{
	class ColorBorderPanel : Panel
    {
        public ColorBorderPanel()
        {
			SetStyle(
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw |
				ControlStyles.DoubleBuffer |
				ControlStyles.AllPaintingInWmPaint,
				true);
        }

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			var g = e.Graphics;
			var rectangle = this.ClientRectangle;
			rectangle.Width -= 1;
			rectangle.Height -= 1;

			g.DrawRectangle(new Pen(BorderColor), rectangle);
		}

        public Color BorderColor
        {
            set
            {
                borderColor = value;
                OnPaint(new PaintEventArgs(this.CreateGraphics(), new Rectangle(0, 0, 1, 1)));
            }
            get
            {
                return borderColor;
            }
        }
        private Color borderColor;
    }
}
