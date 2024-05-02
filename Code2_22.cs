internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("현재 hour : " + DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);  // or 논리합
        Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);  // and 논리곱

        // 오버플로우, 언더플로우 발생시
        // -1에서 1을 더하면 0이 되듯 최솟값에서 값을 빼면 그 값만큼 빼짐
        // 오버플로우의 경우엔 음수의 가장 큰 값으로 간다.
        // 예) -2147483648 + (-1) = 2147483648 양수의 가장 큰 값으로 감
        // 예) -2147483648 + (-2) = 2147483647
        // 예) -2147483648 + (-3) = 2147483646
        int a = -2147483648;
        int b = -1;
        Console.WriteLine(a+b);

        // int.MaxValue의 값은 2147483647 int.MinValue의 값은 -2147483648
        Console.WriteLine(int.MaxValue + "\n" + int.MinValue);


        // 연결 연산자 연습
        int x = 10, y = 6;
        Console.WriteLine(x + " + " + y + " = " + (x + y));
        Console.WriteLine(x + " - " + y + " = " + (x - y));
        Console.WriteLine(x + " * " + y + " = " + (x * y));
        Console.WriteLine(x + " / " + y + " = " + ((double) x / y));
        Console.WriteLine(x + " % " + y + " = " + (x % y));
        
        // sizeof 연산자
        Console.WriteLine("int : " + sizeof(int) + " byte");
        Console.WriteLine("float : " + sizeof(float) + " byte");
        Console.WriteLine("double : " + sizeof(double) + " byte");
        Console.WriteLine("long : " + sizeof(long) + " byte");
        Console.WriteLine("char : " + sizeof(char) + " byte");
        // 자바와 C#의 크기는 2 byte로 동일하다. 단 C는 1 byte이다.
    }
}