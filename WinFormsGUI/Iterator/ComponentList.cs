using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsGUI.Decorator;

namespace WinFormsGUI.Iterator
{
	public class ComponentList<T> : IIterator<T>
	{
		private List<T> internalList;
		private int Index = -1;

		public ComponentList(List<T> givenList)
		{
			this.internalList = givenList;
		}

		public T GetNext()
		{
			if (Index >= internalList.Count)
			{
				throw new IndexOutOfRangeException();
			}

			return internalList[Index];			
		}

		public bool MoveNext()
		{
			if (Index < internalList.Count && internalList.Count > 0)
			{
				Index++;
				return true;
			}
			return false;
		}
	}
}
