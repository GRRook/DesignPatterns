using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	interface V
	{
		T Visit<T>(Func<int, int, T> onA, Func<B, T> onB);
	}

	class A : V
	{
		int x, y;

		public T Visit<T>(Func<int, int, T> onA, Func<B, T> onB)
		{
			return onA(this.x, this.y);
		}
	}

	class B : V
	{
		float w, z;

		public string SayHello()
		{
			return "8===D";
		}
		public T Visit<T>(Func<int, int, T> onA, Func<B, T> onB)
		{
			return onB(this);
		}
	}

	interface F<Ps, T>
	{
		T Create(Ps ps);
	}

	// Dit kan niet omdat het voorbeeld een nieuw project was.
	//class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		F<string, V> fv = null;
	//		V v1 = fv.Create("hello!");
	//		Console.WriteLine(v1.Visit<string>((x, y) => "A", b => b.SayHello()));
	//	}
	//}
}
