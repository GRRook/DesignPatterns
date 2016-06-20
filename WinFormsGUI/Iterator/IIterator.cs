using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGUI.Iterator
{
	public interface IIterator<T>
	{
		bool MoveNext();
		T GetNext();
	}
}
