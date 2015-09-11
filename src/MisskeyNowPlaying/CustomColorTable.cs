using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisskeyNowPlaying
{
	class CustomColorTable : ProfessionalColorTable
	{
		public CustomColorTable()
		{
			MainColor = Color.FromArgb(154, 205, 50);
			Color1 = Color.FromArgb(255, 255, 255);
			Color2 = Color.FromArgb(50, 255, 255, 255);
		}

		public Color MainColor { get; set; }
		public Color Color1 { get; set; }
		public Color Color2 { get; set; }

		public override Color MenuItemBorder
		{
			get { return Color1; }
		}

		public override Color MenuItemPressedGradientBegin
		{
			get { return Color2; }
		}
		public override Color MenuItemPressedGradientEnd
		{
			get { return Color2; }
		}

		public override Color MenuItemSelectedGradientBegin
		{
			get { return MainColor; }
		}
		public override Color MenuItemSelectedGradientEnd
		{
			get { return MainColor; }
		}

		public override Color MenuStripGradientBegin
		{
			get { return MainColor; }
		}
		public override Color MenuStripGradientEnd
		{
			get { return MainColor; }
		}
	}
}
