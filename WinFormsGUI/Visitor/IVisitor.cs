using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGUI.Visitor
{
	public interface IVisitor<T>
	{
		U Visit<U>(Func<T, U> onLabel, Func<T, U> onButton);
	}
}
