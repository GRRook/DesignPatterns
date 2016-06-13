using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGUI.Decorator
{
	public class ButtonDecorator : Decorator
	{
		public ButtonDecorator(BaseComponent baseComponent) 
			: base(baseComponent)
		{
			this.text = "Button";
		}

		public void OnClick()
		{
			Console.WriteLine($"The Button with text {text} has been clicked");
		}
	}
}
