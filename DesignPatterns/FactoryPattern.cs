using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class FactoryPattern
    {
        public void Run()
        {
            ShapeFactory sf = new ShapeFactory();
			var shape = sf.getShape("CIRCLE");
			shape.Draw();
        }
    }

    public interface IShape
    {
        void Draw();
    }

    public class Rectangle : IShape
    {
       public void Draw()
       {
           Console.WriteLine("Rectangle");
       }
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square");
        }
    }

    public class ShapeFactory
    {
        //use getShape method to get object of type shape 
        public IShape getShape(String shapeType)
        {
			switch (shapeType)
			{
				case "CIRCLE":
					return new Circle();
				case "RECTANGLE":
					return new Rectangle();
				case "SQUARE":
					return new Square();
				default:
					return null;
			}
        }
    }
}
