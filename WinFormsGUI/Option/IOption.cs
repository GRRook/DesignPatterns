using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGUI.Option
{
	public interface IOption<U>
	{
		U Visit<T>(Func<U, T> onSome, Func<U, T> onNone);
	}
}
