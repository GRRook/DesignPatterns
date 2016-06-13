using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGUI.Decorator
{
	public abstract class Decorator : BaseComponent
	{
		BaseComponent baseComponent = null;

		protected string text = "undefined decorator";

		protected Decorator(BaseComponent baseComponent)
		{
			this.baseComponent = baseComponent;
		}

		public override string GetText()
		{
			return $"{baseComponent.GetText()}, {text}";
		}
	}
}
