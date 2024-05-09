class Point
{
    private int x;
    private int y;
    public void set(int x, int y) 
    {
        this.x = x; 
        this.y = y;
    }

    public void showPoint()
    {
        Console.WriteLine($"({x}, {y})");
    }
}
class ColorPoint : Point
{
    private String color;
    public void setColor(string x)
    {
        this.color = x;
    }
    public void showColorPoint() { Console.Write(color); showPoint(); }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Point p = new Point();
        p.set(1,2);
        p.showPoint();

        ColorPoint cp = new ColorPoint();
        cp.set(3, 4);
        cp.setColor("red");
        cp.showColorPoint();
    }
}