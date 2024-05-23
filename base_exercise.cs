class Parent
{
    public Parent() { Console.WriteLine("Parent()"); }
    public Parent(int param) { Console.WriteLine("Parent(int param)"); }
    public Parent(string param) { Console.WriteLine("Parent(string param)"); }
}

class Child : Parent
{
    public Child() : base() { Console.WriteLine("Child() : base()"); }
    public Child(int num) : base(num) { Console.WriteLine("Child(int num) : base(10)"); }
    public Child(string input) : base(input) { Console.WriteLine("Child(string input) : base(input)"); }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        Child childA = new Child();

        Console.WriteLine();
        Child childB = new Child(10);
        
        Console.WriteLine();
        Child childC = new Child("string");
    }
}