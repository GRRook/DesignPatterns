using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace WinFormsGUI.Decorator
{
	public abstract class Decorator : BaseComponent
	{
		protected BaseComponent baseComponent = null;

		protected string text = "undefined decorator";
		protected Rectangle rectangle;
		protected Color color;

		protected Decorator(BaseComponent baseComponent)
		{
			this.baseComponent = baseComponent;
		}

		public override string GetText()
		{
			return this.baseComponent.GetText();
		}
	}
}
