using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGUI.Decorator
{
	public abstract class BaseComponent
	{
		public abstract string GetText();
		public abstract Rectangle GetRectangle();
		public abstract Color GetColor();
		public abstract T Visit<T>(Func<ConcreteLabel, T> onLabel, Func<ButtonDecorator, T> onButton);
	}
}
