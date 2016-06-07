using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionNoLambda
{
    interface OptionVisitor<T, U>
    {
        U onSome(T value);
        U onNone();
    }
    interface Option<T>
    {
        U Visit<U>(OptionVisitor<T, U> visitor);
    }
    class Some<T> : Option<T>
    {
        public T value;
        public Some(T value) { this.value = value; }
        public U Visit<U>(OptionVisitor<T, U> visitor)
        {
            return visitor.onSome(this.value);
        }
    }
    class None<T> : Option<T>
    {
        public U Visit<U>(OptionVisitor<T, U> visitor)
        {
            return visitor.onNone();
        }
    }
    class PrettyPrinterIOptionVisitor<T> : OptionVisitor<T, string>
    {
        public string onNone()
        {
            return "I am nothing...";
        }

        public string onSome(T value)
        {
            return value.ToString();
        }
    }
    class PrettyPrinterIntIOptionVisitor : OptionVisitor<int, string>
    {
        public string onNone()
        {
            return "I am nothing...";
        }

        public string onSome(int value)
        {
            return value.ToString();
        }
    }
    class LambdaIOptionVisitor<T, U> : OptionVisitor<T, U>
    {
        Func<T, U> _onSome;
        Func<U> _onNone;
        public LambdaIOptionVisitor(Func<T, U> onSome, Func<U> onNone)
        {
            this._onSome = onSome;
            this._onNone = onNone;
        }
        public U onNone()
        {
            return onNone();
        }

        public U onSome(T value)
        {
            return onSome(value);
        }
    }
}
namespace OptionLambda
{
    public interface Option<T>
    {
        U Visit<U>(Func<U> onNone, Func<T, U> onSome);
    }
    public class Some<T> : Option<T>
    {
        T value;
        public Some(T value) { this.value = value; }
        public U Visit<U>(Func<U> onNone, Func<T, U> onSome)
        {
            return onSome(value);
        }
    }
    public class None<T> : Option<T>
    {
        public U Visit<U>(Func<U> onNone, Func<T, U> onSome)
        {
            return onNone();
        }
    }
}
namespace Number
{
    interface INumberVisitor
    {
        void onMyFloat(MyFloat number);
        void onMyInt(MyInt number);
    }
    class NumberVisitor : INumberVisitor
    {
        public void onMyFloat(MyFloat number) { Console.WriteLine("Found a float and now?"); }
        public void onMyInt(MyInt number) { Console.WriteLine("Found an int and now?!"); }
    }
    interface Number1 { void Visit(INumberVisitor visitor); }
    class MyInt : Number1
    {
        void Number1.Visit(INumberVisitor visitor)
        {
            visitor.onMyInt(this);
        }
    }
    class MyFloat : Number1
    {
        void Number1.Visit(INumberVisitor visitor)
        {
            visitor.onMyFloat(this);
        }
    }

}
namespace MusicLibrary
{
    interface IMusicLibraryVisitor
    {
        void onHeavyMetal(HeavyMetal number);
        void onJazz(Jazz number);
    }
    class MusicLibraryVisitor : IMusicLibraryVisitor
    {
        public List<HeavyMetal> heavyMetal = new List<HeavyMetal>();
        public List<Jazz> jazz = new List<Jazz>();

        public void onHeavyMetal(HeavyMetal song) { heavyMetal.Add(song); }
        public void onJazz(Jazz song) { jazz.Add(song); }
    }
    interface Song { void Visit(IMusicLibraryVisitor visitor); }
    class HeavyMetal : Song
    {
        string title;
        public HeavyMetal(string title) { this.title = title; }
        public void Visit(IMusicLibraryVisitor visitor)
        {
            visitor.onHeavyMetal(this);
        }
    }
    class Jazz : Song
    {
        string title;
        public Jazz(string title) { this.title = title; }
        public void Visit(IMusicLibraryVisitor visitor)
        {
            visitor.onJazz(this);
        }
    }
}



