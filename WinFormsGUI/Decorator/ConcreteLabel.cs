using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGUI.Decorator
{
	public class ConcreteLabel : BaseComponent
	{
		private string text { get; set; }

		public override string GetText()
		{
			return this.text;
		}
	}
}
