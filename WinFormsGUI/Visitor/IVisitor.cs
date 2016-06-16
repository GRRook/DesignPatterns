using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGUI.Visitor
{
	// http://stackoverflow.com/questions/8841577/is-this-use-of-the-instanceof-operator-considered-bad-design
	public interface IVisitor<T>
	{
		U Visit<U>(Func<T, U> onLabel, Func<T, U> onButton);
	}
}
