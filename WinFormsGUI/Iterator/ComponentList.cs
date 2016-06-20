using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsGUI.Decorator;
using WinFormsGUI.Option;

namespace WinFormsGUI.Iterator
{
	public class ComponentList : IIterator<BaseComponent>
	{
		public IOption<BaseComponent> GetNext()
		{
			throw new NotImplementedException();
		}
	}
}
