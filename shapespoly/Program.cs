﻿namespace example1{

    public class Shape
{
    protected int m_xpos;
    protected int m_ypos;

    public Shape()
    {
    }

    public Shape(int x, int y)
    {
    m_xpos = x;
    m_ypos = y;
    }

    public virtual void Draw()
    {
    Console.WriteLine("Drawing a SHAPE at {0},{1}", m_xpos, m_ypos);
    }
}

public class Square : Shape
{
    public Square()
    {  }
     public Square(int x, int y) : base(x, y)
    {
    } 
    public override void Draw()
    {  Console.WriteLine("Drawing a SQUARE at {0},{1}", m_xpos, m_ypos);
    }
}

public class Circle: Shape
{ public Circle()
 { }
  public Circle(int x, int y) :base(x, y)
  {  }
    public new void Draw()
    {Console.WriteLine("Drawing a CIRCLE at {0},{1}", m_xpos, m_ypos);
    }
    public void FillCircle()
    {
        Console.WriteLine("Filling CIRCLE at {0},{1}", m_xpos, m_ypos);
    }
}

class Program
{   static void Main(string[] args)
    {Shape[] shapes = new Shape[3];
    shapes[0] = new Shape(100, 100);
    shapes[1] = new Square(200, 200);
    shapes[2] = new Circle(300, 300);
    foreach (Shape shape in shapes){
    shape.Draw();
    Circle c = shape as Circle;
    if(c!=null)
    c.FillCircle();}

    }
}

}