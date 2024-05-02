internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("숫자 손상");
        long longNumber = 2147483647L + 2147483647L;
        int longToInt = (int)longNumber;
        Console.WriteLine(longToInt);

        double doubleNumber = 52.27310332;
        int doubleToInt = (int)doubleNumber;
        Console.WriteLine(doubleToInt);

        Console.WriteLine();
        Console.WriteLine("문자열을 숫자로 변환");
        Console.WriteLine(int.Parse("52"));
        Console.WriteLine(long.Parse("273"));
        Console.WriteLine(float.Parse("52.273"));
        Console.WriteLine(double.Parse("103.32"));
        Console.WriteLine(bool.Parse("True"));

        Console.WriteLine();
        Console.WriteLine("변화된 자료형 출력");
        Console.WriteLine(int.Parse("52").GetType());
        Console.WriteLine(long.Parse("273").GetType());
        Console.WriteLine(float.Parse("52.273").GetType());
        Console.WriteLine(double.Parse("103.32").GetType());
        Console.WriteLine(bool.Parse("True").GetType());
        
        Console.WriteLine();
        Console.WriteLine("숫자와 문자열 덧셈");
        Console.WriteLine(52 + 273);
        Console.WriteLine("52" + 273);  // 문자열로 출력됨
        Console.WriteLine(52 + "273");  // 문자열로 출력됨
        Console.WriteLine("52" + "273");
        
        Console.WriteLine();
        Console.WriteLine("int 문자열 변환");
        int number = 52273;
        string outputA = number + "?";
        Console.WriteLine(outputA);

        Console.WriteLine();
        Console.WriteLine("char 문자열 변환");
        char character = 'a';
        string outputB = character + "?";
        Console.WriteLine(outputB);
    }
}