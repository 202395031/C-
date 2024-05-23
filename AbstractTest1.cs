

using System.ComponentModel.DataAnnotations;
using System.Xml;

abstract class Shape
{
    public abstract double CalculateArea();

    public void Display()
    {
        Console.WriteLine("This is a shape");
    }

}

class Circle : Shape
{
    private int radius;
    public Circle(int radius)
    {
        this.radius = radius;
    }
    public override double CalculateArea() 
    {
        return Math.PI * radius * radius;    
    }
}

class Rectangle : Shape
{
    private int x;
    private int y;
    public Rectangle(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override double CalculateArea()
    {
        return x * y;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("반지름을 입력하시오 : ");
        int r = int.Parse(Console.ReadLine());
        Circle circle = new Circle(r);
        circle.Display();
        Console.WriteLine("Circle Area: " + (circle.CalculateArea()).ToString("F2"));
        Console.Write("가로 길이를 입력하시오 : ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("세로 길이를 입력하시오 : ");
        int y = int.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(x, y);
        rectangle.Display();
        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
    }
}