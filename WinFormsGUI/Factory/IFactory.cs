using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGUI.Factory
{
	public interface IFactory<T>
	{
		T GetComponent(string desc);
	}
}
