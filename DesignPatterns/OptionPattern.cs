using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
	public class OptionPattern
	{
	}

	public interface IOption<T>
	{
		U Visit<U>(Func<T, U> onSome, Func<T, U> onNone);
	}

	public interface IOptionVisitor<T, U>
	{
		U onSome<U>();
		U onNone<U>();
	}

	public class onLabel<T> : IOption<T>
	{
		public T value;
		public onLabel(T value)
		{
			this.value = value;
		}

		public U Visit<U>(Func<T, U> onLabel, Func<T, U> onButton)
		{
			return onLabel(value);
		}
	}

	public class onButton<T> : IOption<T>
	{
		public T value;
		public onButton(T value)
		{
			this.value = value;
		}

		public U Visit<U>(Func<T, U> onLabel, Func<T, U> onButton)
		{
			return onButton(value);
		}
	}
}
