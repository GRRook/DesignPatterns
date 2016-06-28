using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace WinFormsGUI.Decorator
{
	public class ConcreteLabel : BaseComponent
	{		
		private string text { get; set; }
		private Rectangle rectangle { get; set; }
		private Color color { get; set; }

		public ConcreteLabel(string text, int x, int y, int width, int height, Color color)
		{
			this.text = text;
			this.color = color;
			this.rectangle = new Rectangle(x, y, width, height);
		}
		
		public override Color GetColor()
		{
			return this.color;
		}

		public override Rectangle GetRectangle()
		{
			return this.rectangle;
		}

		public override string GetText()
		{
			return this.text;
		}

		public override T Visit<T>(Func<ConcreteLabel, T> onLabel, Func<ButtonDecorator, T> onButton)
		{
			return onLabel(this);
		}
	}
}
