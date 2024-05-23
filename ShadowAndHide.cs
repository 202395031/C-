internal class Program
{
    class Parent
    {
        public int variable = 273;
    }

    class Child : Parent 
    {
        public string variable = "shadowing";
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("인스턴스 변수 하이딩");
        Child child = new Child();
        Console.WriteLine(child.variable);

        Console.WriteLine("\n형 변환 시킨 variable");
        Console.WriteLine(((Parent)child).variable);
    }
}