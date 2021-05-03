using System;

namespace CSharpMethodOverriding
{

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle Using Method Override");
            Console.WriteLine("Hello I am Rectangle");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle Using Method Override");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle Using Method Override");
        }
    }
    public class Shape
    { 
        public int Width { set; get; }
        public int Height { set; get; }
        public SequencePosition Position { set; get; }
        public virtual void Draw()
        { 
        
        }

    }
}
