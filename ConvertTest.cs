internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("문자 입력 : ");
        // Console.Read()는 int로만 입력을 받을 수 있다.
        // 변수에 값을 입력 받으면 아스키 코드(유니 코드) 값으로 변환 되게 된다.
        int ascii = Console.Read();
        
        // Convert.ToChar()는 아스키코드 값을 문자로 바꾸어 준다. 예) 65의 경우 A로
        Console.WriteLine("\n1. 연산 수행 전");
        Console.WriteLine("- 아스키코드 값 : "+ ascii);
        Console.WriteLine("- 변환된 문자 출력 : " +  Convert.ToChar(ascii));

        ascii += 5;
        Console.WriteLine("\n2. 연산 수행 후");
        Console.WriteLine("- 아스키코드 값 : " + ascii);
        Console.WriteLine("- 변환된 문자 출력 : " + Convert.ToChar(ascii));
    }
}