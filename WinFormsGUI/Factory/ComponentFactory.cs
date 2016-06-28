using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using WinFormsGUI.Decorator;

namespace WinFormsGUI.Factory
{
	public class ComponentFactory : IFactory<BaseComponent>
	{
		public BaseComponent Create(string componentType, string text, int x, int y, int width, int height, Color color)
		{
			componentType = componentType.ToLower();
			var label = new ConcreteLabel(text, x, y, width, height, color);

			switch (componentType)
			{
				case "label":
					return label;
				case "button":
					return new ButtonDecorator(label);
				default:
					return null;
			}
		}
	}
}
