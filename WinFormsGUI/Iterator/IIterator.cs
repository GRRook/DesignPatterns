using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsGUI.Option;

namespace WinFormsGUI.Iterator
{
	public interface IIterator<T>
	{
		IOption<T> GetNext();
	}
}
