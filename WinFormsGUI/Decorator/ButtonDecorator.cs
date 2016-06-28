using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace WinFormsGUI.Decorator
{
	public class ButtonDecorator : Decorator
	{
		public ButtonDecorator(BaseComponent baseComponent) 
			: base(baseComponent)
		{
		}

		public override Color GetColor()
		{
			return base.baseComponent.GetColor();
		}

		public override Rectangle GetRectangle()
		{
			return base.baseComponent.GetRectangle();
		}

		public string OnClick()
		{
			return $"The Button with text {base.baseComponent.GetText()} has been clicked";
		}

		public override T Visit<T>(Func<ConcreteLabel, T> onLabel, Func<ButtonDecorator, T> onButton)
		{
			return onButton(this);
		}
	}
}
