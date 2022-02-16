using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInheritance
{
    public abstract class SomeClass
    {
        public void Test()
        {
            Console.WriteLine("Test");
        }
    }

    public class SomeChildClass : SomeClass
    {

    }

    public abstract class Shape
    {
        public abstract float GetArea();
    }

    public class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; }

        public int Height { get; }

        public override float GetArea()
        {
            return Width * Height;
        }
    }
}
