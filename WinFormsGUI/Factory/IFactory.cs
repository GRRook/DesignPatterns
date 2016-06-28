using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGUI.Factory
{
	public interface IFactory<T>
	{
		T Create(string desc, string text, int x, int y, int width, int height, Color color);
	}
}
