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
            sf.getShape("CIRCLE").draw();
        }
    }
    public interface Shape
    {
        void draw();
    }

    public class Rectangle : Shape
    {
       public void draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Circle");
        }
    }
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Square");
        }
    }

    public class ShapeFactory
    {
        //use getShape method to get object of type shape 
        public Shape getShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType == "CIRCLE")
            {
                return new Circle();

            }
            else if (shapeType =="RECTANGLE")
            {
                return new Rectangle();

            }
            else if (shapeType == "SQUARE")
            {
                return new Square();
            }

            return null;
        }
    }
}
