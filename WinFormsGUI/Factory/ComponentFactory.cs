using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsGUI.Decorator;

namespace WinFormsGUI.Factory
{
	public class ComponentFactory : IFactory<BaseComponent>
	{
		public BaseComponent Create(string componentType)
		{
			componentType = componentType.ToLower();
			var label = new ConcreteLabel();

			switch (componentType)
			{
				case "Label":
					return label;
				case "button":
					return new ButtonDecorator(label);
				default:
					return null;
			}
		}
	}
}
