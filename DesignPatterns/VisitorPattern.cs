using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class VisitorPattern
    {
        public void Run()
        {
            FruitVisitor visitor = new FruitVisitor();
            List<Fruit> fruitList = new List<Fruit>();

            Apple apple = new Apple();
            apple.Text = "Apple";
            Banana banana = new Banana();
            banana.Text = "Banana";
            Orange orange = new Orange();
            orange.Text = "Orange";

            fruitList.Add(apple);
            fruitList.Add(banana);
            fruitList.Add(orange);

            foreach (Fruit piece in fruitList)
            {
                piece.Accept(visitor);
            }

            Console.WriteLine("Fruit:\n" + visitor.Output);
            Console.ReadLine();
        }
    }

    public interface IVisitor
    {
        void Visit(Apple apple);
        void Visit(Banana banana);
        void Visit(Orange orange);
    }

    class FruitVisitor : IVisitor
    {
        private string output = "";
        public string Output
        {
            get { return this.output; }
        }

        void IVisitor.Visit(Apple apple)
        {
            this.output += "<" + apple.Text + ">Apple XML" + "</" + apple.Text + ">";
        }

        void IVisitor.Visit(Banana banana)
        {
            this.output += "<" + banana.Text + ">Banana XML" + "</" + banana.Text + ">";
        }

        void IVisitor.Visit(Orange orange)
        {
            this.output += "<" + orange.Text + ">Orange XML" + "</" + orange.Text + ">";
        }
    }

    public abstract class Fruit
    {
        public string Text { get; set; }
        public abstract void Accept(IVisitor visitor);
    }

    public class Apple : Fruit
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Banana : Fruit
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Orange : Fruit
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
